namespace FamilieImport.Domain
{
    public interface IImportEntity
    {
        string ItemId { get; }
        int ItemType { get; }
    }
}
