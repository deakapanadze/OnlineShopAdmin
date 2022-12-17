using Core.Domain.Models;
using Infrastructure.Database.dbcontext;
using Microsoft.AspNetCore.Mvc;
using OnlineShopPage.Models;
using System.Diagnostics;

namespace OnlineShopPage.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		 private readonly DBContext _dbContext;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		private List<Customer> GetCustomers(string firstName, int Max = 10)
		{
			if (firstName == null) firstName = string.Empty;
			if (Max <= 0 || Max > 10000)
			{
				Max = 10;
			}
			//AdventureWorksLT2019Context dbContext = new AdventureWorksLT2019Context();
			var Customer = _dbContext.Customers
					.Where(x => x.FirstName.Contains(firstName))
					.Take(Max)
					.ToList();
			return Customer;

		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}