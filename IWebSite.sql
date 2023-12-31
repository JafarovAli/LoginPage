USE [IWebSite]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 21 avq 2023 00:47:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[UserName] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Comment] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 21 avq 2023 00:47:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[UserName] [varchar](50) NOT NULL,
	[Messages] [varchar](50) NOT NULL,
	[ToUserName] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 21 avq 2023 00:47:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[UserName] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21 avq 2023 00:47:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [Name], [Surname], [Email]) VALUES (1, N'Ali', N'Cafarov', N'Admin@admin.com')
INSERT [dbo].[Users] ([id], [Name], [Surname], [Email]) VALUES (3, N'Shahriyar', N'Safarov', N'Sahriyar@gmail.com')
INSERT [dbo].[Users] ([id], [Name], [Surname], [Email]) VALUES (6, N'Nurlan', N'Aliyev', N'Nurlan@gmail.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  StoredProcedure [dbo].[spAddPerson]    Script Date: 21 avq 2023 00:47:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spAddPerson]
(
@Name varchar(50),
@Surname varchar(50),
@Email varchar(50)
)
AS
Insert into Users(Name,Surname,Email) Values (@Name,@Surname,@Email)
GO
