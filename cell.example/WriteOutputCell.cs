using System;

namespace cell.example
{
    public class WriteOutputCell : Cell<EncodingCompleteHormone>
    {
        public override Action<EncodingCompleteHormone> GetHormonalResponse()
        {
            return hormone => WriteOutput(hormone);
        }

        public void WriteOutput(EncodingCompleteHormone hormone)
        {
            Console.WriteLine("The input has been converted to base64: " + hormone.Base64Encoded);
        }
    }
}
