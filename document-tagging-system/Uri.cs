namespace document_tagging_system
{
    public class Uri : IUri
    {
        private readonly string _text;

        public Uri(string text)
        {
            _text = text;
        }

        public string Text()
        {
            return _text;
        }
    }
}
