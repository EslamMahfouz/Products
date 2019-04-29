
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2019 00:36:21
-- Generated from EDMX file: C:\Users\eslam\Source\Repos\products\Products\EDM\ProductsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Products];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Products_Categories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Categories];
GO
IF OBJECT_ID(N'[dbo].[FK_Purchases_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchases] DROP CONSTRAINT [FK_Purchases_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchasesDetails_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchasesDetails] DROP CONSTRAINT [FK_PurchasesDetails_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchasesDetails_Purchases]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchasesDetails] DROP CONSTRAINT [FK_PurchasesDetails_Purchases];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchasesPayments_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchasesPayments] DROP CONSTRAINT [FK_PurchasesPayments_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_Sales_Customers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_Customers];
GO
IF OBJECT_ID(N'[dbo].[FK_SaleDetails_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SaleDetails_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_SaleDetails_Sales]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SaleDetails_Sales];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesPayments_Customers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SalesPayments] DROP CONSTRAINT [FK_SalesPayments_Customers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Purchases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purchases];
GO
IF OBJECT_ID(N'[dbo].[PurchasesDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PurchasesDetails];
GO
IF OBJECT_ID(N'[dbo].[PurchasesPayments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PurchasesPayments];
GO
IF OBJECT_ID(N'[dbo].[Sales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sales];
GO
IF OBJECT_ID(N'[dbo].[SaleDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SaleDetails];
GO
IF OBJECT_ID(N'[dbo].[SalesPayments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalesPayments];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryID] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerID] int IDENTITY(1,1) NOT NULL,
    [CustomerName] nvarchar(50)  NULL,
    [CustomerPhone] nvarchar(50)  NULL,
    [CustomerTel] nvarchar(50)  NULL,
    [CustomerAddress] nvarchar(500)  NULL,
    [CustomerCharge] float  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(50)  NULL,
    [ProductBuy] float  NULL,
    [ProductSell] float  NULL,
    [NumberInStock] int  NULL,
    [CategoryID] int  NULL
);
GO

-- Creating table 'Purchases'
CREATE TABLE [dbo].[Purchases] (
    [PurchaseID] int IDENTITY(1,1) NOT NULL,
    [PurchaseDate] datetime  NULL,
    [PurchasePrice] float  NULL,
    [PurchaseDiscount] float  NULL,
    [PurchaseNetPrice] float  NULL,
    [PurchasePaid] float  NULL,
    [PurchaseCharge] float  NULL,
    [SupplierID] int  NOT NULL,
    [PurchaseNumber] int  NOT NULL
);
GO

-- Creating table 'PurchasesDetails'
CREATE TABLE [dbo].[PurchasesDetails] (
    [PurchaseID] int  NOT NULL,
    [ProductID] int  NOT NULL,
    [ProductQte] int  NULL,
    [ProductPrice] float  NULL,
    [ProductDiscount] float  NULL,
    [ProductNetPrice] float  NULL
);
GO

-- Creating table 'Sales'
CREATE TABLE [dbo].[Sales] (
    [SaleID] int IDENTITY(1,1) NOT NULL,
    [SaleDate] datetime  NULL,
    [SalePrice] float  NULL,
    [SaleDiscount] float  NULL,
    [SaleNetPrice] float  NULL,
    [SalePaid] float  NULL,
    [SaleCharge] float  NULL,
    [CustomerID] int  NOT NULL,
    [SaleNumber] int  NOT NULL
);
GO

-- Creating table 'SaleDetails'
CREATE TABLE [dbo].[SaleDetails] (
    [SaleID] int  NOT NULL,
    [ProductID] int  NOT NULL,
    [ProductQte] int  NULL,
    [ProductPrice] float  NULL,
    [ProductDiscount] float  NULL,
    [ProductNetPrice] float  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [SupplierID] int  NOT NULL,
    [SupplierName] nvarchar(50)  NULL,
    [SupplierPhone] nvarchar(50)  NULL,
    [SupplierTel] nvarchar(50)  NULL,
    [SupplierAddress] nvarchar(500)  NULL,
    [SupplierCharge] float  NULL
);
GO

-- Creating table 'PurchasesPayments'
CREATE TABLE [dbo].[PurchasesPayments] (
    [PurchasePayID] int IDENTITY(1,1) NOT NULL,
    [PurchaseNumber] int  NULL,
    [PurchasePayPaid] float  NULL,
    [PurchasePayDate] datetime  NULL,
    [purchaseDescription] nvarchar(50)  NULL,
    [SupplierID] int  NOT NULL
);
GO

-- Creating table 'SalesPayments'
CREATE TABLE [dbo].[SalesPayments] (
    [SalePayID] int IDENTITY(1,1) NOT NULL,
    [SaleNumber] int  NOT NULL,
    [SalePayPaid] float  NULL,
    [SalePayDate] datetime  NULL,
    [SaleDescription] nvarchar(50)  NULL,
    [CustomerID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CategoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [CustomerID] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [PurchaseID] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [PK_Purchases]
    PRIMARY KEY CLUSTERED ([PurchaseID] ASC);
GO

-- Creating primary key on [PurchaseID], [ProductID] in table 'PurchasesDetails'
ALTER TABLE [dbo].[PurchasesDetails]
ADD CONSTRAINT [PK_PurchasesDetails]
    PRIMARY KEY CLUSTERED ([PurchaseID], [ProductID] ASC);
GO

-- Creating primary key on [SaleID] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [PK_Sales]
    PRIMARY KEY CLUSTERED ([SaleID] ASC);
GO

-- Creating primary key on [SaleID], [ProductID] in table 'SaleDetails'
ALTER TABLE [dbo].[SaleDetails]
ADD CONSTRAINT [PK_SaleDetails]
    PRIMARY KEY CLUSTERED ([SaleID], [ProductID] ASC);
GO

-- Creating primary key on [SupplierID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([SupplierID] ASC);
GO

-- Creating primary key on [PurchasePayID] in table 'PurchasesPayments'
ALTER TABLE [dbo].[PurchasesPayments]
ADD CONSTRAINT [PK_PurchasesPayments]
    PRIMARY KEY CLUSTERED ([PurchasePayID] ASC);
GO

-- Creating primary key on [SalePayID] in table 'SalesPayments'
ALTER TABLE [dbo].[SalesPayments]
ADD CONSTRAINT [PK_SalesPayments]
    PRIMARY KEY CLUSTERED ([SalePayID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoryID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_Categories]
    FOREIGN KEY ([CategoryID])
    REFERENCES [dbo].[Categories]
        ([CategoryID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_Categories'
CREATE INDEX [IX_FK_Products_Categories]
ON [dbo].[Products]
    ([CategoryID]);
GO

-- Creating foreign key on [CustomerID] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [FK_Sales_Customers]
    FOREIGN KEY ([CustomerID])
    REFERENCES [dbo].[Customers]
        ([CustomerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sales_Customers'
CREATE INDEX [IX_FK_Sales_Customers]
ON [dbo].[Sales]
    ([CustomerID]);
GO

-- Creating foreign key on [ProductID] in table 'PurchasesDetails'
ALTER TABLE [dbo].[PurchasesDetails]
ADD CONSTRAINT [FK_PurchasesDetails_Products]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchasesDetails_Products'
CREATE INDEX [IX_FK_PurchasesDetails_Products]
ON [dbo].[PurchasesDetails]
    ([ProductID]);
GO

-- Creating foreign key on [ProductID] in table 'SaleDetails'
ALTER TABLE [dbo].[SaleDetails]
ADD CONSTRAINT [FK_SaleDetails_Products]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SaleDetails_Products'
CREATE INDEX [IX_FK_SaleDetails_Products]
ON [dbo].[SaleDetails]
    ([ProductID]);
GO

-- Creating foreign key on [SupplierID] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [FK_Purchases_Suppliers]
    FOREIGN KEY ([SupplierID])
    REFERENCES [dbo].[Suppliers]
        ([SupplierID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Purchases_Suppliers'
CREATE INDEX [IX_FK_Purchases_Suppliers]
ON [dbo].[Purchases]
    ([SupplierID]);
GO

-- Creating foreign key on [PurchaseID] in table 'PurchasesDetails'
ALTER TABLE [dbo].[PurchasesDetails]
ADD CONSTRAINT [FK_PurchasesDetails_Purchases]
    FOREIGN KEY ([PurchaseID])
    REFERENCES [dbo].[Purchases]
        ([PurchaseID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SaleID] in table 'SaleDetails'
ALTER TABLE [dbo].[SaleDetails]
ADD CONSTRAINT [FK_SaleDetails_Sales]
    FOREIGN KEY ([SaleID])
    REFERENCES [dbo].[Sales]
        ([SaleID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CustomerID] in table 'SalesPayments'
ALTER TABLE [dbo].[SalesPayments]
ADD CONSTRAINT [FK_SalesPayments_Customers]
    FOREIGN KEY ([CustomerID])
    REFERENCES [dbo].[Customers]
        ([CustomerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesPayments_Customers'
CREATE INDEX [IX_FK_SalesPayments_Customers]
ON [dbo].[SalesPayments]
    ([CustomerID]);
GO

-- Creating foreign key on [SupplierID] in table 'PurchasesPayments'
ALTER TABLE [dbo].[PurchasesPayments]
ADD CONSTRAINT [FK_PurchasesPayments_Suppliers]
    FOREIGN KEY ([SupplierID])
    REFERENCES [dbo].[Suppliers]
        ([SupplierID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchasesPayments_Suppliers'
CREATE INDEX [IX_FK_PurchasesPayments_Suppliers]
ON [dbo].[PurchasesPayments]
    ([SupplierID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------