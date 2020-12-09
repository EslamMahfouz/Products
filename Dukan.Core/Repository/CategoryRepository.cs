using AutoMapper;
using Dukan.Core.Models.Category;
using Dukan.Data;
using System.Collections.Generic;
using System.Linq;

namespace Dukan.Core.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        #region Constructors

        public CategoryRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        public bool IsExisting(string name)
        {
            return GetAll(c => c.Name == name).Any();
        }

        public int Add(string name)
        {
            var added = Insert(new Category { Name = name });
            return added.Id;
        }

        public void Edit(int id, string value)
        {
            var category = Get(id);
            category.Name = value;
        }

        public IEnumerable<CategoryModel> GetCategoriesForCombo()
        {
            return Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryModel>>(GetAll());
        }

        public IEnumerable<CategoryModel> GetCategoriesForGrid()
        {
            return Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryModel>>(GetAll());
        }

        #endregion
    }
}
