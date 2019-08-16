CREATE TABLE [dbo].[Locacoes] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [Usuario]     INT      NOT NULL,
    [Cliente]     INT      NOT NULL,
    [Modelo]      INT      NOT NULL,
    [DataAloc]    DATETIME NOT NULL,
    [TotalVendas] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Locacoes_Carro] FOREIGN KEY ([Modelo]) REFERENCES [dbo].[Carros] ([IdCarro]),
    CONSTRAINT [FK_Locacoes_Cliente] FOREIGN KEY ([Cliente]) REFERENCES [dbo].[Clientes] ([IdCliente])
);

