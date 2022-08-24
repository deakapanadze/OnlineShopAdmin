using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class SalesController : Controller
    {
        public ActionResult Index()
        {
            OnlineShopDbContext dbContext = new OnlineShopDbContext();

            var data = (
                from sod in dbContext.SalesOrderDetails
                join soh in dbContext.SalesOrderHeaders
                    on sod.SalesOrderID equals soh.SalesOrderID
                join p in dbContext.Products
                    on sod.ProductID equals p.ProductID
                join pc in dbContext.ProductCategories
                    on p.ProductCategoryID equals pc.ProductCategoryID
                group sod by new
                {
                    soh.OrderDate.Year,
                    pc.Name,
                } into g
                select new SalesByProducts
                {
                    SalesAmount = g.Sum(x => x.OrderQty * x.UnitPrice),
                    Year = g.Key.Year,
                    Category = g.Key.Name,
                }
                ).ToList();

            SalesInformation model = new SalesInformation();

            model.Total = data.Sum(x => x.SalesAmount);
            model.Sales = data;

            var max = data.Max(x => x.SalesAmount);

            data.ForEach(x => x.PercentableMax = 100 * x.SalesAmount / model.Total);

            return View(model);
        }
    }
}