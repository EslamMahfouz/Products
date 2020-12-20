using AutoMapper;
using Dukan.Core.Models.Supplier;
using Dukan.Data;
using System.Collections.Generic;
using System.Linq;

namespace Dukan.Core.Repository
{
    public class SupplierRepository : Repository<Supplier>
    {
        #region Constructors

        public SupplierRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        public bool IsExisting(string name)
        {
            return GetAll(c => c.Name == name).Any();
        }

        public void Add(AddSupplierModel model)
        {
            var src = Mapper.Map<AddSupplierModel, Supplier>(model);
            Insert(src);
        }


        public IEnumerable<SupplierComoModel> GetSuppliersForCombo()
        {
            return Mapper.Map<IEnumerable<Supplier>, IEnumerable<SupplierComoModel>>(GetAll());
        }

        public IEnumerable<SupplierGridModel> GetSuppliersForGrid()
        {
            return Mapper.Map<IEnumerable<Supplier>, IEnumerable<SupplierGridModel>>(GetAll());
        }

        #endregion

    }
}
