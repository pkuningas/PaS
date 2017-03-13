namespace Logic
{
    public class ProductType: Archetype
    {
        public string ID { get; set; }
        public PossiblePrices Prices { get; set; }
        public ProductType() { }

        public ProductType( string ID)
        {
            this.ID = ID;
            
        }
    }
}
