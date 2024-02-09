using Microsoft.AspNetCore.Mvc;

namespace StanimalisThriftShop.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
