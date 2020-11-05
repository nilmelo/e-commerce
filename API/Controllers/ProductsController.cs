using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("api/Controller")]
    public class ProductsController : ControllerBase
    {
		[HttpGet]
		public string GetProducts()
		{
			return "Retorno de uma lista de produtos";
		}

		[HttpGet]
		public string GetProduct()
		{
			return "Retorno de um produto";
		}
    }
}
