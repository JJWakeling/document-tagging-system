using System.Collections.Generic;

namespace document_tagging_system
{
    public interface IDocument
    {
        IEnumerable<ITag> Tags();
        IUri Uri();
        /// <returns>human-readable version of the uri. Defaults to text of the uri.</returns>
        string ShortName();
        void View();
    }
}
