namespace Logic
{
    public class CatalogueEntries : Archetypes<CatalogueEntry>
    {
        public static CatalogueEntries Instances { get; } = new CatalogueEntries();
    }
}
