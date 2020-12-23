using AutoMapper;
using Dukan.Core.Models.Sale;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using static System.Data.Entity.DbFunctions;

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

        public Sale GetSaleByDateAndNumber(DateTime date, int number)
        {
            return Get(p => TruncateTime(p.Date) == TruncateTime(date) && p.Number == number);
        }

        public SaleGridModel GetSaleById(int id)
        {
            var sale = Get(id);
            return Mapper.Map<Sale, SaleGridModel>(sale);
        }

        public IEnumerable<SaleGridModel> GetCustomerSales(int customerId)
        {
            var sales = GetAll(s => s.CustomerId == customerId, null, "SalePayments, SaleDetails");
            return Mapper.Map<IEnumerable<Sale>, IEnumerable<SaleGridModel>>(sales);
        }

        public bool IsExists(int id)
        {
            return GetAll(s => s.Id == id).Any();
        }

        public SaleReportModel GetSaleReport(int saleId)
        {
            return Mapper.Map<Sale, SaleReportModel>(Get(saleId));
        }

        #endregion
    }
}
