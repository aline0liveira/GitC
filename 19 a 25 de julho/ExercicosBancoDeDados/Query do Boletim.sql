select al.Aluno,
SUM(Notas.Nota1+ Nota2+Nota3+Nota4) /Count (fr.Presenca) as 'Media',
IIF((SUM(Notas.Nota1+ Nota2+Nota3+Nota4)/COUNT(fr.Presenca) >= 7), 'Aprovado', 'Reprovado') as 'Status Media',
     IIF(((SUM(CONVERT(money,fr.Presenca)) / CONVERT(money,COUNT(fr.Presenca)) * 100) >=75), 'Aprovado','Reprovado') as 'Status Frequencia'
from alunos al
inner join Frequencia fr on al.Id = fr.IdAluno
inner join Notas on al.Id = Notas.IdAluno
group by al.Aluno