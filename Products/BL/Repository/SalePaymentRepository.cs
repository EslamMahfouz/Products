using AutoMapper;
using Dukan.Data;
using Products.BL.Models;
using System;
using System.Collections.Generic;

namespace Products.BL.Repository
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

        public void AddIncome(int saleId, double paid)
        {
            Insert(new SalePayment
            {
                SaleId = saleId,
                Date = DateTime.Now,
                Paid = paid,
                Type = "إيراد"
            });
        }

        public void AddExpense(int saleDetailId, double paid)
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

        #endregion
    }
}