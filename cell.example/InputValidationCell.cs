using System;

namespace cell.example
{
    public class InputValidationCell : Cell<InputReceivedHormone>
    {
        public override Action<InputReceivedHormone> GetHormonalResponse()
        {
            return hormone => ValidateInput(hormone);
        }

        public void ValidateInput(InputReceivedHormone hormone)
        {
            if(isValid(hormone.Input)){
                Emit(new InputValidatedHormone(hormone.Input));
                return;
            }

            Emit(new InputValidationFailedHormone(hormone.Input));
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
