 

 

using Model.Entity;
using Model.Infrastructure;
using Model.UnitOfWork; 
using Model.UnitOfWork.Interface;
using Model.Infrastructure.Interface;
using NServiceBus.Logging;

namespace Schroders.Crpt.Qir.Model.Repository
{
    public partial interface ITerritoryRepository : IRepository<Territory>
    {
    }

    public partial class TerritoryRepository : Repository<Territory>, ITerritoryRepository
    {
        public TerritoryRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ISupplierRepository : IRepository<Supplier>
    {
    }

    public partial class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ISummaryOfSalesByYearRepository : IRepository<SummaryOfSalesByYear>
    {
    }

    public partial class SummaryOfSalesByYearRepository : Repository<SummaryOfSalesByYear>,
        ISummaryOfSalesByYearRepository
    {
        public SummaryOfSalesByYearRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ISummaryOfSalesByQuarterRepository : IRepository<SummaryOfSalesByQuarter>
    {
    }

    public partial class SummaryOfSalesByQuarterRepository : Repository<SummaryOfSalesByQuarter>,
        ISummaryOfSalesByQuarterRepository
    {
        public SummaryOfSalesByQuarterRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IShipperRepository : IRepository<Shipper>
    {
    }

    public partial class ShipperRepository : Repository<Shipper>, IShipperRepository
    {
        public ShipperRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ISalesTotalsByAmountRepository : IRepository<SalesTotalsByAmount>
    {
    }

    public partial class SalesTotalsByAmountRepository : Repository<SalesTotalsByAmount>, ISalesTotalsByAmountRepository
    {
        public SalesTotalsByAmountRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ISalesByCategoryRepository : IRepository<SalesByCategory>
    {
    }

    public partial class SalesByCategoryRepository : Repository<SalesByCategory>, ISalesByCategoryRepository
    {
        public SalesByCategoryRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IRegionRepository : IRepository<Region>
    {
    }

    public partial class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IProductsByCategoryRepository : IRepository<ProductsByCategory>
    {
    }

    public partial class ProductsByCategoryRepository : Repository<ProductsByCategory>, IProductsByCategoryRepository
    {
        public ProductsByCategoryRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IProductSalesFor1997Repository : IRepository<ProductSalesFor1997>
    {
    }

    public partial class ProductSalesFor1997Repository : Repository<ProductSalesFor1997>, IProductSalesFor1997Repository
    {
        public ProductSalesFor1997Repository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IProductsAboveAveragePriceRepository : IRepository<ProductsAboveAveragePrice>
    {
    }

    public partial class ProductsAboveAveragePriceRepository : Repository<ProductsAboveAveragePrice>,
        IProductsAboveAveragePriceRepository
    {
        public ProductsAboveAveragePriceRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IProductRepository : IRepository<Product>
    {
    }

    public partial class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IPreviousEmployeeRepository : IRepository<PreviousEmployee>
    {
    }

    public partial class PreviousEmployeeRepository : Repository<PreviousEmployee>, IPreviousEmployeeRepository
    {
        public PreviousEmployeeRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IOrderSubtotalRepository : IRepository<OrderSubtotal>
    {
    }

    public partial class OrderSubtotalRepository : Repository<OrderSubtotal>, IOrderSubtotalRepository
    {
        public OrderSubtotalRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IOrdersQryRepository : IRepository<OrdersQry>
    {
    }

    public partial class OrdersQryRepository : Repository<OrdersQry>, IOrdersQryRepository
    {
        public OrdersQryRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IOrderDetailsExtendedRepository : IRepository<OrderDetailsExtended>
    {
    }

    public partial class OrderDetailsExtendedRepository : Repository<OrderDetailsExtended>,
        IOrderDetailsExtendedRepository
    {
        public OrderDetailsExtendedRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }

    public partial class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IOrderRepository : IRepository<Order>
    {
        int Number { get; }
    }

    public partial class OrderRepository : Repository<Order>, IOrderRepository
    {
        protected static readonly ILog Logger = LogManager.GetLogger(typeof(OrderRepository));
        private int number;

        public OrderRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
            number = qirUnitOfWork.Number;
            Logger.InfoFormat("OrderRepository ctor, {0}", number);
        }

        public int Number
        {
            get { return number; }
        }
    }

    public partial interface IInvoiceRepository : IRepository<Invoice>
    {
    }

    public partial class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IEmployeesTerritoryRepository : IRepository<EmployeesTerritory>
    {
    }

    public partial class EmployeesTerritoryRepository : Repository<EmployeesTerritory>, IEmployeesTerritoryRepository
    {
        public EmployeesTerritoryRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IEmployeeRepository : IRepository<Employee>
    {
    }

    public partial class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ICustomerDemographicRepository : IRepository<CustomerDemographic>
    {
    }

    public partial class CustomerDemographicRepository : Repository<CustomerDemographic>, ICustomerDemographicRepository
    {
        public CustomerDemographicRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ICustomerAndSuppliersByCityRepository : IRepository<CustomerAndSuppliersByCity>
    {
    }

    public partial class CustomerAndSuppliersByCityRepository : Repository<CustomerAndSuppliersByCity>,
        ICustomerAndSuppliersByCityRepository
    {
        public CustomerAndSuppliersByCityRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ICustomerRepository : IRepository<Customer>
    {
    }

    public partial class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ICurrentProductListRepository : IRepository<CurrentProductList>
    {
    }

    public partial class CurrentProductListRepository : Repository<CurrentProductList>, ICurrentProductListRepository
    {
        public CurrentProductListRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ICategorySalesFor1997Repository : IRepository<CategorySalesFor1997>
    {
    }

    public partial class CategorySalesFor1997Repository : Repository<CategorySalesFor1997>,
        ICategorySalesFor1997Repository
    {
        public CategorySalesFor1997Repository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface ICategoryRepository : IRepository<Category>
    {
    }

    public partial class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IAlphabeticalListOfProductRepository : IRepository<AlphabeticalListOfProduct>
    {
    }

    public partial class AlphabeticalListOfProductRepository : Repository<AlphabeticalListOfProduct>,
        IAlphabeticalListOfProductRepository
    {
        public AlphabeticalListOfProductRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface INorthWindDbContextRepository : IRepository<NorthWindDbContext>
    {
    }

    public partial class NorthWindDbContextRepository : Repository<NorthWindDbContext>, INorthWindDbContextRepository
    {
        public NorthWindDbContextRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }

    public partial interface IQirUnitOfWorkRepository : IRepository<QirUnitOfWork>
    {
    }

    public partial class QirUnitOfWorkRepository : Repository<QirUnitOfWork>, IQirUnitOfWorkRepository
    {
        public QirUnitOfWorkRepository(IQirUnitOfWork qirUnitOfWork)
            : base(qirUnitOfWork)
        {
        }
    }
} // End Namespace