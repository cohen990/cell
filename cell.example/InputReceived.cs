namespace cell.example
{
    public class InputReceived : Hormone
    {
        public string Input { get; }

        public InputReceived(string input)
        {
            Input = input;
        }
    }
}
