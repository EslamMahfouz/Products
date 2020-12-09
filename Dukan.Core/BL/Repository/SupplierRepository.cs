using Dukan.Core.BL.Models;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Dukan.Core.BL.Repository
{
    public class SupplierRepository : Repository<Supplier>
    {
        #region Constructors

        public SupplierRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        private bool IsExisting(string name)
        {
            return GetAll(c => c.Name == name).Any();
        }

        public void Add(AddSupplierModel model)
        {
            if (IsExisting(model.SupplierName))
            {
                throw new Exception("يوجد مورد بهذا الاسم");
            }
            var src = Mapper.Map<AddSupplierModel, Supplier>(model);
            Insert(src);
        }

        public IEnumerable<SupplierGridModel> GetSuppliersForGrid()
        {
            return Mapper.Map<IEnumerable<Supplier>, IEnumerable<SupplierGridModel>>(GetAll());
        }

        #endregion

    }
}
