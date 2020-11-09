using Core.Entities;

namespace Core.Specifications
{
    public class ProdFiltersForCountSpec : BaseSpecification<Product>
    {
        public ProdFiltersForCountSpec(ProductSpecParams productParams)
		: base (x =>
				(!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
				(!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
			)
		{

		}
    }
}
