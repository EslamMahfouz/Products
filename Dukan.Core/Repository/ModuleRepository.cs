using Dukan.Data;
using System.Linq;

namespace Dukan.Core.Repository
{
    public class ModuleRepository : Repository<Module>
    {
        public ModuleRepository(ProductsEntities context) : base(context)
        {
        }

        public bool GetModuleStatus(string moduleName)
        {
            var module = GetAll(m => m.Name == moduleName).FirstOrDefault();
            return module.IsActive;
        }
    }
}
