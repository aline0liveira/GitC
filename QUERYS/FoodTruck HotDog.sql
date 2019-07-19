SELECT 
Tipo,
(SUM(TotalVenda)) as 'Quantidade',
Month(DataVenda) as 'Mês'
FROM HotDog
Group BY Tipo, TotalVenda, Month(DataVenda)
order by TotalVenda desc
