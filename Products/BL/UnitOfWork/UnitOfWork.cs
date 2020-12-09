using Dukan.Data;
using Products.BL.Repository;

namespace Products.BL.UnitOfWork
{
    public class UnitOfWork
    {
        #region Fields

        private readonly ProductsEntities _context = new ProductsEntities();
        private static UnitOfWork _instance;

        #endregion

        #region Properties

        public static UnitOfWork Instance => _instance ?? (_instance = new UnitOfWork());

        #endregion


        #region Properties

        public CategoryRepository Categories { get; }
        public ProductRepository Products { get; }
        public CustomerRepository Customers { get; }
        public SupplierRepository Suppliers { get; }
        public SalesRepository Sales { get; }
        public SaleDetailsRepository SaleDetails { get; }
        public SalePaymentRepository SalePayments { get; }

        #endregion

        #region Constructors

        public UnitOfWork()
        {
            Categories = new CategoryRepository(_context);
            Products = new ProductRepository(_context);
            Customers = new CustomerRepository(_context);
            Suppliers = new SupplierRepository(_context);
            Sales = new SalesRepository(_context);
            SaleDetails = new SaleDetailsRepository(_context);
            SalePayments = new SalePaymentRepository(_context);
        }

        #endregion

        #region Methods

        public int Complete()
        {
            return _context.SaveChanges();
        }


        #endregion
    }
}
