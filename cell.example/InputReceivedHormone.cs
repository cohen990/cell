namespace cell.example
{
    public class InputReceivedHormone : Hormone
    {
        public string Input { get; }

        public InputReceivedHormone(string input)
        {
            Input = input;
        }
    }
}
