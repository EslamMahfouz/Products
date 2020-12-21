using AutoMapper;
using Dukan.Core.Models.Purchase;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Data.Entity.Core.Objects.EntityFunctions;

namespace Dukan.Core.Repository
{
    public class PurchaseRepository : Repository<Purchase>
    {
        #region Constructors

        public PurchaseRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region methods

        public Purchase Add(Purchase purchase)
        {
            Insert(purchase);
            return purchase;
        }
        public string NewOrder()
        {
            var lastOrder = GetAll(o => TruncateTime(o.Date) == TruncateTime(DateTime.Now)).LastOrDefault();
            return lastOrder != null ? (lastOrder.Number + 1).ToString() : "1";
        }

        public Purchase GetPurchaseByDateAndNumber(DateTime date, int number)
        {
            return Get(p => TruncateTime(p.Date) == TruncateTime(date) && p.Number == number);
        }

        public IEnumerable<PurchaseGridModel> GetSupplierPurchases(int supplierId)
        {
            var purchases = GetAll(s => s.SupplierId == supplierId, null, "PurchasePayments, PurchaseDetails");
            return Mapper.Map<IEnumerable<Purchase>, IEnumerable<PurchaseGridModel>>(purchases);
        }

        //public SaleReport GetSaleReport(int saleId)
        //{
        //    var sale = Mapper.Map<Sale, SaleReportModel>(Get(saleId));
        //    return new SaleReport
        //    {
        //        DataSource = sale.SaleDetails,
        //        CustomerName = { Value = sale.CustomerName },
        //        CustomerPhone = { Value = sale.CustomerPhone },
        //        Date = { Value = sale.Date },
        //        Number = { Value = sale.Number },
        //        SaleTotal = { Value = sale.Total },
        //        SaleDiscount = { Value = sale.Discount },
        //        SaleTotalAfterDiscount = { Value = sale.TotalAfterDiscount }
        //    };
        //}

        #endregion
    }
}
