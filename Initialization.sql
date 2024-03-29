USE [template_20052019]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleId] [int] IDENTITY(1,1) NOT NULL,
	[ArticleTitle] [nvarchar](1024) NULL,
	[Sapo] [nvarchar](max) NULL,
	[Avatar] [nvarchar](255) NULL,
	[Content] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[IsPolicy] [bit] NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[Phone] [varchar](15) NULL,
	[Message] [nvarchar](1024) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KeyValue]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeyValue](
	[Key] [varchar](512) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_KeyValue] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[CreatedDate] [datetime] NULL,
	[UserType] [tinyint] NULL,
	[Email] [varchar](1024) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilities]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilities](
	[UtilityId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [smallint] NULL,
	[Description] [nvarchar](1024) NULL,
 CONSTRAINT [PK_Utilities] PRIMARY KEY CLUSTERED 
(
	[UtilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Article_Delete]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Article_Delete] 
	@_ItemId INT = 0
AS
BEGIN
	IF(@_ItemId > 0)
	BEGIN
		DELETE FROM Articles WHERE ArticleId = @_ItemId
		SELECT 1;
	END
	ELSE
	BEGIN
		SELECT 0;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Article_Get]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Articl
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Article_Get]
	@_ItemId INT = 0,
	@_PageSize INT = 20,
	@_PageIndex INT = 1,
	@_IsPolicy BIT = 0
AS
BEGIN
	IF(@_ItemId > 0)
	BEGIN
		SELECT * FROM Articles WHERE ArticleId = @_ItemId
	END
	ELSE
	BEGIN
		DECLARE @_Start INT, @_End INT
		SET @_Start = @_PageSize * (@_PageIndex - 1) + 1;
		SET @_End = @_Start + @_PageSize - 1;

		WITH tbl AS
		(
			SELECT TOP(@_PageSize * @_PageIndex) *, ROW_NUMBER() OVER (ORDER BY ArticleId DESC) AS RowIndex 
			FROM Articles
			WHERE IsPolicy = @_IsPolicy
		)
		SELECT * FROM tbl WHERE RowIndex >= @_Start AND RowIndex <= @_End

		SELECT COUNT(ArticleId) AS TotalRecord FROM Articles
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Article_Save]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Article_Save]
	@_ArticleId INT = 0,
	@_ArticleTitle NVARCHAR(1024),
	@_Sapo NVARCHAR(2048),
	@_Avatar NVARCHAR(1024),
	@_Content NVARCHAR(MAX),
	@_IsPolicy BIT = 0
AS
BEGIN
	IF(@_ArticleId > 0)
	BEGIN
		UPDATE Articles
		SET ArticleTitle = @_ArticleTitle, Sapo=@_Sapo , Avatar = @_Avatar, Content = @_Content, IsPolicy = @_IsPolicy
		WHERE ArticleId = @_ArticleId
		SELECT 1;
	END
	ELSE
	BEGIN
		INSERT INTO Articles(ArticleTitle, Sapo, Avatar, Content, CreatedDate, IsPolicy)
		VALUES(@_ArticleTitle, @_Sapo, @_Avatar, @_Content, GETDATE(), @_IsPolicy)

		SELECT 1;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Contact_Get]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Articl
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Contact_Get]
	@_PageSize INT = 20,
	@_PageIndex INT = 1
AS
BEGIN
	DECLARE @_Start INT, @_End INT
	SET @_Start = @_PageSize * (@_PageIndex - 1) + 1;
	SET @_End = @_Start + @_PageSize - 1;

	WITH tbl AS
	(
		SELECT TOP(@_PageSize * @_PageIndex) *, ROW_NUMBER() OVER (ORDER BY ContactId DESC) AS RowIndex FROM Contacts
	)
	SELECT * FROM tbl WHERE RowIndex >= @_Start AND RowIndex <= @_End

	SELECT COUNT(ContactId) AS TotalRecord FROM Contacts
END
GO
/****** Object:  StoredProcedure [dbo].[Contact_Save]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Contact_Save]
	@_Name NVARCHAR(255),
	@_Email NVARCHAR(255),
	@_Phone VARCHAR(15),
	@_Message NVARCHAR(MAX) = ''
AS
BEGIN
	INSERT INTO Contacts(Name, Email, Phone, Message)
	VALUES(@_Name, @_Email, @_Phone, @_Message)

	SELECT 1;
END
GO
/****** Object:  StoredProcedure [dbo].[KeyValue_GetByKey]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[KeyValue_GetByKey]
	@_Key VARCHAR(512)
AS
BEGIN
	SELECT [Value] FROM KeyValue
	WHERE LOWER([Key]) = LOWER(@_Key)
END
GO
/****** Object:  StoredProcedure [dbo].[KeyValue_Save]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[KeyValue_Save]
	@_Key VARCHAR(512),
	@_Value NVARCHAR(MAX)
AS
BEGIN
	IF(@_Key IS NOT NULL AND @_Key <> '')
	BEGIN
		IF EXISTS (SELECT [Key] FROM KeyValue WHERE LOWER([Key]) = LOWER(@_Key))
		BEGIN
			UPDATE KeyValue
			SET Value = @_Value
			WHERE LOWER([Key]) = LOWER(@_Key)
		END
		ELSE
		BEGIN
			INSERT INTO KeyValue([Key], [Value])
			VALUES(@_Key, @_Value)
		END

		SELECT 1;
	END
	ELSE
	BEGIN
		SELECT 0;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[User_Create]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[User_Create]
	@_Username NVARCHAR(255),
	@_Email NVARCHAR(1014),
	@_Password VARCHAR(255),
	@_UserType TINYINT
AS
BEGIN
	IF NOT EXISTS (SELECT UserId FROM Users WHERE Username = @_Username OR Email = @_Email)
	BEGIN
		INSERT INTO Users(Username, Email, Password, UserType, CreatedDate)
		VALUES(@_Username, @_Email, @_Password, @_UserType, GETDATE())

		SELECT 1;
	END
	ELSE
	BEGIN
		SELECT 0;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[User_Get]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[User_Get]
	@_UsernameOrEmail VARCHAR(1024)
AS
BEGIN
	SELECT * FROM Users WHERE Username = @_UsernameOrEmail OR Email= @_UsernameOrEmail
END
GO
/****** Object:  StoredProcedure [dbo].[User_Validate]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[User_Validate]
	@_UsernameOrEmail VARCHAR(1024),
	@_Password VARCHAR(255)
AS
BEGIN
	DECLARE @_CheckPass VARCHAR(255)
	SELECT @_CheckPass = Password FROM Users WHERE LOWER(Username) = LOWER(@_UsernameOrEmail) OR Email= @_UsernameOrEmail;
	IF @_CheckPass IS NOT NULL
	BEGIN
		IF(@_Password = @_CheckPass)
		BEGIN
			SELECT * FROM Users WHERE Username = @_UsernameOrEmail OR Email= @_UsernameOrEmail
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Utilities_Delete]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Utilities_Delete]
	@_ItemId INT = 0
AS
BEGIN
	DELETE FROM Utilities
	WHERE UtilityId = @_ItemId
	SELECT 1;
END
GO
/****** Object:  StoredProcedure [dbo].[Utilities_Get]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Utilities_Get]
	@_PageSize INT = 20,
	@_PageIndex INT = 1,
	@_ItemId INT = 0
AS
BEGIN
	IF(@_ItemId IS NOT NULL AND @_ItemId > 0)
	BEGIN
		SELECT * FROM Utilities WHERE UtilityId = @_ItemId
	END
	ELSE
	BEGIN
		DECLARE @_Start INT, @_End INT
		SET @_Start = @_PageSize * (@_PageIndex - 1) + 1;
		SET @_End = @_Start + @_PageSize - 1;

		WITH tbl AS
		(
			SELECT TOP(@_PageSize * @_PageIndex) *, ROW_NUMBER() OVER (ORDER BY UtilityId DESC) AS RowIndex FROM Utilities
		)
		SELECT * FROM tbl WHERE RowIndex >= @_Start AND RowIndex <= @_End

		SELECT COUNT(UtilityId) AS TotalRecord FROM Utilities
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Utilities_Save]    Script Date: 09/06/2019 19:49:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Utilities_Save]
	@_ItemId INT = 0,
	@_Type SMALLINT,
	@_Description NVARCHAR(1024)
AS
BEGIN
	IF(@_ItemId IS NOT NULL AND @_ItemId > 0)
	BEGIN
		DECLARE @_TempId INT
		SELECT @_TempId = UtilityId FROM Utilities WHERE [Type] = @_Type

		IF @_TempId IS NOT NULL AND @_TempId > 0 AND @_TempId <> @_ItemId
		BEGIN
			SELECT 0;
		END
		ELSE
		BEGIN
			UPDATE Utilities
			SET [Type] = @_Type, [Description] = @_Description
			WHERE UtilityId = @_ItemId

			SELECT 1;
		END
	END
	ELSE
	BEGIN
		IF EXISTS (SELECT UtilityId FROM Utilities WHERE [Type] = @_Type)
		BEGIN
			SELECT 0;
		END
		ELSE
		BEGIN
			INSERT INTO Utilities([Type], [Description]) 
			VALUES(@_Type, @_Description)

			SELECT 1;
		END
	END
END
GO
