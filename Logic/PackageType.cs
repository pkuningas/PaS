namespace Logic
{
    class PackageType
    {
        private PricingStrategy pricingStrategy;

        public PackageType(){}

        public PackageType(PricingStrategy strategy)
        {
            pricingStrategy = strategy;
        }

        public PricingStrategy GetPricingStrategy()
        {
            return pricingStrategy;
        }

        public void SetPricingStrategy(PricingStrategy strategy)
        {
            pricingStrategy = strategy;
        }
    }
}
