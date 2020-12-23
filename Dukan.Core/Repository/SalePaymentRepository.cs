using AutoMapper;
using Dukan.Core.Models.Shared;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Data.Entity.DbFunctions;

namespace Dukan.Core.Repository
{
    public class SalePaymentRepository : Repository<SalePayment>
    {
        private readonly ProductsEntities _context;

        #region Constructors

        public SalePaymentRepository(ProductsEntities context) : base(context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public IEnumerable<PaymentModel> GetSalePayments(int saleId)
        {
            var payments = GetAll(p => p.SaleId == saleId);
            return Mapper.Map<IEnumerable<SalePayment>, IEnumerable<PaymentModel>>(payments);
        }

        public void AddIncome(int saleId, decimal paid)
        {
            Insert(new SalePayment
            {
                SaleId = saleId,
                Date = DateTime.Now,
                Paid = paid,
                Type = "إيراد"
            });
        }

        public void AddExpense(int saleDetailId, decimal paid)
        {
            var saleId = _context.SaleDetails.Find(saleDetailId)?.SaleId;
            if (saleId != null)
            {
                Insert(new SalePayment
                {
                    SaleId = saleId.Value,
                    Date = DateTime.Now,
                    Paid = paid,
                    Type = "مرتجع"
                });
            }
        }

        public IEnumerable<PaymentModel> GetSalePaymentsByDate(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p =>
                        TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate && p.Type != Constants.Refund,
                    o => o.OrderBy(p => new { p.Date, p.Sale.Number }),
                    "Sale")
                .ToList();
            return Mapper.Map<IEnumerable<SalePayment>, IEnumerable<PaymentModel>>(payments);
        }

        public decimal GetTotalPaymentsForADay(DateTime date)
        {
            var payments = GetAll(p => TruncateTime(p.Date) == TruncateTime(date));
            return payments.Sum(p => p.Paid);
        }

        public IEnumerable<PaymentModel> GetSaleRefundPaymentsByDate(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p =>
                        TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate && p.Type == Constants.Refund,
                    o => o.OrderBy(p => new { p.Date, p.Sale.Number }),
                    "Sale")
                .ToList();
            return Mapper.Map<IEnumerable<SalePayment>, IEnumerable<PaymentModel>>(payments);

        }

        #endregion
    }
}