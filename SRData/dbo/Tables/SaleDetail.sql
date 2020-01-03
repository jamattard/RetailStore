CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[SaleId] INT NOT NULL,
	[ProductId] INT NOT NULL,
	[Quantity] INT NOT NULL DEFAULT 1,
	[PurchasePrice] Money NOT NULL,
	[Tax] Money NOT NULL DEFAULT 0,
	[CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
