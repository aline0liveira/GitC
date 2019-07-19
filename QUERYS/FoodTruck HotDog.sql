SELECT

Id,
Tipo,
(SUM(TotalVenda)) as 'Quantidade',
Month(DataVenda) as 'Mês'
FROM HotDog
where Id between 1 and 3
Group BY Id,Tipo, TotalVenda, Month(DataVenda)
order by TotalVenda desc
