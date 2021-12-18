using System.Collections.Generic;
using System.Linq;

namespace document_tagging_system
{
    public class TagBranch : ITagBranch
    {
        private readonly ITag _tag;
        private readonly IDocumentStore _store;

        public TagBranch(ITag tag, IDocumentStore store)
        {
            _tag = tag;
            _store = store;
        }

        public IEnumerable<ITagBranch> Branches()
        {
            return _tag.Children().Select(c =>
                new TagBranch(c, _store)
            );
        }

        public IEnumerable<IDocument> Documents()
        {
            return _store.DocumentsWithExactTag(_tag);
        }

        public ITag Tag()
        {
            return _tag;
        }
    }
}
