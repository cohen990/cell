using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cell
{
    public class EndocrineSystem
    {
        static Dictionary<Type, List<Action<Hormone>>> Bindings = new Dictionary<Type, List<Action<Hormone>>>(); 
        
        public static void Inject(Hormone hormone)
        {
            var availableBindings = Bindings.Keys;
            var actions = availableBindings
                .Where(x => 
                       hormone.GetType() == x || x.IsAssignableFrom(hormone.GetType())
                      )
                .SelectMany(x => Bindings[x]);

            Parallel.ForEach(actions, (action, b, d) => {
                action.Invoke(hormone);
            });
        }

        public static void RegisterBinding<HormoneType>(Cell<HormoneType> cell) where HormoneType : Hormone
        {
            List<Action<Hormone>> actions;
            if (Bindings.ContainsKey(typeof(HormoneType)))
            {
                actions = Bindings[typeof(HormoneType)];
            } else {
                actions = new List<Action<Hormone>>();
            }

            var response = cell.GetHormonalResponse();

            actions.Add(Convert(response));

            Bindings.Add(typeof(HormoneType), actions);
        }

        public static Action<Hormone> Convert<HormoneType>(Action<HormoneType> hormonalResponse)
        {
            if (hormonalResponse == null) 
                return null;
            
            return new Action<Hormone>(hormone => hormonalResponse((HormoneType) hormone));
        }
    }
}
