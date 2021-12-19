using System.Collections.Generic;
using System.Linq;

namespace document_tagging_system
{
    /// <summary>
    /// tag which has no parent
    /// </summary>
    public class RootTag : ITag
    {
        private readonly IPrimitiveTag _primitive;

        public RootTag(IPrimitiveTag primitive)
        {
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
            return _primitive.Text();
        }

        public string Text()
        {
            return _primitive.Text();
        }
    }
}
