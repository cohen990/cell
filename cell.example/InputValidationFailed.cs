namespace cell.example
{
    internal class InputValidationFailed : Hormone
    {
        private string input;

        public InputValidationFailed(string input)
        {
            this.input = input;
        }
    }   
}