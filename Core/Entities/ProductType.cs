using System.Linq;

namespace Core.Entities
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }
        //public IQueryable<ProductSubType> ProductSubTypes { get; set; }
    }
}