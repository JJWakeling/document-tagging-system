using System.Collections.Generic;

namespace document_tagging_system
{
    public class Document : IDocument
    {
        private readonly string _shortName;
        private readonly IEnumerable<ITag> _tags;
        private readonly IUri _uri;

        public Document(string shortName, IEnumerable<ITag> tags, IUri uri)
        {
            _shortName = shortName;
            _tags = tags;
            _uri = uri;
        }

        public string ShortName()
        {
            return _shortName;
        }

        public IEnumerable<ITag> Tags()
        {
            return _tags;
        }

        public IUri Uri()
        {
            return _uri;
        }

        public void View()
        {
        }
    }
}
