USE [master]
GO
DROP DATABASE[User_Data]
GO
USE [master]
GO
CREATE DATABASE [User_Data]
GO
USE [User_Data]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 07.09.2023 22:25:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07.09.2023 22:25:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[First_Name] [nvarchar](50) NULL,
	[Second_Name] [nvarchar](50) NULL,
	[Pictures] [nvarchar](max) NULL,
	[Gender] [nvarchar](10) NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Roles] ([ID], [Name]) VALUES (1, N'Manager')
INSERT [dbo].[Roles] ([ID], [Name]) VALUES (2, N'Seller')
INSERT [dbo].[Roles] ([ID], [Name]) VALUES (3, N'Director')
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Login], [Password], [Phone], [Email], [First_Name], [Second_Name], [Pictures], [Gender], [RoleID]) VALUES (1, N'log1', N'pas1', NULL, NULL, N'Иван', N'Петров', N'1.png', NULL, 1)
INSERT [dbo].[Users] ([ID], [Login], [Password], [Phone], [Email], [First_Name], [Second_Name], [Pictures], [Gender], [RoleID]) VALUES (2, N'log2', N'pas2', NULL, NULL, N'Денис', N'Иванов', N'2.png', NULL, 2)
INSERT [dbo].[Users] ([ID], [Login], [Password], [Phone], [Email], [First_Name], [Second_Name], [Pictures], [Gender], [RoleID]) VALUES (3, N'log3', N'pas3', NULL, NULL, N'Светлана', N'Котова', N'3.png', NULL, 3)
INSERT [dbo].[Users] ([ID], [Login], [Password], [Phone], [Email], [First_Name], [Second_Name], [Pictures], [Gender], [RoleID]) VALUES (4, N'log4', N'pas4', NULL, NULL, N'Кирилл', N'Сидоров', N'4.png', NULL, 2)
INSERT [dbo].[Users] ([ID], [Login], [Password], [Phone], [Email], [First_Name], [Second_Name], [Pictures], [Gender], [RoleID]) VALUES (5, N'log5', N'pas5', NULL, NULL, N'Михаил ', N'Семёнов', N'5.png', NULL, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
