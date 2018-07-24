namespace cell.example
{
    public class InputValidatedHormone : Hormone
    {
        public string Data { get; }

        public InputValidatedHormone(string data)
        {
            Data = data;
        }
    }
}
