using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;

namespace OnlineShop.Controllers
{
	public class HomeController : Controller
	{
		private  OnlineShopDbContext dbContext;
		public HomeController()
		{
			dbContext = new OnlineShopDbContext();
		}
		public ActionResult Index()
		{
			Random random = new Random();
			OnlineShopDbContext dbcontext = new OnlineShopDbContext();
			var productsQuery =
				from p in dbcontext.Products.Include(x => x.ProductCategory)
				orderby p.ModifiedDate descending
				select p;

			var products = productsQuery.Take(20).ToList();

			var model = new ProductInformation
			{
				Products = products,
			};

			return View(model);
		}
		public ActionResult CreateProduct()
		{
			NewProductInfo product = new NewProductInfo();
			return View(product);
		}

		public ActionResult EditProduct(int productID)
		{
			OnlineShopDbContext dbcontext = new OnlineShopDbContext();
			var product = dbcontext.Products.Find(productID);

			if(product == null)
			return HttpNotFound("PRoduct not Find");

			return View(product);
		}

		[HttpPost]
		public ActionResult EditProduct(Product  product)
		{
			if (ModelState.IsValid)
			{
				try
				{
					OnlineShopDbContext dbcontext = new OnlineShopDbContext();

					var productFromDb = dbcontext.Products.Find(product.ProductID);
					if (productFromDb == null) return HttpNotFound();

					productFromDb.Name = product.Name;
					productFromDb.ProductNumber = product.ProductNumber;
					productFromDb.Color = product.Color;
					productFromDb.ListPrice = product.ListPrice;
					productFromDb.StandardCost = product.StandardCost;
					productFromDb.ModifiedDate = DateTime.Now;

					dbcontext.SaveChanges();
					return RedirectToAction("Index");
				}
				catch (Exception ex)
				{
					ModelState.AddModelError("Product", ex.Message);
					return View(product);
				}

				
			}
			return View(product);
		}
		[HttpPost]
		public ActionResult DeleteProduct(int productID)
		{
		

			bool success = false;
			string error = string.Empty;
			try
			{
				var d = new Product { ProductID = productID };
				dbContext.Entry(d).State = EntityState.Deleted;
				dbContext.Products.Remove(d);

				dbContext.SaveChanges();
				success = true;

			}
			catch(DbUpdateException ex)
			{
				if (ex.InnerException != null && ex.InnerException.InnerException != null)
				{
					error = ex.InnerException.InnerException.Message;
				}
				else
				{
					error = ex.ToString();
				}

			}
			return Json(new
			{
				Successful = success,
				Error = error,
			});

		}

		[HttpPost]
		public ActionResult CreateNewProduct(NewProductInfo newProductInfo)
		{
			var category = dbContext.ProductCategories
				.Where(x => x.Name == newProductInfo.Category)
				.FirstOrDefault();

			int? categoryid = null;

			if (category != null) categoryid = category.ProductCategoryID;
			var newProduct = new Product
			{
				Name = newProductInfo.Name,
				ProductNumber = newProductInfo.ProductNumber,
				ListPrice = newProductInfo.ListPrice,
				StandardCost = newProductInfo.StandardCost,
				Color = newProductInfo.Color,
				ProductCategoryID = categoryid,
				ModifiedDate = DateTime.Now,
				rowguid = Guid.NewGuid(),
				SellStartDate = DateTime.Now.AddDays(1),


			};


				dbContext.Products.Add(newProduct);
				try
				{
					dbContext.SaveChanges();
					return RedirectToAction("Index");
				}

				catch (Exception ex)
				{
					newProductInfo.Error = ex.Message;
					return View("CreateProduct", newProductInfo);
				}
		}
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}