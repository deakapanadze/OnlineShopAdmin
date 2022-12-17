namespace OnlineShop.Models
{
	public class Newproduct
	{
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }

        public string Category { get; set; }
        public string Error { get; internal set; }

        public int Count { get; set; }
    }
}
