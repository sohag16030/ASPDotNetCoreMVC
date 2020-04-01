USE [Library]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 3/13/2020 8:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[Author] [nvarchar](500) NULL,
	[PublicationDate] [datetime] NULL,
	[Edition] [nvarchar](150) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (1, N'ABC', N'XYZ', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'First')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (2, N'DEF', N'X2Y2Z2', CAST(N'1990-02-02T00:00:00.000' AS DateTime), N'Second')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (3, N'Title 2', N'Author 2', CAST(N'1911-02-02T00:00:00.000' AS DateTime), N'Third')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (4, N'Title 3', N'Author 3', CAST(N'1923-02-02T00:00:00.000' AS DateTime), N'One')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (5, N'Title 4', N'Author 4', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'One')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (6, N'Title 5', N'Author 5', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'Five')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (7, N'Title 6', N'Author 6', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'Two')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (8, N'Title 7', N'Author 4', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'One')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (9, N'Title 8', N'Author 2', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'Two')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (10, N'Title 9', N'Author3', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'One')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (11, N'Title 10', N'Author', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'One')
INSERT [dbo].[Books] ([Id], [Title], [Author], [PublicationDate], [Edition]) VALUES (12, N'Title 11', N'Author 55', CAST(N'1922-02-02T00:00:00.000' AS DateTime), N'One')
SET IDENTITY_INSERT [dbo].[Books] OFF
/****** Object:  StoredProcedure [dbo].[GetBooks]    Script Date: 3/13/2020 8:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetBooks]
@PageIndex int,
@PageSize int , 
@OrderBy nvarchar(50),
@SearchText nvarchar(250) = '%',
@Total int output,
@TotalDisplay int output

AS
BEGIN
	Declare @sql nvarchar(4000);
	Declare @countsql nvarchar(4000);
	Declare @paramList nvarchar(MAX); 
	Declare @countparamList nvarchar(MAX);
	
	SET NOCOUNT ON;

	Select @Total = count(*) from Books;
	SET @countsql = 'select @TotalDisplay = count(*) from Books where Title LIKE ''%'' + @SearchText + ''%'' or Author LIKE ''%'' + @SearchText + ''%''';

	SET @sql = 'select * from Books where Title LIKE ''%'' + @SearchText + ''%'' or Author LIKE ''%'' + @SearchText + ''%'' 
	Order by '+@OrderBy+' OFFSET @PageSize * (@PageIndex - 1) 
	ROWS FETCH NEXT @PageSize ROWS ONLY' 
	
	SELECT @countparamlist = '@SearchText nvarchar(250),
	@TotalDisplay int output' 

	exec sp_executesql @countsql , @countparamlist ,
		@SearchText , 
		@TotalDisplay = @TotalDisplay output

	SELECT @paramlist = '@SearchText nvarchar(250),
	@PageIndex int,
	@PageSize int' 

	exec sp_executesql @sql , @paramlist ,
		@SearchText , 
		@PageIndex,
		@PageSize
	
END
GO
