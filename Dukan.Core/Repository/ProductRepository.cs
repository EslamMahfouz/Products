using AutoMapper;
using Dukan.Core.Models.Product;
using Dukan.Data;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Dukan.Core.Repository
{
    public class ProductRepository : Repository<Product>
    {
        #region Constructors
        public ProductRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        public bool IsExisting(string name)
        {
            return GetAll(p => p.Name == name).Any();
        }

        public void Add(AddProductModel product)
        {
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

        public bool IsBarcodeExisting(string barcode)
        {
            return GetAll(p => p.Barcode == barcode).Any();
        }
    }
}
