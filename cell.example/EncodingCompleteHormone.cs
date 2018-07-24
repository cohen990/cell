namespace cell.example
{
    public class EncodingCompleteHormone : Hormone
    {
        public string Base64Encoded { get; }

        public EncodingCompleteHormone(string base64Encoded)
        {
            Base64Encoded = base64Encoded;
        }
    }
}
