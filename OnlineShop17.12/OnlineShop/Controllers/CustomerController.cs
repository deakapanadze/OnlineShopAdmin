using AutoMapper;
using BusinessLayer;
using BusinessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
	public class CustomerController : Controller

	{

		private IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ICustomerRepository _icustomerrepository;
		

		public CustomerController(IMapper mapper)
		{
			_mapper = mapper;
		}
		public IActionResult Index()
		{
			IEnumerable<CustomerDto> customer = _mapper.Map<IEnumerable<CustomerDto>>(_unitOfWork.Customer.GetAll());

			return View(customer);
		
		}
	}
}
