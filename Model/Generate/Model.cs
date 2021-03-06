﻿

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "Model\App.config"
//     Connection String Name: "NorthWindDbConnection"
//     Connection String:      "Data Source=(local)\local2012;Initial Catalog=Northwind;Integrated Security=True;Application Name=QIR;Enlist=false;MultipleActiveResultSets=true;"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Model.Entity
{
    // ************************************************************************
    // Unit of work
    public partial interface INorthWindDbContext : IDisposable
    {
        IDbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        IDbSet<Category> Categories { get; set; } // Categories
        IDbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; } // Category Sales for 1997
        IDbSet<CurrentProductList> CurrentProductLists { get; set; } // Current Product List
        IDbSet<Customer> Customers { get; set; } // Customers
        IDbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        IDbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        IDbSet<Employee> Employees { get; set; } // Employees
        IDbSet<EmployeesTerritory> EmployeesTerritories { get; set; } // EmployeesTerritories
        IDbSet<Invoice> Invoices { get; set; } // Invoices
        IDbSet<Order> Orders { get; set; } // Orders
        IDbSet<OrderDetail> OrderDetails { get; set; } // OrderDetails
        IDbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; } // Order Details Extended
        IDbSet<OrdersQry> OrdersQries { get; set; } // Orders Qry
        IDbSet<OrderSubtotal> OrderSubtotals { get; set; } // Order Subtotals
        IDbSet<PreviousEmployee> PreviousEmployees { get; set; } // PreviousEmployees
        IDbSet<Product> Products { get; set; } // Products
        IDbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; } // Products Above Average Price
        IDbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; } // Product Sales for 1997
        IDbSet<ProductsByCategory> ProductsByCategories { get; set; } // Products by Category
        IDbSet<Region> Regions { get; set; } // Regions
        IDbSet<SalesByCategory> SalesByCategories { get; set; } // Sales by Category
        IDbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        IDbSet<Shipper> Shippers { get; set; } // Shippers
        IDbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        IDbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; } // Summary of Sales by Year
        IDbSet<Supplier> Suppliers { get; set; } // Suppliers
        IDbSet<Territory> Territories { get; set; } // Territories

        int SaveChanges();
    }

    // ************************************************************************
    // Database context
    public partial class NorthWindDbContext : DbContext, INorthWindDbContext
    {
        public IDbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        public IDbSet<Category> Categories { get; set; } // Categories
        public IDbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; } // Category Sales for 1997
        public IDbSet<CurrentProductList> CurrentProductLists { get; set; } // Current Product List
        public IDbSet<Customer> Customers { get; set; } // Customers
        public IDbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        public IDbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        public IDbSet<Employee> Employees { get; set; } // Employees
        public IDbSet<EmployeesTerritory> EmployeesTerritories { get; set; } // EmployeesTerritories
        public IDbSet<Invoice> Invoices { get; set; } // Invoices
        public IDbSet<Order> Orders { get; set; } // Orders
        public IDbSet<OrderDetail> OrderDetails { get; set; } // OrderDetails
        public IDbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; } // Order Details Extended
        public IDbSet<OrdersQry> OrdersQries { get; set; } // Orders Qry
        public IDbSet<OrderSubtotal> OrderSubtotals { get; set; } // Order Subtotals
        public IDbSet<PreviousEmployee> PreviousEmployees { get; set; } // PreviousEmployees
        public IDbSet<Product> Products { get; set; } // Products
        public IDbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; } // Products Above Average Price
        public IDbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; } // Product Sales for 1997
        public IDbSet<ProductsByCategory> ProductsByCategories { get; set; } // Products by Category
        public IDbSet<Region> Regions { get; set; } // Regions
        public IDbSet<SalesByCategory> SalesByCategories { get; set; } // Sales by Category
        public IDbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        public IDbSet<Shipper> Shippers { get; set; } // Shippers
        public IDbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        public IDbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; } // Summary of Sales by Year
        public IDbSet<Supplier> Suppliers { get; set; } // Suppliers
        public IDbSet<Territory> Territories { get; set; } // Territories

        static NorthWindDbContext()
        {
            Database.SetInitializer<NorthWindDbContext>(null);
        }

        public NorthWindDbContext()
            : base("Name=NorthWindDbConnection")
        {
        InitializePartial();
        }

        public NorthWindDbContext(string connectionString) : base(connectionString)
        {
        InitializePartial();
        }

        public NorthWindDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        InitializePartial();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AlphabeticalListOfProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CategorySalesFor1997Configuration());
            modelBuilder.Configurations.Add(new CurrentProductListConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new CustomerAndSuppliersByCityConfiguration());
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EmployeesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailsExtendedConfiguration());
            modelBuilder.Configurations.Add(new OrdersQryConfiguration());
            modelBuilder.Configurations.Add(new OrderSubtotalConfiguration());
            modelBuilder.Configurations.Add(new PreviousEmployeeConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductsAboveAveragePriceConfiguration());
            modelBuilder.Configurations.Add(new ProductSalesFor1997Configuration());
            modelBuilder.Configurations.Add(new ProductsByCategoryConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());
            modelBuilder.Configurations.Add(new SalesByCategoryConfiguration());
            modelBuilder.Configurations.Add(new SalesTotalsByAmountConfiguration());
            modelBuilder.Configurations.Add(new ShipperConfiguration());
            modelBuilder.Configurations.Add(new SummaryOfSalesByQuarterConfiguration());
            modelBuilder.Configurations.Add(new SummaryOfSalesByYearConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new TerritoryConfiguration());
        OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AlphabeticalListOfProductConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new CategorySalesFor1997Configuration(schema));
            modelBuilder.Configurations.Add(new CurrentProductListConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerAndSuppliersByCityConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoiceConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailsExtendedConfiguration(schema));
            modelBuilder.Configurations.Add(new OrdersQryConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderSubtotalConfiguration(schema));
            modelBuilder.Configurations.Add(new PreviousEmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductsAboveAveragePriceConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductSalesFor1997Configuration(schema));
            modelBuilder.Configurations.Add(new ProductsByCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new RegionConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesByCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTotalsByAmountConfiguration(schema));
            modelBuilder.Configurations.Add(new ShipperConfiguration(schema));
            modelBuilder.Configurations.Add(new SummaryOfSalesByQuarterConfiguration(schema));
            modelBuilder.Configurations.Add(new SummaryOfSalesByYearConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierConfiguration(schema));
            modelBuilder.Configurations.Add(new TerritoryConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
    }

    // ************************************************************************
    // POCO classes

    // Alphabetical list of products
    public partial class AlphabeticalListOfProduct
    {
        public int ProductId { get; set; } // ProductID
        public string ProductName { get; set; } // ProductName
        public int? SupplierId { get; set; } // SupplierID
        public int? CategoryId { get; set; } // CategoryID
        public string QuantityPerUnit { get; set; } // QuantityPerUnit
        public decimal? UnitPrice { get; set; } // UnitPrice
        public short? UnitsInStock { get; set; } // UnitsInStock
        public short? UnitsOnOrder { get; set; } // UnitsOnOrder
        public short? ReorderLevel { get; set; } // ReorderLevel
        public bool Discontinued { get; set; } // Discontinued
        public string CategoryName { get; set; } // CategoryName
    }

    // Categories
    public partial class Category
    {
        public int CategoryId { get; set; } // CategoryID (Primary key)
        public string CategoryName { get; set; } // CategoryName
        public string Description { get; set; } // Description
        public byte[] Picture { get; set; } // Picture

        // Reverse navigation
        public virtual ICollection<Product> Products { get; set; } // Products.FK_Products_Categories

        public Category()
        {
            Products = new List<Product>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Category Sales for 1997
    public partial class CategorySalesFor1997
    {
        public string CategoryName { get; set; } // CategoryName
        public decimal? CategorySales { get; set; } // CategorySales
    }

    // Current Product List
    public partial class CurrentProductList
    {
        public int ProductId { get; set; } // ProductID
        public string ProductName { get; set; } // ProductName
    }

    // Customers
    public partial class Customer
    {
        public string CustomerId { get; set; } // CustomerID (Primary key)
        public string CompanyName { get; set; } // CompanyName
        public string ContactName { get; set; } // ContactName
        public string ContactTitle { get; set; } // ContactTitle
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
        public string Phone { get; set; } // Phone
        public string Fax { get; set; } // Fax

        // Reverse navigation
        public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; } // Many to many mapping
        public virtual ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Customers

        public Customer()
        {
            Orders = new List<Order>();
            CustomerDemographics = new List<CustomerDemographic>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Customer and Suppliers by City
    public partial class CustomerAndSuppliersByCity
    {
        public string City { get; set; } // City
        public string CompanyName { get; set; } // CompanyName
        public string ContactName { get; set; } // ContactName
        public string Relationship { get; set; } // Relationship
    }

    // CustomerDemographics
    public partial class CustomerDemographic
    {
        public string CustomerTypeId { get; set; } // CustomerTypeID (Primary key)
        public string CustomerDesc { get; set; } // CustomerDesc

        // Reverse navigation
        public virtual ICollection<Customer> Customers { get; set; } // Many to many mapping

        public CustomerDemographic()
        {
            Customers = new List<Customer>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Employees
    public partial class Employee
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public string LastName { get; set; } // LastName
        public string FirstName { get; set; } // FirstName
        public string Title { get; set; } // Title
        public string TitleOfCourtesy { get; set; } // TitleOfCourtesy
        public DateTime? BirthDate { get; set; } // BirthDate
        public DateTime? HireDate { get; set; } // HireDate
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
        public string HomePhone { get; set; } // HomePhone
        public string Extension { get; set; } // Extension
        public byte[] Photo { get; set; } // Photo
        public string Notes { get; set; } // Notes
        public int? ReportsTo { get; set; } // ReportsTo
        public string PhotoPath { get; set; } // PhotoPath

        // Reverse navigation
        public virtual ICollection<Employee> Employees { get; set; } // Employees.FK_Employees_Employees
        public virtual ICollection<EmployeesTerritory> EmployeesTerritories { get; set; } // Many to many mapping
        public virtual ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Employees
        public virtual ICollection<Territory> Territories { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Employee Employee_ReportsTo { get; set; } // FK_Employees_Employees

        public Employee()
        {
            Employees = new List<Employee>();
            EmployeesTerritories = new List<EmployeesTerritory>();
            Orders = new List<Order>();
            Territories = new List<Territory>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // EmployeesTerritories
    public partial class EmployeesTerritory
    {
        public int EmployeesEmployeeId { get; set; } // Employees_EmployeeID (Primary key)
        public int TerritoriesTerritoryId { get; set; } // Territories_TerritoryID (Primary key)

        // Foreign keys
        public virtual Employee Employee { get; set; } // FK_EmployeesTerritories_Employees
    }

    // Invoices
    public partial class Invoice
    {
        public string ShipName { get; set; } // ShipName
        public string ShipAddress { get; set; } // ShipAddress
        public string ShipCity { get; set; } // ShipCity
        public string ShipRegion { get; set; } // ShipRegion
        public string ShipPostalCode { get; set; } // ShipPostalCode
        public string ShipCountry { get; set; } // ShipCountry
        public string CustomerId { get; set; } // CustomerID
        public string CustomerName { get; set; } // CustomerName
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
        public string Salesperson { get; set; } // Salesperson
        public int OrderId { get; set; } // OrderID
        public DateTime? OrderDate { get; set; } // OrderDate
        public DateTime? RequiredDate { get; set; } // RequiredDate
        public DateTime? ShippedDate { get; set; } // ShippedDate
        public string ShipperName { get; set; } // ShipperName
        public int ProductId { get; set; } // ProductID
        public string ProductName { get; set; } // ProductName
        public decimal UnitPrice { get; set; } // UnitPrice
        public short Quantity { get; set; } // Quantity
        public float Discount { get; set; } // Discount
        public decimal? ExtendedPrice { get; set; } // ExtendedPrice
        public decimal? Freight { get; set; } // Freight
    }

    // Orders
    public partial class Order
    {
        public int OrderId { get; set; } // OrderID (Primary key)
        public string CustomerId { get; set; } // CustomerID
        public int? EmployeeId { get; set; } // EmployeeID
        public DateTime? OrderDate { get; set; } // OrderDate
        public DateTime? RequiredDate { get; set; } // RequiredDate
        public DateTime? ShippedDate { get; set; } // ShippedDate
        public int? ShipVia { get; set; } // ShipVia
        public decimal? Freight { get; set; } // Freight
        public string ShipName { get; set; } // ShipName
        public string ShipAddress { get; set; } // ShipAddress
        public string ShipCity { get; set; } // ShipCity
        public string ShipRegion { get; set; } // ShipRegion
        public string ShipPostalCode { get; set; } // ShipPostalCode
        public string ShipCountry { get; set; } // ShipCountry

        // Reverse navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Customer Customer { get; set; } // FK_Orders_Customers
        public virtual Employee Employee { get; set; } // FK_Orders_Employees
        public virtual Shipper Shipper { get; set; } // FK_Orders_Shippers

        public Order()
        {
            Freight = 0m;
            OrderDetails = new List<OrderDetail>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // OrderDetails
    public partial class OrderDetail
    {
        public int OrderId { get; set; } // OrderID (Primary key)
        public int ProductId { get; set; } // ProductID (Primary key)
        public decimal UnitPrice { get; set; } // UnitPrice
        public short Quantity { get; set; } // Quantity
        public float Discount { get; set; } // Discount

        // Foreign keys
        public virtual Order Order { get; set; } // FK_Order_Details_Orders
        public virtual Product Product { get; set; } // FK_Order_Details_Products

        public OrderDetail()
        {
            UnitPrice = 0m;
            Quantity = 1;
            Discount = 0;
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Order Details Extended
    public partial class OrderDetailsExtended
    {
        public int OrderId { get; set; } // OrderID
        public int ProductId { get; set; } // ProductID
        public string ProductName { get; set; } // ProductName
        public decimal UnitPrice { get; set; } // UnitPrice
        public short Quantity { get; set; } // Quantity
        public float Discount { get; set; } // Discount
        public decimal? ExtendedPrice { get; set; } // ExtendedPrice
    }

    // Orders Qry
    public partial class OrdersQry
    {
        public int OrderId { get; set; } // OrderID
        public string CustomerId { get; set; } // CustomerID
        public int? EmployeeId { get; set; } // EmployeeID
        public DateTime? OrderDate { get; set; } // OrderDate
        public DateTime? RequiredDate { get; set; } // RequiredDate
        public DateTime? ShippedDate { get; set; } // ShippedDate
        public int? ShipVia { get; set; } // ShipVia
        public decimal? Freight { get; set; } // Freight
        public string ShipName { get; set; } // ShipName
        public string ShipAddress { get; set; } // ShipAddress
        public string ShipCity { get; set; } // ShipCity
        public string ShipRegion { get; set; } // ShipRegion
        public string ShipPostalCode { get; set; } // ShipPostalCode
        public string ShipCountry { get; set; } // ShipCountry
        public string CompanyName { get; set; } // CompanyName
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
    }

    // Order Subtotals
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; } // OrderID
        public decimal? Subtotal { get; set; } // Subtotal
    }

    // PreviousEmployees
    public partial class PreviousEmployee
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public string LastName { get; set; } // LastName
        public string FirstName { get; set; } // FirstName
        public string Title { get; set; } // Title
        public string TitleOfCourtesy { get; set; } // TitleOfCourtesy
        public DateTime? BirthDate { get; set; } // BirthDate
        public DateTime? HireDate { get; set; } // HireDate
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
        public string HomePhone { get; set; } // HomePhone
        public string Extension { get; set; } // Extension
        public byte[] Photo { get; set; } // Photo
        public string Notes { get; set; } // Notes
        public string PhotoPath { get; set; } // PhotoPath
    }

    // Products
    public partial class Product
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public string ProductName { get; set; } // ProductName
        public int? SupplierId { get; set; } // SupplierID
        public int? CategoryId { get; set; } // CategoryID
        public string QuantityPerUnit { get; set; } // QuantityPerUnit
        public decimal? UnitPrice { get; set; } // UnitPrice
        public short? UnitsInStock { get; set; } // UnitsInStock
        public short? UnitsOnOrder { get; set; } // UnitsOnOrder
        public short? ReorderLevel { get; set; } // ReorderLevel
        public bool Discontinued { get; set; } // Discontinued

        // Reverse navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Category Category { get; set; } // FK_Products_Categories
        public virtual Supplier Supplier { get; set; } // FK_Products_Suppliers

        public Product()
        {
            UnitPrice = 0m;
            UnitsInStock = 0;
            UnitsOnOrder = 0;
            ReorderLevel = 0;
            Discontinued = false;
            OrderDetails = new List<OrderDetail>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Products Above Average Price
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } // ProductName
        public decimal? UnitPrice { get; set; } // UnitPrice
    }

    // Product Sales for 1997
    public partial class ProductSalesFor1997
    {
        public string CategoryName { get; set; } // CategoryName
        public string ProductName { get; set; } // ProductName
        public decimal? ProductSales { get; set; } // ProductSales
    }

    // Products by Category
    public partial class ProductsByCategory
    {
        public string CategoryName { get; set; } // CategoryName
        public string ProductName { get; set; } // ProductName
        public string QuantityPerUnit { get; set; } // QuantityPerUnit
        public short? UnitsInStock { get; set; } // UnitsInStock
        public bool Discontinued { get; set; } // Discontinued
    }

    // Regions
    public partial class Region
    {
        public int RegionId { get; set; } // RegionID (Primary key)
        public string RegionDescription { get; set; } // RegionDescription

        // Reverse navigation
        public virtual ICollection<Territory> Territories { get; set; } // Territories.FK_Territories_Region

        public Region()
        {
            Territories = new List<Territory>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Sales by Category
    public partial class SalesByCategory
    {
        public int CategoryId { get; set; } // CategoryID
        public string CategoryName { get; set; } // CategoryName
        public string ProductName { get; set; } // ProductName
        public decimal? ProductSales { get; set; } // ProductSales
    }

    // Sales Totals by Amount
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; } // SaleAmount
        public int OrderId { get; set; } // OrderID
        public string CompanyName { get; set; } // CompanyName
        public DateTime? ShippedDate { get; set; } // ShippedDate
    }

    // Shippers
    public partial class Shipper
    {
        public int ShipperId { get; set; } // ShipperID (Primary key)
        public string CompanyName { get; set; } // CompanyName
        public string Phone { get; set; } // Phone

        // Reverse navigation
        public virtual ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Shippers

        public Shipper()
        {
            Orders = new List<Order>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Summary of Sales by Quarter
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; } // ShippedDate
        public int OrderId { get; set; } // OrderID
        public decimal? Subtotal { get; set; } // Subtotal
    }

    // Summary of Sales by Year
    public partial class SummaryOfSalesByYear
    {
        public DateTime? ShippedDate { get; set; } // ShippedDate
        public int OrderId { get; set; } // OrderID
        public decimal? Subtotal { get; set; } // Subtotal
    }

    // Suppliers
    public partial class Supplier
    {
        public int SupplierId { get; set; } // SupplierID (Primary key)
        public string CompanyName { get; set; } // CompanyName
        public string ContactName { get; set; } // ContactName
        public string ContactTitle { get; set; } // ContactTitle
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
        public string Phone { get; set; } // Phone
        public string Fax { get; set; } // Fax
        public string HomePage { get; set; } // HomePage

        // Reverse navigation
        public virtual ICollection<Product> Products { get; set; } // Products.FK_Products_Suppliers

        public Supplier()
        {
            Products = new List<Product>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Territories
    public partial class Territory
    {
        public string TerritoryId { get; set; } // TerritoryID (Primary key)
        public string TerritoryDescription { get; set; } // TerritoryDescription
        public int RegionId { get; set; } // RegionID

        // Reverse navigation
        public virtual ICollection<Employee> Employees { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Region Region { get; set; } // FK_Territories_Region

        public Territory()
        {
            Employees = new List<Employee>();
            InitializePartial();
        }
        partial void InitializePartial();
    }


    // ************************************************************************
    // POCO Configuration

    // Alphabetical list of products
    internal partial class AlphabeticalListOfProductConfiguration : EntityTypeConfiguration<AlphabeticalListOfProduct>
    {
        public AlphabeticalListOfProductConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Alphabetical list of products");
            HasKey(x => new { x.ProductId, x.ProductName, x.Discontinued, x.CategoryName });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.SupplierId).HasColumnName("SupplierID").IsOptional();
            Property(x => x.CategoryId).HasColumnName("CategoryID").IsOptional();
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit").IsOptional().HasMaxLength(20);
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsOptional().HasPrecision(19,4);
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock").IsOptional();
            Property(x => x.UnitsOnOrder).HasColumnName("UnitsOnOrder").IsOptional();
            Property(x => x.ReorderLevel).HasColumnName("ReorderLevel").IsOptional();
            Property(x => x.Discontinued).HasColumnName("Discontinued").IsRequired();
            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasMaxLength(15);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Categories
    internal partial class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Categories");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("CategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasMaxLength(15);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(1073741823);
            Property(x => x.Picture).HasColumnName("Picture").IsOptional().HasMaxLength(2147483647);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Category Sales for 1997
    internal partial class CategorySalesFor1997Configuration : EntityTypeConfiguration<CategorySalesFor1997>
    {
        public CategorySalesFor1997Configuration(string schema = "dbo")
        {
            ToTable(schema + ".Category Sales for 1997");
            HasKey(x => x.CategoryName);

            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasMaxLength(15);
            Property(x => x.CategorySales).HasColumnName("CategorySales").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Current Product List
    internal partial class CurrentProductListConfiguration : EntityTypeConfiguration<CurrentProductList>
    {
        public CurrentProductListConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Current Product List");
            HasKey(x => new { x.ProductId, x.ProductName });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Customers
    internal partial class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Customers");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName("ContactName").IsOptional().HasMaxLength(30);
            Property(x => x.ContactTitle).HasColumnName("ContactTitle").IsOptional().HasMaxLength(30);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasMaxLength(24);
            Property(x => x.Fax).HasColumnName("Fax").IsOptional().HasMaxLength(24);
            HasMany(t => t.CustomerDemographics).WithMany(t => t.Customers).Map(m => 
            {
                m.ToTable("CustomerCustomerDemo");
                m.MapLeftKey("CustomerID");
                m.MapRightKey("CustomerTypeID");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Customer and Suppliers by City
    internal partial class CustomerAndSuppliersByCityConfiguration : EntityTypeConfiguration<CustomerAndSuppliersByCity>
    {
        public CustomerAndSuppliersByCityConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Customer and Suppliers by City");
            HasKey(x => new { x.CompanyName, x.Relationship });

            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName("ContactName").IsOptional().HasMaxLength(30);
            Property(x => x.Relationship).HasColumnName("Relationship").IsRequired().HasMaxLength(9);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // CustomerDemographics
    internal partial class CustomerDemographicConfiguration : EntityTypeConfiguration<CustomerDemographic>
    {
        public CustomerDemographicConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".CustomerDemographics");
            HasKey(x => x.CustomerTypeId);

            Property(x => x.CustomerTypeId).HasColumnName("CustomerTypeID").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CustomerDesc).HasColumnName("CustomerDesc").IsOptional().HasMaxLength(1073741823);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Employees
    internal partial class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Employees");
            HasKey(x => x.EmployeeId);

            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(20);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(10);
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(30);
            Property(x => x.TitleOfCourtesy).HasColumnName("TitleOfCourtesy").IsOptional().HasMaxLength(25);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsOptional();
            Property(x => x.HireDate).HasColumnName("HireDate").IsOptional();
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.HomePhone).HasColumnName("HomePhone").IsOptional().HasMaxLength(24);
            Property(x => x.Extension).HasColumnName("Extension").IsOptional().HasMaxLength(4);
            Property(x => x.Photo).HasColumnName("Photo").IsOptional().HasMaxLength(2147483647);
            Property(x => x.Notes).HasColumnName("Notes").IsOptional().HasMaxLength(1073741823);
            Property(x => x.ReportsTo).HasColumnName("ReportsTo").IsOptional();
            Property(x => x.PhotoPath).HasColumnName("PhotoPath").IsOptional().HasMaxLength(255);

            // Foreign keys
            HasOptional(a => a.Employee_ReportsTo).WithMany(b => b.Employees).HasForeignKey(c => c.ReportsTo); // FK_Employees_Employees
            HasMany(t => t.Territories).WithMany(t => t.Employees).Map(m => 
            {
                m.ToTable("EmployeeTerritories");
                m.MapLeftKey("EmployeeID");
                m.MapRightKey("TerritoryID");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // EmployeesTerritories
    internal partial class EmployeesTerritoryConfiguration : EntityTypeConfiguration<EmployeesTerritory>
    {
        public EmployeesTerritoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".EmployeesTerritories");
            HasKey(x => new { x.EmployeesEmployeeId, x.TerritoriesTerritoryId });

            Property(x => x.EmployeesEmployeeId).HasColumnName("Employees_EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoriesTerritoryId).HasColumnName("Territories_TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.EmployeesTerritories).HasForeignKey(c => c.EmployeesEmployeeId); // FK_EmployeesTerritories_Employees
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Invoices
    internal partial class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Invoices");
            HasKey(x => new { x.CustomerName, x.Salesperson, x.OrderId, x.ShipperName, x.ProductId, x.ProductName, x.UnitPrice, x.Quantity, x.Discount });

            Property(x => x.ShipName).HasColumnName("ShipName").IsOptional().HasMaxLength(40);
            Property(x => x.ShipAddress).HasColumnName("ShipAddress").IsOptional().HasMaxLength(60);
            Property(x => x.ShipCity).HasColumnName("ShipCity").IsOptional().HasMaxLength(15);
            Property(x => x.ShipRegion).HasColumnName("ShipRegion").IsOptional().HasMaxLength(15);
            Property(x => x.ShipPostalCode).HasColumnName("ShipPostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.ShipCountry).HasColumnName("ShipCountry").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsOptional().HasMaxLength(5);
            Property(x => x.CustomerName).HasColumnName("CustomerName").IsRequired().HasMaxLength(40);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.Salesperson).HasColumnName("Salesperson").IsRequired().HasMaxLength(31);
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsOptional();
            Property(x => x.RequiredDate).HasColumnName("RequiredDate").IsOptional();
            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional();
            Property(x => x.ShipperName).HasColumnName("ShipperName").IsRequired().HasMaxLength(40);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Discount).HasColumnName("Discount").IsRequired();
            Property(x => x.ExtendedPrice).HasColumnName("ExtendedPrice").IsOptional().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Orders
    internal partial class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Orders");
            HasKey(x => x.OrderId);

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsOptional().HasMaxLength(5);
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsOptional();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsOptional();
            Property(x => x.RequiredDate).HasColumnName("RequiredDate").IsOptional();
            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional();
            Property(x => x.ShipVia).HasColumnName("ShipVia").IsOptional();
            Property(x => x.Freight).HasColumnName("Freight").IsOptional().HasPrecision(19,4);
            Property(x => x.ShipName).HasColumnName("ShipName").IsOptional().HasMaxLength(40);
            Property(x => x.ShipAddress).HasColumnName("ShipAddress").IsOptional().HasMaxLength(60);
            Property(x => x.ShipCity).HasColumnName("ShipCity").IsOptional().HasMaxLength(15);
            Property(x => x.ShipRegion).HasColumnName("ShipRegion").IsOptional().HasMaxLength(15);
            Property(x => x.ShipPostalCode).HasColumnName("ShipPostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.ShipCountry).HasColumnName("ShipCountry").IsOptional().HasMaxLength(15);

            // Foreign keys
            HasOptional(a => a.Customer).WithMany(b => b.Orders).HasForeignKey(c => c.CustomerId); // FK_Orders_Customers
            HasOptional(a => a.Employee).WithMany(b => b.Orders).HasForeignKey(c => c.EmployeeId); // FK_Orders_Employees
            HasOptional(a => a.Shipper).WithMany(b => b.Orders).HasForeignKey(c => c.ShipVia); // FK_Orders_Shippers
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // OrderDetails
    internal partial class OrderDetailConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".OrderDetails");
            HasKey(x => new { x.OrderId, x.ProductId });

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Discount).HasColumnName("Discount").IsRequired();

            // Foreign keys
            HasRequired(a => a.Order).WithMany(b => b.OrderDetails).HasForeignKey(c => c.OrderId); // FK_Order_Details_Orders
            HasRequired(a => a.Product).WithMany(b => b.OrderDetails).HasForeignKey(c => c.ProductId); // FK_Order_Details_Products
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Order Details Extended
    internal partial class OrderDetailsExtendedConfiguration : EntityTypeConfiguration<OrderDetailsExtended>
    {
        public OrderDetailsExtendedConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Order Details Extended");
            HasKey(x => new { x.OrderId, x.ProductId, x.ProductName, x.UnitPrice, x.Quantity, x.Discount });

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Discount).HasColumnName("Discount").IsRequired();
            Property(x => x.ExtendedPrice).HasColumnName("ExtendedPrice").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Orders Qry
    internal partial class OrdersQryConfiguration : EntityTypeConfiguration<OrdersQry>
    {
        public OrdersQryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Orders Qry");
            HasKey(x => new { x.OrderId, x.CompanyName });

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsOptional().HasMaxLength(5);
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsOptional();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsOptional();
            Property(x => x.RequiredDate).HasColumnName("RequiredDate").IsOptional();
            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional();
            Property(x => x.ShipVia).HasColumnName("ShipVia").IsOptional();
            Property(x => x.Freight).HasColumnName("Freight").IsOptional().HasPrecision(19,4);
            Property(x => x.ShipName).HasColumnName("ShipName").IsOptional().HasMaxLength(40);
            Property(x => x.ShipAddress).HasColumnName("ShipAddress").IsOptional().HasMaxLength(60);
            Property(x => x.ShipCity).HasColumnName("ShipCity").IsOptional().HasMaxLength(15);
            Property(x => x.ShipRegion).HasColumnName("ShipRegion").IsOptional().HasMaxLength(15);
            Property(x => x.ShipPostalCode).HasColumnName("ShipPostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.ShipCountry).HasColumnName("ShipCountry").IsOptional().HasMaxLength(15);
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(40);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Order Subtotals
    internal partial class OrderSubtotalConfiguration : EntityTypeConfiguration<OrderSubtotal>
    {
        public OrderSubtotalConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Order Subtotals");
            HasKey(x => x.OrderId);

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.Subtotal).HasColumnName("Subtotal").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // PreviousEmployees
    internal partial class PreviousEmployeeConfiguration : EntityTypeConfiguration<PreviousEmployee>
    {
        public PreviousEmployeeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".PreviousEmployees");
            HasKey(x => x.EmployeeId);

            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(20);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(10);
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(30);
            Property(x => x.TitleOfCourtesy).HasColumnName("TitleOfCourtesy").IsOptional().HasMaxLength(25);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsOptional();
            Property(x => x.HireDate).HasColumnName("HireDate").IsOptional();
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.HomePhone).HasColumnName("HomePhone").IsOptional().HasMaxLength(24);
            Property(x => x.Extension).HasColumnName("Extension").IsOptional().HasMaxLength(4);
            Property(x => x.Photo).HasColumnName("Photo").IsOptional();
            Property(x => x.Notes).HasColumnName("Notes").IsOptional();
            Property(x => x.PhotoPath).HasColumnName("PhotoPath").IsOptional().HasMaxLength(255);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Products
    internal partial class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Products");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.SupplierId).HasColumnName("SupplierID").IsOptional();
            Property(x => x.CategoryId).HasColumnName("CategoryID").IsOptional();
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit").IsOptional().HasMaxLength(20);
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsOptional().HasPrecision(19,4);
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock").IsOptional();
            Property(x => x.UnitsOnOrder).HasColumnName("UnitsOnOrder").IsOptional();
            Property(x => x.ReorderLevel).HasColumnName("ReorderLevel").IsOptional();
            Property(x => x.Discontinued).HasColumnName("Discontinued").IsRequired();

            // Foreign keys
            HasOptional(a => a.Supplier).WithMany(b => b.Products).HasForeignKey(c => c.SupplierId); // FK_Products_Suppliers
            HasOptional(a => a.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId); // FK_Products_Categories
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Products Above Average Price
    internal partial class ProductsAboveAveragePriceConfiguration : EntityTypeConfiguration<ProductsAboveAveragePrice>
    {
        public ProductsAboveAveragePriceConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Products Above Average Price");
            HasKey(x => x.ProductName);

            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Product Sales for 1997
    internal partial class ProductSalesFor1997Configuration : EntityTypeConfiguration<ProductSalesFor1997>
    {
        public ProductSalesFor1997Configuration(string schema = "dbo")
        {
            ToTable(schema + ".Product Sales for 1997");
            HasKey(x => new { x.CategoryName, x.ProductName });

            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasMaxLength(15);
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.ProductSales).HasColumnName("ProductSales").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Products by Category
    internal partial class ProductsByCategoryConfiguration : EntityTypeConfiguration<ProductsByCategory>
    {
        public ProductsByCategoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Products by Category");
            HasKey(x => new { x.CategoryName, x.ProductName, x.Discontinued });

            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasMaxLength(15);
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit").IsOptional().HasMaxLength(20);
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock").IsOptional();
            Property(x => x.Discontinued).HasColumnName("Discontinued").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Regions
    internal partial class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Regions");
            HasKey(x => x.RegionId);

            Property(x => x.RegionId).HasColumnName("RegionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RegionDescription).HasColumnName("RegionDescription").IsRequired().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Sales by Category
    internal partial class SalesByCategoryConfiguration : EntityTypeConfiguration<SalesByCategory>
    {
        public SalesByCategoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Sales by Category");
            HasKey(x => new { x.CategoryId, x.CategoryName, x.ProductName });

            Property(x => x.CategoryId).HasColumnName("CategoryID").IsRequired();
            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasMaxLength(15);
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
            Property(x => x.ProductSales).HasColumnName("ProductSales").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Sales Totals by Amount
    internal partial class SalesTotalsByAmountConfiguration : EntityTypeConfiguration<SalesTotalsByAmount>
    {
        public SalesTotalsByAmountConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Sales Totals by Amount");
            HasKey(x => new { x.OrderId, x.CompanyName });

            Property(x => x.SaleAmount).HasColumnName("SaleAmount").IsOptional().HasPrecision(19,4);
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(40);
            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Shippers
    internal partial class ShipperConfiguration : EntityTypeConfiguration<Shipper>
    {
        public ShipperConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Shippers");
            HasKey(x => x.ShipperId);

            Property(x => x.ShipperId).HasColumnName("ShipperID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(40);
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasMaxLength(24);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Summary of Sales by Quarter
    internal partial class SummaryOfSalesByQuarterConfiguration : EntityTypeConfiguration<SummaryOfSalesByQuarter>
    {
        public SummaryOfSalesByQuarterConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Summary of Sales by Quarter");
            HasKey(x => x.OrderId);

            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional();
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.Subtotal).HasColumnName("Subtotal").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Summary of Sales by Year
    internal partial class SummaryOfSalesByYearConfiguration : EntityTypeConfiguration<SummaryOfSalesByYear>
    {
        public SummaryOfSalesByYearConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Summary of Sales by Year");
            HasKey(x => x.OrderId);

            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional();
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired();
            Property(x => x.Subtotal).HasColumnName("Subtotal").IsOptional().HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Suppliers
    internal partial class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Suppliers");
            HasKey(x => x.SupplierId);

            Property(x => x.SupplierId).HasColumnName("SupplierID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName("ContactName").IsOptional().HasMaxLength(30);
            Property(x => x.ContactTitle).HasColumnName("ContactTitle").IsOptional().HasMaxLength(30);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasMaxLength(24);
            Property(x => x.Fax).HasColumnName("Fax").IsOptional().HasMaxLength(24);
            Property(x => x.HomePage).HasColumnName("HomePage").IsOptional().HasMaxLength(1073741823);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Territories
    internal partial class TerritoryConfiguration : EntityTypeConfiguration<Territory>
    {
        public TerritoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Territories");
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryDescription).HasColumnName("TerritoryDescription").IsRequired().HasMaxLength(50);
            Property(x => x.RegionId).HasColumnName("RegionID").IsRequired();

            // Foreign keys
            HasRequired(a => a.Region).WithMany(b => b.Territories).HasForeignKey(c => c.RegionId); // FK_Territories_Region
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

