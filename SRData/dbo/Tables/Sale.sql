CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CashierId] NVARCHAR(128) NOT NULL, 
	[SaleDate] DATETIME2 NOT NULL,
	[SubTotal] Money NOT NULL,
	[Tax] Money NOT NULL,
	[Total] Money NOT NULL,
	[CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate()

)
