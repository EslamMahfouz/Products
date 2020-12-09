using AutoMapper;
using Dukan.Core.Models;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace Dukan.Core.Repository
{
    public class SalesRepository : Repository<Sale>
    {
        #region Constructors

        public SalesRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region methods

        public Sale Add(Sale sale)
        {
            Insert(sale);
            Complete();
            return sale;
        }
        public string NewOrder()
        {
            var lastOrder = GetAll(o => EntityFunctions.TruncateTime(o.Date) == EntityFunctions.TruncateTime(DateTime.Now)).LastOrDefault();
            return lastOrder != null ? (lastOrder.Number + 1).ToString() : "1";
        }

        public IEnumerable<SaleGridModel> GetCustomerSales(int customerId)
        {
            var sales = GetAll(s => s.CustomerId == customerId, null, "SalePayments, SaleDetails");
            return Mapper.Map<IEnumerable<Sale>, IEnumerable<SaleGridModel>>(sales);
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
