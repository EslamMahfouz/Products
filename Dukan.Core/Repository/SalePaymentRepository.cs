using AutoMapper;
using Dukan.Core.Models.Sale;
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

        public IEnumerable<SalePaymentModel> GetSalePayments(int saleId)
        {
            var payments = GetAll(p => p.SaleId == saleId);
            return Mapper.Map<IEnumerable<SalePayment>, IEnumerable<SalePaymentModel>>(payments);
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

        public IEnumerable<SalePaymentModel> GetSalePaymentsByDate(DateTime fromDate, DateTime toDate)
        {
            var payments = GetAll(p => TruncateTime(p.Date) >= fromDate && TruncateTime(p.Date) <= toDate,
                    o => o.OrderBy(p => new { p.Date, p.Sale.Number }),
                    "Sale")
                .ToList();
            return Mapper.Map<IEnumerable<SalePayment>, IEnumerable<SalePaymentModel>>(payments);
        }

        public decimal GetTotalPaymentsForADay(DateTime date)
        {
            var payments = GetAll(p => TruncateTime(p.Date) == TruncateTime(date));
            return payments.Sum(p => p.Paid);
        }
        #endregion
    }
}