select al.Aluno,
     IIF(((SUM(CONVERT(money,fr.Presenca)) / CONVERT(money,COUNT(fr.Presenca)) * 100) >=75), 'Aprovado','Reprovado') as 'Status Frequencia'
from alunos al
inner join Frequencia fr on al.Id = fr.IdAluno
group by al.Aluno

Select Alunos.Aluno,
(SUM((Nota1 + Nota2 + Nota3+ Nota4)/4)) as 'media',
IIF((SUM(Nota1+Nota2+Nota3+Nota4)/4) >=7, 'Aprovado', 'Reprovado') as ' Status'
from Notas
inner join Alunos on Alunos.Id = Notas.IdAluno
Group BY Aluno;


