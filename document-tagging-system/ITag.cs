using System.Collections.Generic;

namespace document_tagging_system
{
    public interface ITag
    {
        /// <returns>final part of this tag's full text</returns>
        string Text();
        /// <returns>full qualified name of this tag e.g. base/parent/self</returns>
        string FullText();
        /// <returns>all tags whose FullText contains one more part appended to the FullText of this tag</returns>
        IEnumerable<ITag> Children();
    }
}
