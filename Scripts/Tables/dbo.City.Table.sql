USE [COINKDB]
GO
/****** Object:  Table [dbo].[City]    Script Date: 17/05/2021 05:47:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[IdCity] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[IdDepartment] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[IdCity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Department] FOREIGN KEY([IdDepartment])
REFERENCES [dbo].[Department] ([IdDepartment])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Department]
GO
