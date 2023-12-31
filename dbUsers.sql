USE [dbUsers]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21 avq 2023 00:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirhtDate] [date] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [decimal](18, 0) NULL,
	[Role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Email] ASC,
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [BirhtDate], [Username], [Password], [Email], [Phone], [Role]) VALUES (1, N'Ali', N'Jafarov', CAST(N'1965-12-04' AS Date), N'Ali', N'ali123', N'Ali@admin.com', CAST(554123262 AS Decimal(18, 0)), N'Admin')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [BirhtDate], [Username], [Password], [Email], [Phone], [Role]) VALUES (2, N'Nurlan', N'Qafarov', CAST(N'1999-12-14' AS Date), N'Nurlan', N'nurlan123', N'nurlan@nurlan.com', CAST(778546213 AS Decimal(18, 0)), N'User')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [BirhtDate], [Username], [Password], [Email], [Phone], [Role]) VALUES (3, N'Shahriyar', N'Safarov', CAST(N'1995-01-24' AS Date), N'Shahriyar', N'sahriyar123', N'Shahriyar@Admin.com', CAST(778546213 AS Decimal(18, 0)), N'Admin')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [BirhtDate], [Username], [Password], [Email], [Phone], [Role]) VALUES (4, N'Alim', N'Qasimov', CAST(N'2000-12-12' AS Date), N'Alim', N'alim123', N'Alim@user.com', CAST(514263958 AS Decimal(18, 0)), N'User')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [BirhtDate], [Username], [Password], [Email], [Phone], [Role]) VALUES (5, N'Nurlan', N'Aliyev', CAST(N'2004-04-05' AS Date), N'Nurlan', N'nurlan123', N'nurlan@nurlan.com', CAST(704561236 AS Decimal(18, 0)), N'User')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  StoredProcedure [dbo].[spRegisterUser]    Script Date: 21 avq 2023 00:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[spRegisterUser]
(
@FirstName varchar(50),
@LastName varchar(50),
@BirhtDate date,
@Username varchar(50),
@Password varchar(50),
@Email varchar(50),
@Phone decimal (18,0),
@Role varchar(50)
)
AS
Insert into Users (FirstName,LastName,BirhtDate,Username,Password,Email,Phone,Role) Values (@FirstName,@LastName,@BirhtDate,@Username,@Password,@Email,@Phone,@Role)
GO
