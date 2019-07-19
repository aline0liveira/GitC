select 
Aluno, Idade, IIF(Ativo =1, 'Ativo', 'Inativo')  as 'Status'
from AulaCsharp
where Id IN (SELECT Id FROM AulaCsharp WHERE Idade > 30)
ORDER BY Idade asc