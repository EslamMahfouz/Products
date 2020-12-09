using Dukan.Core.BL.Models;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Dukan.Core.BL.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        #region Constructors

        public CustomerRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        private bool IsExisting(string name)
        {
            return GetAll(c => c.Name == name).Any();
        }

        public void Add(Customer customer)
        {
            if (IsExisting(customer.Name))
            {
                throw new ArgumentException("يوجد عميل بهذا الاسم");
            }
            //var src = Mapper.Map<AddCustomerModel, Customer>(model);
            Insert(customer);
        }

        public void Edit(EditCustomerModel model)
        {
            var customer = Get(model.Id);
            customer.Name = model.Name;
            customer.Tel = model.Tel;
            customer.Phone = model.Phone;
            customer.Address = model.Address;
        }

        public EditCustomerModel GetCustomerForEdit(int id)
        {
            return Mapper.Map<Customer, EditCustomerModel>(Get(id));
        }

        public IEnumerable<CustomerComboModel> GetCustomers()
        {
            return Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerComboModel>>(GetAll());
        }

        public IEnumerable<CustomerGridModel> GetCustomersForGrid()
        {
            return Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerGridModel>>(GetAll());
        }

        #endregion
    }
}
