using System.Collections.Generic;

namespace document_tagging_system
{
    public interface IPrimitiveTag
    {
        string Text();
        IEnumerable<IPrimitiveTag> Children();
    }
}
