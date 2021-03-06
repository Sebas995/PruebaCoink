USE [COINKDB]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17/05/2021 05:47:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NULL,
	[LastName] [varchar](200) NULL,
	[Address] [varchar](200) NULL,
	[Phone] [int] NULL,
	[IdCity] [int] NULL,
	[CreateDate] [date] NULL,
	[ModificationDate] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_City] FOREIGN KEY([IdCity])
REFERENCES [dbo].[City] ([IdCity])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_City]
GO
