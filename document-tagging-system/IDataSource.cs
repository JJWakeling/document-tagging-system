namespace document_tagging_system
{
    public interface IDataSource
    {
        IDocumentStore Documents();
        ITagStore Tags();
    }
}
