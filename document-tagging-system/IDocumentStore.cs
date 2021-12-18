using System.Collections.Generic;

namespace document_tagging_system
{
    public interface IDocumentStore
    {
        IEnumerable<IDocument> DocumentsWithExactTag(ITag tag);
    }
}
