using System.Collections.Generic;
using System.Linq;

namespace document_tagging_system
{
    public class DocumentStore : IDocumentStore
    {
        private readonly IEnumerable<IDocument> _documents;

        public DocumentStore(IEnumerable<IDocument> documents)
        {
            _documents = documents;
        }

        public IEnumerable<IDocument> DocumentsWithExactTag(ITag tag)
        {
            return _documents.Where(d =>
                d.Tags()
                    //TODO: make tags evaluate their own identity
                    // maybe write IIdentifiable<T> interface with 1 method: Identical(T)
                    .Any(t =>
                        t.FullText() == tag.FullText()
                    )
            );
        }
    }
}
