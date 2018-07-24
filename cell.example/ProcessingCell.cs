using System;

namespace cell.example
{
    public class ProcessingCell : Cell<InputValidated>
    {
        public override Action<InputValidated> GetHormonalResponse()
        {
            return hormone => ProcessInput(hormone);
        }

        public void ProcessInput(InputValidated hormone)
        {
            String base64 = ConvertToBase64(hormone.Data);
            Emit(new ProcessingComplete(base64));
        }

        private String ConvertToBase64(String data){
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }
    }
}
