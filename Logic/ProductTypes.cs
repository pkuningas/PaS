using System.Linq;
namespace Logic
{
    public class ProductTypes: Archetypes<ProductType>
    {
        public static ProductTypes Instances { get; } = new ProductTypes();
        public ProductTypes GetProductTypesByID(string ID) //mitmus/ainsus?
        {
            var productTypes = new ProductTypes();
            var aa = Instances.ToList().FindAll(x => x.ID == ID);
            foreach (var a in aa)
            {
                productTypes.Add(a);
            }
            return productTypes;
        }
    }
}
