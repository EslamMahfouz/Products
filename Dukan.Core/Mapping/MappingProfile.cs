using AutoMapper;
using Dukan.Core.Models.Category;
using Dukan.Core.Models.Customer;
using Dukan.Core.Models.Product;
using Dukan.Core.Models.Purchase;
using Dukan.Core.Models.Sale;
using Dukan.Core.Models.Supplier;
using Dukan.Data;
using System.Linq;

namespace Dukan.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Categories

            CreateMap<Category, CategoryModel>();
            //CreateMap<Category, CategoryGridModel>();
            #endregion

            #region Products
            CreateMap<AddProductModel, Product>();
            CreateMap<ProductGridModel, Product>();

            CreateMap<Product, ProductComboModel>();

            CreateMap<Product, ProductGridModel>()
                .ForMember(d => d.CategoryName, o => o.MapFrom(s => s.Category.Name));

            #endregion

            #region Customers

            CreateMap<Customer, CustomerComboModel>();

            CreateMap<Customer, CustomerGridModel>()
                .ForMember(d => d.Charge, o => o.MapFrom(s =>
                    s.Sales.Sum(p =>
                        p.SaleDetails.Sum(sd =>
                            (sd.Qte - sd.ReturnedQte) * sd.ProductSell * sd.Discount))
                    - s.Sales.Sum(p =>
                        p.SalePayments.Sum(sp => sp.Paid))));
            CreateMap<AddCustomerModel, Customer>();
            CreateMap<EditCustomerModel, Customer>();
            #endregion

            #region Suppliers

            CreateMap<AddSupplierModel, Supplier>();
            CreateMap<Supplier, SupplierGridModel>();
            CreateMap<Supplier, SupplierComoModel>();

            #endregion

            #region Purchase

            CreateMap<Purchase, PurchaseGridModel>();
            CreateMap<PurchaseDetail, AddPurchaseDetailGridModel>();
            #endregion

            #region Purchase details

            CreateMap<AddPurchaseDetailGridModel, PurchaseDetail>()
                .ForMember(d => d.ReturnedQte, o => o.MapFrom(s => 0));

            #endregion

            #region Purchase payments

            CreateMap<PurchasePayment, PurchasePaymentModel>()
                .ForMember(d => d.Number, o => o.MapFrom(s => s.Purchase.Number));

            #endregion

            #region Sale

            //CreateMap<Sale, SaleModel>()

            //    //.ForMember(d => d.Charge, o => o.MapFrom(s => s.SaleDetail.Sum - s.SalePayments.Sum(p => p.Paid)))
            //    .ForMember(d => d.Paid, o => o.MapFrom(s => s.SalePayments.Sum(p => p.Paid)));

            CreateMap<Sale, SaleGridModel>();

            CreateMap<Sale, SaleReportModel>()
                .ForMember(d => d.CustomerName, o => o.MapFrom(s => s.Customer.Name))
                .ForMember(d => d.CustomerPhone, o => o.MapFrom(s => s.Customer.Phone))
                .ForMember(d => d.Discount, o => o.MapFrom(s => s.Discount / 100))
                .ForMember(d => d.SaleDetails, o => o.MapFrom(s => s.SaleDetails));

            #endregion

            #region Sale details

            CreateMap<AddSaleDetailGridModel, SaleDetail>()
                .ForMember(d => d.ReturnedQte, o => o.MapFrom(s => 0));

            CreateMap<SaleDetail, SaleDetailModel>()
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.Name));

            CreateMap<SaleDetail, SaleDetailGridModel>()
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.Name));


            CreateMap<SaleDetail, SaleDetailReportModel>()
                .ForMember(d => d.Discount, o => o.MapFrom(s => s.Discount / 100));

            CreateMap<SaleDetail, ProductReturnModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.Qte, o => o.MapFrom(s => s.Qte - s.ReturnedQte));


            #endregion

            #region Sale payments

            CreateMap<SalePayment, SalePaymentModel>()
                .ForMember(d => d.Number, o => o.MapFrom(s => s.Sale.Number));


            #endregion
        }
    }
}
