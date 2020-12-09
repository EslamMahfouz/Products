using Dukan.Data;
using Module = System.Reflection.Module;

namespace Dukan.Core.Repository
{
    public class ModuleRepository : Repository<Module>
    {
        public ModuleRepository(ProductsEntities context) : base(context)
        {
        }
    }
}
