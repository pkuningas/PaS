namespace Logic
{
    public class ProductInstances : Archetypes<ProductInstance>
    {
        public static ProductInstances Instances { get; } = new ProductInstances();
    }
}
