USE [shoe_stores_test]
GO
/****** Object:  Table [dbo].[brands]    Script Date: 3/10/2016 2:58:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[brands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[brands_stores]    Script Date: 3/10/2016 2:58:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brands_stores](
	[iD] [int] IDENTITY(1,1) NOT NULL,
	[brand_id] [int] NULL,
	[store_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stores]    Script Date: 3/10/2016 2:58:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[brands_stores] ON 

INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (1, 10, 2)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (2, 15, 5)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (3, 16, 7)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (4, 16, 8)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (5, 20, 9)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (6, 21, 11)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (7, 21, 12)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (8, 26, 13)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (9, 27, 15)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (10, 27, 16)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (11, 32, 17)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (12, 33, 19)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (13, 33, 20)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (14, 38, 21)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (15, 39, 23)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (16, 39, 24)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (17, 46, 25)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (18, 47, 29)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (19, 47, 30)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (20, 54, 31)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (21, 55, 33)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (22, 55, 34)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (23, 62, 35)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (24, 63, 41)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (25, 63, 42)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (26, 70, 43)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (27, 71, 45)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (28, 71, 46)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (29, 78, 47)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (30, 79, 53)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (31, 79, 54)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (32, 86, 55)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (33, 87, 57)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (34, 87, 58)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (35, 94, 59)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (36, 95, 64)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (37, 95, 65)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (38, 102, 66)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (39, 103, 69)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (40, 104, 69)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (42, 107, 73)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (43, 107, 74)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (44, 114, 75)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (45, 115, 78)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (46, 116, 78)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (47, 117, 82)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (48, 119, 83)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (49, 119, 84)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (50, 126, 85)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (51, 127, 90)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (52, 128, 90)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (53, 129, 94)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (54, 131, 95)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (55, 131, 96)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (57, 139, 98)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (60, 142, 107)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (61, 144, 111)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (62, 145, 111)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (64, 147, 116)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (68, 157, 120)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (41, 105, 72)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (58, 140, 103)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (59, 141, 103)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (65, 149, 117)
INSERT [dbo].[brands_stores] ([iD], [brand_id], [store_id]) VALUES (66, 149, 118)
SET IDENTITY_INSERT [dbo].[brands_stores] OFF
