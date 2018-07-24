using System;
using cell;

namespace cell.example
{
    class Program
    {
        static void Main()
        {
            RegisterCells();
            Console.Write("Input: ");
            var input = Console.ReadLine();

            var inputReceived = new InputReceived(input);

            EndocrineSystem.Inject(inputReceived);
        }

        static void RegisterCells()
        {
            EndocrineSystem.RegisterBinding(new ProcessingCell());
            EndocrineSystem.RegisterBinding(new InputValidationCell());
            EndocrineSystem.RegisterBinding(new WriteOutputCell());
            EndocrineSystem.RegisterBinding(new HormoneLoggingCell());
        }
    }
}
