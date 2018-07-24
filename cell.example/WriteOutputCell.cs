using System;

namespace cell.example
{
    public class WriteOutputCell : Cell<ProcessingComplete>
    {
        public override Action<ProcessingComplete> GetHormonalResponse()
        {
            return hormone => WriteOutput(hormone);
        }

        public void WriteOutput(ProcessingComplete hormone)
        {
            Console.WriteLine("The input has been converted to base64: " + hormone.Base64Encoded);
        }
    }
}
