using Dukan.Core.Models.Purchase;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Data.Entity.DbFunctions;

namespace Dukan.Core.Repository
{
    public class PurchasePaymentRepository : Repository<PurchasePayment>
    {
        #region ctor
        public PurchasePaymentRepository(ProductsEntities context) : base(context)
        {
        }
        #endregion

        #region methods

        public IEnumerable<PurchasePaymentModel> GetPurchasePaymentsByDate(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p => TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate,
                    o => o.OrderBy(p => new { p.Date, p.Purchase.Number }),
                    "Purchase")
                .ToList();
            return AutoMapper.Mapper.Map<IEnumerable<PurchasePayment>, IEnumerable<PurchasePaymentModel>>(payments);
        }

        #endregion
    }
}
