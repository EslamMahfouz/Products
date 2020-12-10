using AutoMapper;
using Dukan.Core.Models.Customer;
using Dukan.Data;
using System.Collections.Generic;
using System.Linq;

namespace Dukan.Core.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        #region Constructors

        public CustomerRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        public bool IsExisting(string name)
        {
            return GetAll(c => c.Name == name).Any();
        }

        public void Add(AddCustomerModel customer)
        {
            var src = Mapper.Map<AddCustomerModel, Customer>(customer);
            Insert(src);
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
