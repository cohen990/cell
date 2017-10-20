using System;

namespace cell.example
{
    public class InputValidationCell : Cell
    {
        public InputValidationCell()
        {
            Bind<InputReceived>((hormone) => ValidateInput(hormone));
        }

        public void ValidateInput(InputReceived hormone)
        {
            if(isValid(hormone.Input)){
                Emit(new InputValidated(hormone.Input));
            }
        }

        private bool isValid(string input)
        {
            if(input.Length < 3){
                return true;
            }
            return false;
        }
    }
}
