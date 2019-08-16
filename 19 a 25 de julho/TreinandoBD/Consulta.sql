CREATE TABLE [dbo].[Consulta]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [NomePC] INT NOT NULL, 
    [NomeMed] INT NOT NULL, 
    [Data] DATETIME NOT NULL default getdate(), 
    [Valor] INT NOT NULL, 
    CONSTRAINT [FK_Consulta_Paciente] FOREIGN KEY ([NomePC]) REFERENCES [Paciente]([Id]), 
	 CONSTRAINT [FK_Consulta_Medico] FOREIGN KEY ([NomeMed]) REFERENCES [Medico]([Id])

  
   
   
  

)
