using System.Collections.Generic;

namespace document_tagging_system
{
    public interface ITagStore
    {
        IEnumerable<ITag> Children(ITag parent);
    }
}
