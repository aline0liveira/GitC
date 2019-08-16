SELECT 
Nome,
Materia,
(SUM(Nota) /COUNT(*)) as 'Media',
count(Nota) as 'Provas'
FROM NotaAlunos

Group BY Nome, Materia
order by Nome asc