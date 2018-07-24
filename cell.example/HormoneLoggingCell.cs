using System;

namespace cell.example
{
    public class HormoneLoggingCell : Cell<Hormone>
    {
        public override Action<Hormone> GetHormonalResponse()
        {
            return hormone => LogHormone(hormone);
        }

        public void LogHormone(Hormone hormone)
        {
            Console.WriteLine("Hormone Emitted: " + hormone.GetType());
        }
    }
}
