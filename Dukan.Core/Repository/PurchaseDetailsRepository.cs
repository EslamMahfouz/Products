using AutoMapper;
using Dukan.Core.Models.Purchase;
using Dukan.Core.Models.Sale;
using Dukan.Data;
using System;
using System.Collections.Generic;
using static System.Data.Entity.DbFunctions;

namespace Dukan.Core.Repository
{
    public class PurchaseDetailsRepository : Repository<PurchaseDetail>
    {
        private readonly ProductsEntities _context;

        #region Constructors

        public PurchaseDetailsRepository(ProductsEntities context) : base(context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public IEnumerable<PurchaseDetailGridModel> GetPurchaseDetails(int purchaseId)
        {
            var purchaseDetails = GetAll(sd => sd.PurchaseId == purchaseId, null, "Product");
            return Mapper.Map<IEnumerable<PurchaseDetail>, IEnumerable<PurchaseDetailGridModel>>(purchaseDetails);
        }

        public IEnumerable<PurchaseDetailGridModel> GetPurchaseDetailsForProduct(int productId, DateTime fromDate, DateTime toDate)
        {
            var purchaseDetails = GetAll(x => TruncateTime(x.Purchase.Date) >= TruncateTime(fromDate) &&
                                TruncateTime(x.Purchase.Date) <= TruncateTime(toDate) && x.ProductId == productId, null, "Product");
            return Mapper.Map<IEnumerable<PurchaseDetail>, IEnumerable<PurchaseDetailGridModel>>(purchaseDetails);
        }


        public IEnumerable<ProductReturnModel> GetPurchaseProducts(int purchaseId)
        {
            var src = GetAll(s => s.PurchaseId == purchaseId);
            return Mapper.Map<IEnumerable<PurchaseDetail>, IEnumerable<ProductReturnModel>>(src);
        }

        public void ReturnProduct(int purchaseDetailId, int qte)
        {
            var purchaseDetail = Get(purchaseDetailId);
            purchaseDetail.ReturnedQte += qte;
            var product = _context.Products.Find(purchaseDetail.ProductId);
            if (product != null)
            {
                product.Qte -= qte;
            }
        }
        #endregion
    }
}
