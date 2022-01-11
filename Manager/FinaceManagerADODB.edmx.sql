
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/12/2020 20:02:11
-- Generated from EDMX file: C:\Users\jayasaigoutheman\Documents\MSC\Semester 1\Enterprise Application Development\Assignment 2\Manager\Manager\FinaceManagerADODB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBFinanceManger];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ContactEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_ContactEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_ContactTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_ContactTransaction];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [TransactionType] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Amount] float  NOT NULL,
    [Contact_Id] int  NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhoneNumber] int  NULL,
    [Comment] nvarchar(max)  NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EventType] nvarchar(max)  NOT NULL,
    [IsRecurring] bit  NOT NULL,
    [RecurringDays] smallint  NULL,
    [StartDate] datetime  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [EndDate] datetime  NULL,
    [Contact_Id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Contact_Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_ContactEvent]
    FOREIGN KEY ([Contact_Id])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactEvent'
CREATE INDEX [IX_FK_ContactEvent]
ON [dbo].[Events]
    ([Contact_Id]);
GO

-- Creating foreign key on [Contact_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_ContactTransaction]
    FOREIGN KEY ([Contact_Id])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactTransaction'
CREATE INDEX [IX_FK_ContactTransaction]
ON [dbo].[Transactions]
    ([Contact_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------