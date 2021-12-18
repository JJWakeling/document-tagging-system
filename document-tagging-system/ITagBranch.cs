using System.Collections.Generic;

namespace document_tagging_system
{
    public interface ITagBranch
    {
        ITag Tag();
        /// <returns>branch for each child tag of this branch's tag</returns>
        IEnumerable<ITagBranch> Branches();
        /// <returns>all documents with this branch's tag as a full tag</returns>
        IEnumerable<IDocument> Documents();
    }
}
