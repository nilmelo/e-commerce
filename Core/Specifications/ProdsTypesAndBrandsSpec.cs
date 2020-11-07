using Core.Entities;

namespace Core.Specifications
{
    public class ProdsTypesAndBrandsSpec : BaseSpecification<Product>
    {
		public ProdsTypesAndBrandsSpec()
		{
			AddInclude(x => x.ProductType);
			AddInclude(x => x.ProductBrand);
		}

		public ProdsTypesAndBrandsSpec(int id)
			: base(x => x.Id == id)
		{
			AddInclude(x => x.ProductType);
			AddInclude(x => x.ProductBrand);
		}
    }
}
