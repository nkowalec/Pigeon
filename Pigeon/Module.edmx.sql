
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/13/2015 15:33:00
-- Generated from EDMX file: C:\Projekty\Pigeon\Pigeon\Module.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
--USE [PDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PodmiotKontakt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kontakty] DROP CONSTRAINT [FK_PodmiotKontakt];
GO
IF OBJECT_ID(N'[dbo].[FK_WiadomośćKontakt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Wiadomości] DROP CONSTRAINT [FK_WiadomośćKontakt];
GO
IF OBJECT_ID(N'[dbo].[FK_WiadomośćAdresatDW]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdresaciDW] DROP CONSTRAINT [FK_WiadomośćAdresatDW];
GO
IF OBJECT_ID(N'[dbo].[FK_AdresatDWKontakt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdresaciDW] DROP CONSTRAINT [FK_AdresatDWKontakt];
GO
IF OBJECT_ID(N'[dbo].[FK_WiadomośćAdresatDW1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdresaciDW] DROP CONSTRAINT [FK_WiadomośćAdresatDW1];
GO
IF OBJECT_ID(N'[dbo].[FK_ZadanieRowPodmiot]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zadania] DROP CONSTRAINT [FK_ZadanieRowPodmiot];
GO
IF OBJECT_ID(N'[dbo].[FK_ZałącznikWiadomość]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Załączniki] DROP CONSTRAINT [FK_ZałącznikWiadomość];
GO
IF OBJECT_ID(N'[dbo].[FK_PodmiotAdres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Adresy] DROP CONSTRAINT [FK_PodmiotAdres];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Podmioty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Podmioty];
GO
IF OBJECT_ID(N'[dbo].[Kontakty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kontakty];
GO
IF OBJECT_ID(N'[dbo].[Adresy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Adresy];
GO
IF OBJECT_ID(N'[dbo].[Wiadomości]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Wiadomości];
GO
IF OBJECT_ID(N'[dbo].[AdresaciDW]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdresaciDW];
GO
IF OBJECT_ID(N'[dbo].[Zadania]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zadania];
GO
IF OBJECT_ID(N'[dbo].[Załączniki]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Załączniki];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Podmioty'
CREATE TABLE [dbo].[Podmioty] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nazwa] nvarchar(max)  NOT NULL,
    [Obrazek] varbinary(max)  NULL
);
GO

-- Creating table 'Kontakty'
CREATE TABLE [dbo].[Kontakty] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Wartość] nvarchar(max)  NOT NULL,
    [PodmiotId] int  NOT NULL,
    [Nazwa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Adresy'
CREATE TABLE [dbo].[Adresy] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Typ] int  NOT NULL,
    [Miasto] nvarchar(max)  NOT NULL,
    [Ulica] nvarchar(max)  NULL,
    [KodPocztowy] nvarchar(max)  NULL,
    [NrDomu] nvarchar(max)  NULL,
    [Wojewodztwo] int  NULL,
    [Kraj] nvarchar(max)  NULL,
    [NrLokalu] nvarchar(max)  NULL,
    [PodmiotId1] int  NOT NULL
);
GO

-- Creating table 'Wiadomości'
CREATE TABLE [dbo].[Wiadomości] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Temat] nvarchar(max)  NOT NULL,
    [Treść] nvarchar(max)  NOT NULL,
    [Adresat_Id] int  NOT NULL
);
GO

-- Creating table 'AdresaciDW'
CREATE TABLE [dbo].[AdresaciDW] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WiadomośćId] int  NOT NULL,
    [Kontakt_Id] int  NOT NULL
);
GO

-- Creating table 'Zadania'
CREATE TABLE [dbo].[Zadania] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nazwa] nvarchar(max)  NOT NULL,
    [Opis] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Przypomnienie] int  NOT NULL,
    [Wyprzedzenie] int  NOT NULL,
    [Godzina] time  NOT NULL,
    [IsNotificate] bit  NOT NULL,
    [Podmiot_Id] int  NOT NULL
);
GO

-- Creating table 'Załączniki'
CREATE TABLE [dbo].[Załączniki] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dane] varbinary(max)  NOT NULL,
    [Nazwa] nvarchar(max)  NOT NULL,
    [Wiadomość_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Podmioty'
ALTER TABLE [dbo].[Podmioty]
ADD CONSTRAINT [PK_Podmioty]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Kontakty'
ALTER TABLE [dbo].[Kontakty]
ADD CONSTRAINT [PK_Kontakty]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [Typ] in table 'Adresy'
ALTER TABLE [dbo].[Adresy]
ADD CONSTRAINT [PK_Adresy]
    PRIMARY KEY CLUSTERED ([Id], [Typ] ASC);
GO

-- Creating primary key on [Id] in table 'Wiadomości'
ALTER TABLE [dbo].[Wiadomości]
ADD CONSTRAINT [PK_Wiadomości]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdresaciDW'
ALTER TABLE [dbo].[AdresaciDW]
ADD CONSTRAINT [PK_AdresaciDW]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Zadania'
ALTER TABLE [dbo].[Zadania]
ADD CONSTRAINT [PK_Zadania]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Załączniki'
ALTER TABLE [dbo].[Załączniki]
ADD CONSTRAINT [PK_Załączniki]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PodmiotId] in table 'Kontakty'
ALTER TABLE [dbo].[Kontakty]
ADD CONSTRAINT [FK_PodmiotKontakt]
    FOREIGN KEY ([PodmiotId])
    REFERENCES [dbo].[Podmioty]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PodmiotKontakt'
CREATE INDEX [IX_FK_PodmiotKontakt]
ON [dbo].[Kontakty]
    ([PodmiotId]);
GO

-- Creating foreign key on [Adresat_Id] in table 'Wiadomości'
ALTER TABLE [dbo].[Wiadomości]
ADD CONSTRAINT [FK_WiadomośćKontakt]
    FOREIGN KEY ([Adresat_Id])
    REFERENCES [dbo].[Kontakty]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WiadomośćKontakt'
CREATE INDEX [IX_FK_WiadomośćKontakt]
ON [dbo].[Wiadomości]
    ([Adresat_Id]);
GO

-- Creating foreign key on [WiadomośćId] in table 'AdresaciDW'
ALTER TABLE [dbo].[AdresaciDW]
ADD CONSTRAINT [FK_WiadomośćAdresatDW]
    FOREIGN KEY ([WiadomośćId])
    REFERENCES [dbo].[Wiadomości]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WiadomośćAdresatDW'
CREATE INDEX [IX_FK_WiadomośćAdresatDW]
ON [dbo].[AdresaciDW]
    ([WiadomośćId]);
GO

-- Creating foreign key on [Kontakt_Id] in table 'AdresaciDW'
ALTER TABLE [dbo].[AdresaciDW]
ADD CONSTRAINT [FK_AdresatDWKontakt]
    FOREIGN KEY ([Kontakt_Id])
    REFERENCES [dbo].[Kontakty]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdresatDWKontakt'
CREATE INDEX [IX_FK_AdresatDWKontakt]
ON [dbo].[AdresaciDW]
    ([Kontakt_Id]);
GO

-- Creating foreign key on [WiadomośćId] in table 'AdresaciDW'
ALTER TABLE [dbo].[AdresaciDW]
ADD CONSTRAINT [FK_WiadomośćAdresatDW1]
    FOREIGN KEY ([WiadomośćId])
    REFERENCES [dbo].[Wiadomości]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WiadomośćAdresatDW1'
CREATE INDEX [IX_FK_WiadomośćAdresatDW1]
ON [dbo].[AdresaciDW]
    ([WiadomośćId]);
GO

-- Creating foreign key on [Podmiot_Id] in table 'Zadania'
ALTER TABLE [dbo].[Zadania]
ADD CONSTRAINT [FK_ZadanieRowPodmiot]
    FOREIGN KEY ([Podmiot_Id])
    REFERENCES [dbo].[Podmioty]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZadanieRowPodmiot'
CREATE INDEX [IX_FK_ZadanieRowPodmiot]
ON [dbo].[Zadania]
    ([Podmiot_Id]);
GO

-- Creating foreign key on [Wiadomość_Id] in table 'Załączniki'
ALTER TABLE [dbo].[Załączniki]
ADD CONSTRAINT [FK_ZałącznikWiadomość]
    FOREIGN KEY ([Wiadomość_Id])
    REFERENCES [dbo].[Wiadomości]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZałącznikWiadomość'
CREATE INDEX [IX_FK_ZałącznikWiadomość]
ON [dbo].[Załączniki]
    ([Wiadomość_Id]);
GO

-- Creating foreign key on [PodmiotId1] in table 'Adresy'
ALTER TABLE [dbo].[Adresy]
ADD CONSTRAINT [FK_PodmiotAdres]
    FOREIGN KEY ([PodmiotId1])
    REFERENCES [dbo].[Podmioty]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PodmiotAdres'
CREATE INDEX [IX_FK_PodmiotAdres]
ON [dbo].[Adresy]
    ([PodmiotId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------