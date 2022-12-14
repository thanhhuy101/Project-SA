USE [thanhhuy101_Gear]
GO
/****** Object:  Table [dbo].[Gear]    Script Date: 8/31/2022 3:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gear](
	[GearID] [int] IDENTITY(1,1) NOT NULL,
	[GearName] [varchar](50) NULL,
	[CategoryID] [int] NULL,
	[BrandID] [int] NULL,
	[GearPrice] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryGear]    Script Date: 8/31/2022 3:19:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryGear](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BrandGear]    Script Date: 8/31/2022 3:19:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandGear](
	[BrandGearID] [int] IDENTITY(1,1) NOT NULL,
	[BrandGearName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BrandGearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ListGear]    Script Date: 8/31/2022 3:19:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ListGear]
AS
SELECT dbo.BrandGear.BrandGearName, dbo.CategoryGear.CategoryName, dbo.Gear.GearPrice, dbo.Gear.GearName, dbo.Gear.GearID
FROM     dbo.BrandGear INNER JOIN
                  dbo.Gear ON dbo.BrandGear.BrandGearID = dbo.Gear.BrandID INNER JOIN
                  dbo.CategoryGear ON dbo.Gear.CategoryID = dbo.CategoryGear.CategoryID
GO
/****** Object:  View [dbo].[View_Gears]    Script Date: 8/31/2022 3:19:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Gears]
AS
SELECT        dbo.Gear.GearID, dbo.Gear.GearName, dbo.CategoryGear.CategoryName, dbo.BrandGear.BrandGearName, dbo.Gear.GearPrice
FROM            dbo.BrandGear INNER JOIN
                         dbo.Gear ON dbo.BrandGear.BrandGearID = dbo.Gear.BrandID INNER JOIN
                         dbo.CategoryGear ON dbo.Gear.CategoryID = dbo.CategoryGear.CategoryID
GO
SET IDENTITY_INSERT [dbo].[BrandGear] ON 

INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (1, N'Acer')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (2, N'Asus')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (3, N'Samsung')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (4, N'Apple')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (5, N'ROG')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (6, N'Corsair')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (7, N'Oddeseyy')
INSERT [dbo].[BrandGear] ([BrandGearID], [BrandGearName]) VALUES (1007, N'LG')
SET IDENTITY_INSERT [dbo].[BrandGear] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryGear] ON 

INSERT [dbo].[CategoryGear] ([CategoryID], [CategoryName]) VALUES (1, N'Chuot')
INSERT [dbo].[CategoryGear] ([CategoryID], [CategoryName]) VALUES (2, N'Ban phim')
INSERT [dbo].[CategoryGear] ([CategoryID], [CategoryName]) VALUES (3, N'Tai nghe')
INSERT [dbo].[CategoryGear] ([CategoryID], [CategoryName]) VALUES (4, N'Man hinh')
INSERT [dbo].[CategoryGear] ([CategoryID], [CategoryName]) VALUES (6, N'Thung may')
INSERT [dbo].[CategoryGear] ([CategoryID], [CategoryName]) VALUES (1007, N'o cung')
SET IDENTITY_INSERT [dbo].[CategoryGear] OFF
GO
SET IDENTITY_INSERT [dbo].[Gear] ON 

INSERT [dbo].[Gear] ([GearID], [GearName], [CategoryID], [BrandID], [GearPrice]) VALUES (1, N'Man hinh 200 inch', 4, 3, 825000)
INSERT [dbo].[Gear] ([GearID], [GearName], [CategoryID], [BrandID], [GearPrice]) VALUES (2, N'Chuot co chuot', 1, 4, 88888)
INSERT [dbo].[Gear] ([GearID], [GearName], [CategoryID], [BrandID], [GearPrice]) VALUES (3, N'Tai nghe sieu to', 3, 3, 11390000)
INSERT [dbo].[Gear] ([GearID], [GearName], [CategoryID], [BrandID], [GearPrice]) VALUES (4, N'Man hinh 69 inch', 4, 4, 44)
INSERT [dbo].[Gear] ([GearID], [GearName], [CategoryID], [BrandID], [GearPrice]) VALUES (7, N'Chuot kh chuot', 1, 4, 9999999)
INSERT [dbo].[Gear] ([GearID], [GearName], [CategoryID], [BrandID], [GearPrice]) VALUES (1008, N'ssd', 1007, 4, 69)
SET IDENTITY_INSERT [dbo].[Gear] OFF
GO
ALTER TABLE [dbo].[Gear]  WITH CHECK ADD  CONSTRAINT [FK_Gear_BrandGear] FOREIGN KEY([BrandID])
REFERENCES [dbo].[BrandGear] ([BrandGearID])
GO
ALTER TABLE [dbo].[Gear] CHECK CONSTRAINT [FK_Gear_BrandGear]
GO
ALTER TABLE [dbo].[Gear]  WITH CHECK ADD  CONSTRAINT [FK_Gear_CategoryGear] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CategoryGear] ([CategoryID])
GO
ALTER TABLE [dbo].[Gear] CHECK CONSTRAINT [FK_Gear_CategoryGear]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BrandGear"
            Begin Extent = 
               Top = 199
               Left = 1121
               Bottom = 328
               Right = 1297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CategoryGear"
            Begin Extent = 
               Top = 173
               Left = 380
               Bottom = 313
               Right = 550
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Gear"
            Begin Extent = 
               Top = 101
               Left = 752
               Bottom = 231
               Right = 922
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Gears'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Gears'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BrandGear"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 203
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CategoryGear"
            Begin Extent = 
               Top = 7
               Left = 301
               Bottom = 234
               Right = 496
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Gear"
            Begin Extent = 
               Top = 7
               Left = 544
               Bottom = 240
               Right = 738
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListGear'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListGear'
GO
