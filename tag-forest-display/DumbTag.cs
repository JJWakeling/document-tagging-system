using document_tagging_system;
using System.Collections.Generic;

namespace tag_forest_display
{
    /// <summary>
    /// tag that has no knowledge of its relations to other tags
    /// </summary>
    internal class DumbTag : ITag
    {
        private readonly string _fullText;

        public DumbTag(string fullText)
        {
            _fullText = fullText;
        }

        public IEnumerable<ITag> Children()
        {
            return new ITag[0];
        }

        public string FullText()
        {
            return _fullText;
        }

        public string Text()
        {
            var parts = _fullText.Split('/');
            return parts[^1];
        }
    }
}
