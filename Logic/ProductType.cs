namespace Logic
{
    class ProductType
    {
        private string ID { get; set; }
        private string value { get; set; }

        public ProductType() { }

        public ProductType(string ID, string value)
        {
            this.ID = ID;
            this.value = value;
        }
    }
}
