using System;
using System.Collections.Generic;

namespace document_tagging_system.console_ui
{
    public class TagForestVisualisation
    {
        private readonly IEnumerable<ITagBranch> _roots;

        public TagForestVisualisation(IEnumerable<ITagBranch> roots)
        {
            _roots = roots;
        }

        public void Show()
        {
            foreach (var root in _roots)
            {
                Console.WriteLine(root.Tag().FullText() + ":");
                ShowContent(root, 1);
            }
        }

        //TODO: find more OO way of doing this
        private void ShowContent(ITagBranch branch, int indent)
        {
            foreach (var document in branch.Documents())
            {
                Console.Write(new string(' ', indent + 1) + '*');
                Console.WriteLine(document.ShortName());
            }

            foreach (var subBranch in branch.Branches())
            {
                Console.Write(new string(' ', indent) + '-');
                Console.WriteLine(subBranch.Tag().Text() + ":");

                ShowContent(branch, indent + 1);
            }
        }
    }
}
