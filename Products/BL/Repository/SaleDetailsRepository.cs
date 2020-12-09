using AutoMapper;
using Dukan.Data;
using Products.BL.Models;
using System.Collections.Generic;

namespace Products.BL.Repository
{
    public class SaleDetailsRepository : Repository<SaleDetail>
    {
        private readonly ProductsEntities _context;

        #region Constructors

        public SaleDetailsRepository(ProductsEntities context) : base(context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public IEnumerable<SaleDetailGridModel> GetSaleDetails(int saleId)
        {
            var saleDetails = GetAll(sd => sd.SaleId == saleId, null, "Product");
            return Mapper.Map<IEnumerable<SaleDetail>, IEnumerable<SaleDetailGridModel>>(saleDetails);
        }

        public IEnumerable<ProductReturnModel> GetSaleProducts(int saleId)
        {
            var src = GetAll(s => s.SaleId == saleId);
            return Mapper.Map<IEnumerable<SaleDetail>, IEnumerable<ProductReturnModel>>(src);
        }

        public void ReturnProduct(int saleDetailId, int qte)
        {
            var saleDetail = Get(saleDetailId);
            saleDetail.ReturnedQte += qte;
            var product = _context.Products.Find(saleDetail.ProductId);
            if (product != null)
            {
                product.Qte += qte;
            }
        }
        #endregion
    }
}
