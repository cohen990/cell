namespace cell.example
{
    public class ProcessingComplete : Hormone
    {
        public string Base64Encoded { get; }

        public ProcessingComplete(string base64Encoded)
        {
            Base64Encoded = base64Encoded;
        }
    }
}
