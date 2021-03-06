USE [COINKDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertUsers]    Script Date: 17/05/2021 05:47:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sebastian Martinez
-- Create date: 15/05/2021
-- Description:	Insert New users
-- =============================================
CREATE PROCEDURE [dbo].[InsertUsers]
		 @Name VARCHAR(200)
		 ,@LastName VARCHAR(200)
		 ,@Phone INT
		 ,@Address VARCHAR(200)
		 ,@IdCity INT
AS
BEGIN

	INSERT INTO [dbo].[Users]
			   ([Name]
			   ,[LastName]
			   ,[Phone]
			   ,[Address]
			   ,[CreateDate]
			   ,[IdCity]
			   ,[Active])
		 VALUES
			   (@Name
			   ,@LastName
			   ,@Phone
			   ,@Address
			   ,GETDATE()
			   ,@IdCity
			   ,1)

END
GO
