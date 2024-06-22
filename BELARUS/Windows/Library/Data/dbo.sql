
CREATE TABLE [dbo].[Ayar] (
  [No] int  IDENTITY(1,1) NOT NULL,
  [SystemAd] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Deger] nvarchar(4000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Durum] bit DEFAULT ((0)) NULL,
  [Tarih] datetime DEFAULT (getdate()) NULL
)
GO

ALTER TABLE [dbo].[Ayar] SET (LOCK_ESCALATION = TABLE)
GO


CREATE TABLE [dbo].[Istatistik] (
  [No] int  IDENTITY(1,1) NOT NULL,
  [Tarih] datetime DEFAULT (getdate()) NULL,
  [Tip] smallint DEFAULT ((1)) NULL,
  [Adet] int DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[Istatistik] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'1 Tarif, 2 Uvh 3 Fiyat 4 Emanet',
'SCHEMA', N'dbo',
'TABLE', N'Istatistik',
'COLUMN', N'Tip'
GO


CREATE TABLE [dbo].[Recete] (
  [No] int  IDENTITY(1,1) NOT NULL,
  [EReceteNumara] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ProtokolNumara] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Turu] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TcKimlik] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [SahipAdSoyad] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [DoktorAdSoyad] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tarih] datetime DEFAULT (getdate()) NULL,
  [IlacTarihi] datetime DEFAULT (getdate()) NULL,
  [Durum] bit DEFAULT ((0)) NULL,
  [ReceteKatkiPayiElden] decimal(18,2)  NULL,
  [ReceteKatkiPayiMaastan] decimal(18,2)  NULL,
  [MuayeneKatkiPayiElden] decimal(18,2)  NULL,
  [MuayeneKatkiPayiMaastan] decimal(18,2)  NULL,
  [EzcaneIndirimTutari] decimal(18,2)  NULL,
  [EzcaneOdenmesiGerekenToplamTutar] decimal(18,2)  NULL,
  [IlKatkiPayiMaastan] decimal(18,2)  NULL,
  [FiyatFarki] decimal(18,2)  NULL,
  [KdvYuzdeSekiz] decimal(18,2)  NULL,
  [KdvYuzdeOnSekiz] decimal(18,2)  NULL,
  [ToplamTutar] decimal(18,2)  NULL,
  [OdenecekTutar] decimal(18,2)  NULL,
  [FiyatEtiketYazdirmaDurum] bit DEFAULT ((0)) NULL,
  [FiyatEtiketYazdirmaTarih] datetime DEFAULT (getdate()) NULL
)
GO

ALTER TABLE [dbo].[Recete] SET (LOCK_ESCALATION = TABLE)
GO



CREATE TABLE [dbo].[ReceteIlac] (
  [No] int  IDENTITY(1,1) NOT NULL,
  [ReceteNo] int DEFAULT ((-1)) NULL,
  [Barkod] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Adet] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Periyot] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Doz] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Ad] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tutar] decimal(18,2)  NULL,
  [Fark] decimal(18,2)  NULL,
  [Rapor] nvarchar(4000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [VerilecebilecegiTarih] datetime DEFAULT (getdate()) NULL,
  [Mesaj] nvarchar(4000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Durum] bit DEFAULT ((0)) NULL,
  [Tarih] datetime DEFAULT (getdate()) NULL,
  [EklenmeDurum] bit DEFAULT ((0)) NULL,
  [EklenmeZaman] datetime DEFAULT (getdate()) NULL,
  [EmanetDurum] bit DEFAULT ((0)) NULL,
  [EmanetZaman] datetime DEFAULT (getdate()) NULL,
  [UvhYazdirmaDurum] bit DEFAULT ((0)) NULL,
  [UvhYazdirmaZaman] datetime DEFAULT (getdate()) NULL,
  [TarifEtiketYazdirmaDurum] bit DEFAULT ((0)) NULL,
  [TarifEtiketYazdirmaZaman] datetime DEFAULT (getdate()) NULL,
  [TarifEtiketYazdirmaAdet] int DEFAULT ((0)) NULL,
  [UvhEtiketYazdirmaAdet] int DEFAULT ((0)) NULL,
  [EmanetEtiketYazdirmaAdet] int DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[ReceteIlac] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table Ayar
-- ----------------------------
ALTER TABLE [dbo].[Ayar] ADD CONSTRAINT [PK_Ayar] PRIMARY KEY CLUSTERED ([No])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Istatistik
-- ----------------------------
ALTER TABLE [dbo].[Istatistik] ADD CONSTRAINT [PK__Istatist__3214D4A87546784A] PRIMARY KEY CLUSTERED ([No])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Recete
-- ----------------------------
ALTER TABLE [dbo].[Recete] ADD CONSTRAINT [PK_Recete] PRIMARY KEY CLUSTERED ([No])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ReceteIlac
-- ----------------------------
ALTER TABLE [dbo].[ReceteIlac] ADD CONSTRAINT [PK_ReceteIlac] PRIMARY KEY CLUSTERED ([No])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

