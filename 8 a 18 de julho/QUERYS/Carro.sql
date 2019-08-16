SELECT ' CARROS' as 'CARROS',
SUM(Temp.Media) as' Vendas',
Temp.Ano
from (select 
Modelo,
Ano,
(SUM(NumVendas) /COUNT(*)) as 'Media',
year(DataVenda) as 'Total por Ano'
FROM Carro
Group BY Modelo, Ano, year(DataVenda)) Temp
group BY Temp.Ano



