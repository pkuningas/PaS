namespace Logic
{
    public class CatalogueEntry
    {
        private string Identifier { get; set; }

        public CatalogueEntry GetCategories(string identifier)
        {
            this.Identifier = identifier;
            return null;
        }

        public CatalogueEntry GetProductTypes(string ID)
        {
            this.Identifier = ID;
            return null;
        }
}
}