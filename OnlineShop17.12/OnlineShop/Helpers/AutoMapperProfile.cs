using AutoMapper;
using DataAccessLayer.Models;
using OnlineShop.Models;

namespace OnlineShop.Helpers
{
	public class AutoMapperProfile : Profile
	{
		protected AutoMapperProfile()
		{
			CreateMap<CustomerDto, CustomerDto>()
				.ForPath(des => des.CustomerID, opt => opt.MapFrom(src => src.CustomerID))
				.ForPath(des => des.FirstName, opt => opt.MapFrom(src => src.FirstName))
				.ForPath(des => des.LastName, opt => opt.MapFrom(src => src.LastName));
			CreateMap<AddressDto, Address>();
			CreateMap<CustomerAddressDto, CustomerAddress>();
			CreateMap<ProductCategoryDto, ProductCategory>();
			CreateMap<ProductDescriptionDto, ProductDescription>();
			CreateMap<ProductDto, Product>();
			CreateMap<ProductModelProductDescriptionDto, ProductModelProductDescription>();
			CreateMap<SalesOrderDetailDto, SalesOrderDetail>();
			CreateMap<SalesOrderHeaderDto, SalesOrderHeader>();


		}
	}
}
