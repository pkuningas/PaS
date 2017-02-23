namespace Logic
{
    public class ProductType
    {
        public ProductTypeID ID { get; set; }
        public PossiblePrices Prices { get; set; }
        public ProductType() { }

        public ProductType( ProductTypeID ID)
        {
            this.ID = ID;
            
        }
    }
}
