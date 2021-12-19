using System.Collections.Generic;

namespace document_tagging_system
{
    public interface IModifiablePrimitiveTag : IPrimitiveTag
    {
        ICollection<IModifiablePrimitiveTag> ModifiableChildren();
    }
}
