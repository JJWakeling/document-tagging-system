using System.Collections.Generic;

namespace document_tagging_system
{
    /// <summary>
    /// tag which has no parent
    /// </summary>
    public class RootTag : ITag
    {
        private readonly ITagStore _store;
        private readonly string _text;

        public RootTag(ITagStore tagStore, string text)
        {
            _store = tagStore;
            _text = text;
        }

        public IEnumerable<ITag> Children()
        {
            return _store.Children(this);
        }

        public string FullText()
        {
            return _text;
        }

        public string Text()
        {
            return _text;
        }
    }
}
