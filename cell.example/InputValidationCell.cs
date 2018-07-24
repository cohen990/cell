using System;

namespace cell.example
{
    public class InputValidationCell : Cell<InputReceived>
    {
        public override Action<InputReceived> GetHormonalResponse()
        {
            return hormone => ValidateInput(hormone);
        }

        public void ValidateInput(InputReceived hormone)
        {
            if(isValid(hormone.Input)){
                Emit(new InputValidated(hormone.Input));
                return;
            }

            Emit(new InputValidationFailed(hormone.Input));
        }

        bool isValid(string input)
        {
            if(input.Length > 3){
                return true;
            }
            return false;
        }
    }
}
