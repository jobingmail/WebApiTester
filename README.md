# WebApiTester
this is httpclient (desktop app) software for CRUD operations on QuotesWebApi written in Dot.Net Core 3.1

https://webapi.website.in/api/[controller] ,here controller is 'quotes' 

add above line to RequestURI replace [controller] with webapi controller name




//===============sql script==============
CREATE TABLE [dbo].[Quotes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Quotes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

//===========================================
