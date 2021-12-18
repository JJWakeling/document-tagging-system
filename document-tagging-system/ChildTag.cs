using System.Collections.Generic;

namespace document_tagging_system
{
    public class ChildTag : ITag
    {
        private readonly string _text;
        private readonly ITag _parent;
        private readonly ITagStore _store;

        public ChildTag(string text, ITag parent, ITagStore store)
        {
            _text = text;
            _parent = parent;
            _store = store;
        }

        public IEnumerable<ITag> Children()
        {
            return _store.Children(this);
        }

        public string FullText()
        {
            return $"{_parent.FullText()}/{_text}";
        }

        public string Text()
        {
            return _text;
        }
    }
}
