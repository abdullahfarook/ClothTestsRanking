/*
 Navicat Premium Data Transfer

 Source Server         : Kohsaar
 Source Server Type    : SQL Server
 Source Server Version : 13004001
 Source Host           : (localdb)\MSSQLLocalDB:1433
 Source Catalog        : KohsaarDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 13004001
 File Encoding         : 65001

 Date: 05/02/2018 02:12:03
*/


-- ----------------------------
-- Table structure for Range
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Range]') AND type IN ('U'))
	DROP TABLE [dbo].[Range]
GO

CREATE TABLE [dbo].[Range] (
  [Id] int  NOT NULL,
  [TensileHWarp] float(53)  NULL,
  [TensileLWarp] float(53)  NULL,
  [TearHWeft] float(53)  NULL,
  [TearLWeft] float(53)  NULL,
  [TearHWarp] float(53)  NULL,
  [TearLWarp] float(53)  NULL,
  [TensileHWeft] float(53)  NULL,
  [TensileLWeft] float(53)  NULL,
  [AbrationH] float(53)  NULL,
  [AbrationL] float(53)  NULL,
  [WashingFastH] float(53)  NULL,
  [WashingFastL] float(53)  NULL
)
GO

ALTER TABLE [dbo].[Range] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Range]
-- ----------------------------
INSERT INTO [dbo].[Range]  VALUES (N'1', N'478.879999999999995', N'256.600000000000023', N'34.750000000000000', N'8.750000000000000', N'37.799999999999997', N'13.600000000000000', N'1199.000000000000000', N'342.600000000000023', N'34000.000000000000000', N'6000.000000000000000', N'4.000000000000000', N'3.500000000000000')
GO


-- ----------------------------
-- Table structure for Sample
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sample]') AND type IN ('U'))
	DROP TABLE [dbo].[Sample]
GO

CREATE TABLE [dbo].[Sample] (
  [Id] int  NOT NULL,
  [Name] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TensileWarp] float(53)  NULL,
  [TearWarp] float(53)  NULL,
  [Abration] int  NULL,
  [WashingFastness] float(53)  NULL,
  [TextileId] int  NULL,
  [TensileWeft] float(53)  NULL,
  [TearWeft] float(53)  NULL,
  [Value] float(53)  NULL
)
GO

ALTER TABLE [dbo].[Sample] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Sample]
-- ----------------------------
INSERT INTO [dbo].[Sample]  VALUES (N'1', N'Single Golo', N'396.699999999999989', N'34.899999999999999', N'24000', N'4.000000000000000', N'1', N'375.819999999999993', N'18.899999999999999', N'9.000000000000000')
GO

INSERT INTO [dbo].[Sample]  VALUES (N'2', N'Laraunce', N'370.665000000000020', N'24.750000000000000', N'19000', N'3.500000000000000', N'1', N'384.845000000000027', N'23.250000000000000', N'10.000000000000000')
GO

INSERT INTO [dbo].[Sample]  VALUES (N'3', N'Cone Die', N'478.449999999999989', N'25.250000000000000', N'28000', N'4.000000000000000', N'1', N'347.750000000000000', N'19.454000000000001', N'5.000000000000000')
GO

INSERT INTO [dbo].[Sample]  VALUES (N'4', N'Double Goli', N'470.000000000000000', N'37.799999999999997', N'20000', N'4.000000000000000', N'1', N'340.000000000000000', N'34.750000000000000', N'7.000000000000000')
GO

INSERT INTO [dbo].[Sample]  VALUES (N'5', N'Machine But Hand', N'470.000000000000000', N'13.600000000000000', N'26000', N'3.500000000000000', N'1', N'470.000000000000000', N'8.750000000000000', N'1.000000000000000')
GO

INSERT INTO [dbo].[Sample]  VALUES (N'6', N'Karandi', N'478.800000000000011', N'15.000000000000000', N'34000', N'3.500000000000000', N'1', N'342.600000000000023', N'10.600000000000000', N'3.000000000000000')
GO

INSERT INTO [dbo].[Sample]  VALUES (N'7', N'Hand Made', N'256.600000000000023', N'19.960000000000001', N'6000', N'4.000000000000000', N'1', N'1199.099999999999909', N'15.000000000000000', N'5.000000000000000')
GO


-- ----------------------------
-- Table structure for Textile
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Textile]') AND type IN ('U'))
	DROP TABLE [dbo].[Textile]
GO

CREATE TABLE [dbo].[Textile] (
  [Id] int  NOT NULL,
  [Name] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Textile] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Textile]
-- ----------------------------
INSERT INTO [dbo].[Textile]  VALUES (N'1', N'Khadder')
GO


-- ----------------------------
-- Primary Key structure for table Range
-- ----------------------------
ALTER TABLE [dbo].[Range] ADD CONSTRAINT [PK__Range__3214EC075512DE2D] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Sample
-- ----------------------------
ALTER TABLE [dbo].[Sample] ADD CONSTRAINT [PK__Sample__3214EC0707B33843] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Textile
-- ----------------------------
ALTER TABLE [dbo].[Textile] ADD CONSTRAINT [PK__Textile__3214EC07BAB35451] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Sample
-- ----------------------------
ALTER TABLE [dbo].[Sample] ADD CONSTRAINT [FK_TEXTILE] FOREIGN KEY ([TextileId]) REFERENCES [Textile] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

