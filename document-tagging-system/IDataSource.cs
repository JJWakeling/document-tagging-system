using System.Collections.Generic;

namespace document_tagging_system
{
    public interface IDataSource
    {
        IDocumentStore Documents();
        IEnumerable<ITag> RootTags();
    }
}
