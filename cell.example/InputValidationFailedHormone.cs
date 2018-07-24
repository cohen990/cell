namespace cell.example
{
    internal class InputValidationFailedHormone : Hormone
    {
        private string input;

        public InputValidationFailedHormone(string input)
        {
            this.input = input;
        }
    }   
}