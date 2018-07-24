using System;

namespace cell.example
{
    public class Base64EncodingCell : Cell<InputValidatedHormone>
    {
        public override Action<InputValidatedHormone> GetHormonalResponse()
        {
            return hormone => ProcessInput(hormone);
        }

        public void ProcessInput(InputValidatedHormone hormone)
        {
            String base64 = ConvertToBase64(hormone.Data);
            Emit(new EncodingCompleteHormone(base64));
        }

        private String ConvertToBase64(String data){
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }
    }
}
