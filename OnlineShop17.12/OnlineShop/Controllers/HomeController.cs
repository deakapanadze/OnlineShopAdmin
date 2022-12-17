using AutoMapper;
using BusinessLayer;
using BusinessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System.Diagnostics;

namespace OnlineShop.Controllers
{
	public class HomeController : Controller
	{
		private IUnitOfWork _unitOfWork;
		private readonly ILogger<HomeController> _logger;
		private readonly IMapper _mapper;
		private readonly ICustomerRepository _icustomerrepository;

		public HomeController(ILogger<HomeController> logger, IMapper mapper)
		{
			_logger = logger;
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		
	}
}