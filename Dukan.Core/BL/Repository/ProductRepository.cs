using AutoMapper;
using Dukan.Core.BL.Models;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Dukan.Core.BL.Repository
{
    public class ProductRepository : Repository<Product>
    {
        #region Constructors

        public ProductRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        private bool IsExisting(string name)
        {
            return GetAll(p => p.Name == name).Any();
        }

        public void Add(AddProductModel product)
        {
            if (IsExisting(product.Name))
            {
                throw new ArgumentException("يوجد منتج بهذا الاسم");
            }
            var added = Mapper.Map<AddProductModel, Product>(product);
            Insert(added);
        }

        public void Edit(Product product)
        {
            Context.Products.AddOrUpdate(product);
        }

        public IEnumerable<ProductComboModel> GetProductsForCombo()
        {
            return Mapper.Map<IEnumerable<Product>, IEnumerable<ProductComboModel>>(GetAll(p => p.Qte > 0));
        }

        public IEnumerable<ProductGridModel> GetProductsForGrid()
        {
            return Mapper.Map<IEnumerable<Product>, IEnumerable<ProductGridModel>>(GetAll());
        }

        #endregion
    }
}
