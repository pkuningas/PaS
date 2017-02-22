namespace Logic
{
    public class PackageType
    {
        public PricingStrategy pricingStrategy { get; set; }

        public PackageType(){ }

        public PackageType(PricingStrategy pricingStrategy)
        {
            this.pricingStrategy = pricingStrategy;
        }
    }
}
