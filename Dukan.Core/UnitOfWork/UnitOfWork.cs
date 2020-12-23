using Dukan.Core.Repository;
using Dukan.Data;

namespace Dukan.Core.UnitOfWork
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
        public PurchaseRepository Purchase { get; }
        public PurchaseDetailsRepository PurchaseDetails { get; }

        public PurchasePaymentRepository PurchasePayments { get; }

        public ModuleRepository Modules { get; }

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
            Purchase = new PurchaseRepository(_context);
            PurchaseDetails = new PurchaseDetailsRepository(_context);
            PurchasePayments = new PurchasePaymentRepository(_context);
            Modules = new ModuleRepository(_context);
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
