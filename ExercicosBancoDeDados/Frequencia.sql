CREATE TABLE [dbo].[Frequencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Dias] DATE NOT NULL DEFAULT GETDATE(), 
    [Presenca] BIT NOT NULL,
    CONSTRAINT [FK_Frequencia_AlunosNomes] FOREIGN KEY ([Nome]) REFERENCES [Nome]([Id]), 

 

)
