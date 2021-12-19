using System.Collections.Generic;
using System.Linq;

namespace document_tagging_system
{
    public class ChildTag : ITag
    {
        private readonly ITag _parent;
        private readonly IPrimitiveTag _primitive;

        public ChildTag(ITag parent, IPrimitiveTag primitive)
        {
            _parent = parent;
            _primitive = primitive;
        }

        public IEnumerable<ITag> Children()
        {
            return _primitive.Children()
                .Select(c =>
                    new ChildTag(this, c)
                );
        }

        public string FullText()
        {
            return $"{_parent.FullText()}/{_primitive.Text()}";
        }

        public string Text()
        {
            return _primitive.Text();
        }
    }
}
