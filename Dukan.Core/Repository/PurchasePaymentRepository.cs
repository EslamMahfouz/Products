using AutoMapper;
using Dukan.Core.Models.Shared;
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

        public IEnumerable<PaymentModel> GetPurchasePaymentsByDate(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p => TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate,
                    o => o.OrderBy(p => new { p.Date, p.Purchase.Number }),
                    "Purchase")
                .ToList();
            return AutoMapper.Mapper.Map<IEnumerable<PurchasePayment>, IEnumerable<PaymentModel>>(payments);
        }

        public decimal GetTotalPaymentsForADay(DateTime date)
        {
            var payments = GetAll(p => TruncateTime(p.Date) == TruncateTime(date));
            return payments.Sum(p => p.Paid);
        }

        public IEnumerable<PaymentModel> GetPurchaseRefundPayments(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p =>
                        TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate && p.Type == Constants.Refund,
                    o => o.OrderBy(p => new { p.Date, p.Purchase.Number }),
                    "Purchase")
                .ToList();
            return Mapper.Map<IEnumerable<PurchasePayment>, IEnumerable<PaymentModel>>(payments);

        }

        #endregion
    }
}
