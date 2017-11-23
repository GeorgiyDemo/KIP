USE [DfLessonDb]
GO

/****** Object:  Table [dbo].[BlogUser]    Script Date: 23.11.2017 13:58:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BlogUser](
	[UserLogin] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[RegistrationDate] [datetime] NOT NULL
)
GO

ALTER TABLE BlogUser
ADD UserID int IDENTITY (1,1)
GO
 

ALTER TABLE [dbo].[BlogUser] ADD CONSTRAINT PK_BlogUser_UserID PRIMARY KEY CLUSTERED (UserID)
GO  

ALTER TABLE [dbo].[BlogUser]
ADD CONSTRAINT OF_BlogUser_Email_UNIQUE UNIQUE (Email)
GO

ALTER TABLE [dbo].[BlogUser]
ADD CONSTRAINT OF_BlogUser_UserLogin_UNIQUE UNIQUE (UserLogin)
GO

ALTER TABLE [dbo].[BlogUser]
ADD CONSTRAINT OF_BlogUser_RegistrationDate DEFAULT (getdate()) FOR [RegistrationDate] 
GO

Create Table Blog (
	BlogId int IDENTITY (1,1),
	Name nvarchar (50) NOT NULL,
	[Description] nvarchar (250) NULL,
	CreateDate datetime NOT NULL
)

ALTER TABLE Blog
	ADD CONSTRAINT PK_Blog_BlogId PRIMARY KEY CLUSTERED (BlogId)
GO

ALTER TABLE Blog
	ADD CONSTRAINT DF_BLOG_CreateDate_Default Default (getdate()) FOR CreateDate
GO

ALTER TABLE Blog
ADD UserId int NOT NULL
GO
