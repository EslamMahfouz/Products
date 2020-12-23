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
        private readonly ProductsEntities _context;

        #region ctor
        public PurchasePaymentRepository(ProductsEntities context) : base(context)
        {
            _context = context;
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

        public IEnumerable<PaymentModel> GetPurchaseRefundPaymentsByDate(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p =>
                        TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate && p.Type == Constants.Refund,
                    o => o.OrderBy(p => new { p.Date, p.Purchase.Number }),
                    "Purchase")
                .ToList();
            return Mapper.Map<IEnumerable<PurchasePayment>, IEnumerable<PaymentModel>>(payments);

        }

        #endregion

        public void AddIncome(int productId, decimal total)
        {
            var purchaseId = _context.PurchaseDetails.Find(productId)?.PurchaseId;
            if (purchaseId != null)
            {
                Insert(new PurchasePayment
                {
                    PurchaseId = purchaseId.Value,
                    Date = DateTime.Now,
                    Paid = total,
                    Type = "مرتجع"
                });
            }

        }
    }
}
