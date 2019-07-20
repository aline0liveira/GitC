Select 
NomePC,
Nome,
Sum(Valor) AS 'Valor Consulta'
From Consulta, Paciente
Group by NomePC, Nome, Valor;

