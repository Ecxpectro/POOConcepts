using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
