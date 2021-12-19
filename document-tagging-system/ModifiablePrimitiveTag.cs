using System.Collections.Generic;

namespace document_tagging_system
{
    public class ModifiablePrimitiveTag : IModifiablePrimitiveTag
    {
        private readonly string _text;
        private readonly ICollection<IModifiablePrimitiveTag> _children;

        public ModifiablePrimitiveTag(string text, ICollection<IModifiablePrimitiveTag> children)
        {
            _text = text;
            _children = children;
        }

        public IEnumerable<IPrimitiveTag> Children()
        {
            return _children;
        }

        public ICollection<IModifiablePrimitiveTag> ModifiableChildren()
        {
            return _children;
        }

        public string Text()
        {
            return _text;
        }
    }
}
