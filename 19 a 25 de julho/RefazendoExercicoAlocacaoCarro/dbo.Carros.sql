CREATE TABLE [dbo].[Carros] (
    [IdCarro] INT           IDENTITY (1, 1) NOT NULL,
    [Modelo]  VARCHAR (100) NOT NULL,
    [Ativo]   BIT           NOT NULL,
    [UsuInc]  INT           NOT NULL,
    [UsuAlt]  INT           NOT NULL,
    [DataInc] DATETIME      NOT NULL,
    [DataAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCarro] ASC)
);

