USE [COINKDB]
GO
/****** Object:  StoredProcedure [dbo].[GetUsers]    Script Date: 17/05/2021 05:47:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUsers]
		 @IdUser INT
AS
BEGIN

	SELECT 
		U.IdUser
		,U.Name
		,U.LastName
		,U.Phone
		,U.Address
		,CT.Name NameCity
		,D.Name NameDepartment
		,C.Name NameCountry
	FROM Users U
	INNER JOIN City CT ON U.IdCity = CT.IdCity
	INNER JOIN Department D ON CT.IdDepartment = D.IdDepartment
	INNER JOIN Country C ON C.IdCountry = C.IdCountry
	WHERE 
		U.Active = 1 
		AND (@IdUser = 0 OR U.IdUser = @IdUser)
	;

END
GO
