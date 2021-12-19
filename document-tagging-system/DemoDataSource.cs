using System.Collections.Generic;
using System.Linq;

namespace document_tagging_system
{
    public class DemoDataSource : IDataSource
    {
        private readonly IEnumerable<IDocument> _documents;

        public DemoDataSource(IEnumerable<IDocument> documents)
        {
            _documents = documents;
        }

        public IDocumentStore Documents()
        {
            return new DocumentStore(_documents);
        }

        public IEnumerable<ITag> RootTags()
        {
            var primitiveRoots = new List<IModifiablePrimitiveTag>();

            foreach (var fullTag in _documents.SelectMany(d => d.Tags(), (d, t) => t.FullText()))
            {
                ICollection<IModifiablePrimitiveTag> tags = primitiveRoots;

                foreach (var tag in fullTag.Split('/'))
                {
                    if (!tags.Any(t => t.Text() == tag))
                    {
                        tags.Add(new ModifiablePrimitiveTag(tag, new List<IModifiablePrimitiveTag>()));
                    }

                    tags = tags.First(t => t.Text() == tag).ModifiableChildren();
                }
            }

            return primitiveRoots.Select(r => new RootTag(r));
        }
    }
}
