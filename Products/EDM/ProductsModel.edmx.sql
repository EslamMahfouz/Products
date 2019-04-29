
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/29/2019 20:48:39
-- Generated from EDMX file: D:\Source Control\Products\Products\EDM\ProductsModel.edmx
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
IF OBJECT_ID(N'[dbo].[FK_PurchasePayments_Purchases]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchasePayments] DROP CONSTRAINT [FK_PurchasePayments_Purchases];
GO
IF OBJECT_ID(N'[dbo].[FK_Purchases_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchases] DROP CONSTRAINT [FK_Purchases_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchasesDetails_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchaseDetails] DROP CONSTRAINT [FK_PurchasesDetails_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchasesDetails_Purchases]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchaseDetails] DROP CONSTRAINT [FK_PurchasesDetails_Purchases];
GO
IF OBJECT_ID(N'[dbo].[FK_Sales_Customers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_Customers];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesDetails_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SalesDetails_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesDetails_Sales]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SalesDetails_Sales];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesPayments_Sales]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SalePayments] DROP CONSTRAINT [FK_SalesPayments_Sales];
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
IF OBJECT_ID(N'[dbo].[PurchaseDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PurchaseDetails];
GO
IF OBJECT_ID(N'[dbo].[PurchasePayments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PurchasePayments];
GO
IF OBJECT_ID(N'[dbo].[Purchases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purchases];
GO
IF OBJECT_ID(N'[dbo].[SaleDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SaleDetails];
GO
IF OBJECT_ID(N'[dbo].[SalePayments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalePayments];
GO
IF OBJECT_ID(N'[dbo].[Sales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sales];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PurchaseDetails'
CREATE TABLE [dbo].[PurchaseDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PurchaseId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [ProductBuy] float  NULL,
    [Qte] int  NULL,
    [Total] float  NULL,
    [Discount] float  NULL,
    [TotalAfterDiscount] float  NULL
);
GO

-- Creating table 'PurchasePayments'
CREATE TABLE [dbo].[PurchasePayments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PurchaseId] int  NULL,
    [Date] datetime  NULL,
    [Paid] float  NOT NULL,
    [Description] nvarchar(50)  NULL
);
GO

-- Creating table 'Purchases'
CREATE TABLE [dbo].[Purchases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SupplierId] float  NOT NULL,
    [Date] datetime  NULL,
    [Number] int  NOT NULL,
    [Total] float  NULL,
    [Discount] float  NULL,
    [TotalAfterDiscount] float  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] float  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Phone] nvarchar(50)  NULL,
    [Tel] nvarchar(50)  NULL,
    [Address] nvarchar(500)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Phone] nvarchar(50)  NULL,
    [Tel] nvarchar(50)  NULL,
    [Address] nvarchar(500)  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryId] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Buy] float  NOT NULL,
    [Sell] float  NOT NULL,
    [Qte] int  NOT NULL,
    [Minimum] int  NULL
);
GO

-- Creating table 'SaleDetails'
CREATE TABLE [dbo].[SaleDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SaleId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [ProductBuy] float  NOT NULL,
    [ProductSell] float  NOT NULL,
    [Qte] int  NOT NULL,
    [Discount] float  NOT NULL,
    [ReturnedQte] int  NOT NULL
);
GO

-- Creating table 'SalePayments'
CREATE TABLE [dbo].[SalePayments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SaleId] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Paid] float  NOT NULL,
    [Type] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Sales'
CREATE TABLE [dbo].[Sales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Number] int  NOT NULL,
    [Discount] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PurchaseDetails'
ALTER TABLE [dbo].[PurchaseDetails]
ADD CONSTRAINT [PK_PurchaseDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PurchasePayments'
ALTER TABLE [dbo].[PurchasePayments]
ADD CONSTRAINT [PK_PurchasePayments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [PK_Purchases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SaleDetails'
ALTER TABLE [dbo].[SaleDetails]
ADD CONSTRAINT [PK_SaleDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SalePayments'
ALTER TABLE [dbo].[SalePayments]
ADD CONSTRAINT [PK_SalePayments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [PK_Sales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PurchaseId] in table 'PurchaseDetails'
ALTER TABLE [dbo].[PurchaseDetails]
ADD CONSTRAINT [FK_PurchasesDetails_Purchases]
    FOREIGN KEY ([PurchaseId])
    REFERENCES [dbo].[Purchases]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchasesDetails_Purchases'
CREATE INDEX [IX_FK_PurchasesDetails_Purchases]
ON [dbo].[PurchaseDetails]
    ([PurchaseId]);
GO

-- Creating foreign key on [PurchaseId] in table 'PurchasePayments'
ALTER TABLE [dbo].[PurchasePayments]
ADD CONSTRAINT [FK_PurchasePayments_Purchases]
    FOREIGN KEY ([PurchaseId])
    REFERENCES [dbo].[Purchases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchasePayments_Purchases'
CREATE INDEX [IX_FK_PurchasePayments_Purchases]
ON [dbo].[PurchasePayments]
    ([PurchaseId]);
GO

-- Creating foreign key on [SupplierId] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [FK_Purchases_Suppliers]
    FOREIGN KEY ([SupplierId])
    REFERENCES [dbo].[Suppliers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Purchases_Suppliers'
CREATE INDEX [IX_FK_Purchases_Suppliers]
ON [dbo].[Purchases]
    ([SupplierId]);
GO

-- Creating foreign key on [CategoryId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_Categories]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_Categories'
CREATE INDEX [IX_FK_Products_Categories]
ON [dbo].[Products]
    ([CategoryId]);
GO

-- Creating foreign key on [CustomerId] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [FK_Sales_Customers]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sales_Customers'
CREATE INDEX [IX_FK_Sales_Customers]
ON [dbo].[Sales]
    ([CustomerId]);
GO

-- Creating foreign key on [ProductId] in table 'PurchaseDetails'
ALTER TABLE [dbo].[PurchaseDetails]
ADD CONSTRAINT [FK_PurchasesDetails_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchasesDetails_Products'
CREATE INDEX [IX_FK_PurchasesDetails_Products]
ON [dbo].[PurchaseDetails]
    ([ProductId]);
GO

-- Creating foreign key on [ProductId] in table 'SaleDetails'
ALTER TABLE [dbo].[SaleDetails]
ADD CONSTRAINT [FK_SalesDetails_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesDetails_Products'
CREATE INDEX [IX_FK_SalesDetails_Products]
ON [dbo].[SaleDetails]
    ([ProductId]);
GO

-- Creating foreign key on [SaleId] in table 'SaleDetails'
ALTER TABLE [dbo].[SaleDetails]
ADD CONSTRAINT [FK_SalesDetails_Sales]
    FOREIGN KEY ([SaleId])
    REFERENCES [dbo].[Sales]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesDetails_Sales'
CREATE INDEX [IX_FK_SalesDetails_Sales]
ON [dbo].[SaleDetails]
    ([SaleId]);
GO

-- Creating foreign key on [SaleId] in table 'SalePayments'
ALTER TABLE [dbo].[SalePayments]
ADD CONSTRAINT [FK_SalesPayments_Sales]
    FOREIGN KEY ([SaleId])
    REFERENCES [dbo].[Sales]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesPayments_Sales'
CREATE INDEX [IX_FK_SalesPayments_Sales]
ON [dbo].[SalePayments]
    ([SaleId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------