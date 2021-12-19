using document_tagging_system;
using document_tagging_system.console_ui;
using System.Linq;

namespace tag_forest_display
{
    internal class Program
    {
        public static void Main()
        {
            IDataSource source = new DemoDataSource(
                new IDocument[]
                {
                    new Document(
                        "Artificial Unintelligence",
                        new ITag[]
                        {
                            new DumbTag("books"),
                            new DumbTag("computing/software/artificial-intelligence")
                        },
                        new Uri("isbn:9780262038003")
                    ),
                    new Document(
                        "Anarchism and Other Essays",
                        new ITag[]
                        {
                            new DumbTag("books"),
                            new DumbTag("politics/anarchism")
                        },
                        new Uri("isbn:1234567890123")
                    ),
                    new Document(
                        "The Hitchhiker's Guide to the Galaxy",
                        new ITag[]
                        {
                            new DumbTag("books")
                        },
                        new Uri("isbn:0987654321098")
                    ),
                    new Document(
                        "leftfootforward.org/2021/12/mass-protest-planned-against-nationality-and-borders-bill-outside-downing-street/",
                        new ITag[]
                        {
                            new DumbTag("news"),
                            new DumbTag("politics")
                        },
                        new Uri("leftfootforward.org/2021/12/mass-protest-planned-against-nationality-and-borders-bill-outside-downing-street/")
                    ),
                    new Document(
                        "AI argues for and against itself",
                        new ITag[]
                        {
                            new DumbTag("news/bbc"),
                            new DumbTag("computing/software/artificial-intelligence")
                        },
                        new Uri("https://www.bbc.co.uk/news/technology-59687236")
                    ),
                    new Document(
                        "infomesh.net/html/history/early/",
                        new ITag[]
                        {
                            new DumbTag("computing/standards")
                        },
                        new Uri("infomesh.net/html/history/early/")
                    )
                }
            );

            new TagForestVisualisation(
                source.RootTags()
                    .Select(t =>
                        new TagBranch(t, source.Documents())
                    )
            )
                .Show();

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
