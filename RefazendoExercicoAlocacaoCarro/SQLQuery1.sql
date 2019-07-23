Select 
C.Modelo as 'Modelo',
(SUM(TotalVendas)/COUNT(*)) as 'Total de Vendas',
month(DataAloc) as 'Mês'

From Locacoes l

inner join Carros C ON C.IdCarro = l.Modelo

group by C.Modelo, l.TotalVendas, month(DataAloc)
Order by month(DataAloc) desc;

Select 
C.Modelo as 'Modelo',
(SUM(TotalVendas)/COUNT(*)) as 'Total de Vendas',
year(DataAloc) as 'Mês'

From Locacoes l

inner join Carros C ON C.IdCarro = l.Modelo

group by C.Modelo, l.TotalVendas, Year(DataAloc)
Order by year(DataAloc) desc


