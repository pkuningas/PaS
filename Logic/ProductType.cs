namespace Logic
{
    public class ProductType: Archetype
    {
        public string ID { get; set; } //ProductTypeID
        public PossiblePrices Prices { get; set; }
        public ProductType() { }

        public ProductType( string ID) //ProductTypeID
        {
            this.ID = ID;
            
        }
    }
}
