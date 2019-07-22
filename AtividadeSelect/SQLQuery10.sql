select
Carro,
SUM(QuantidadeLocacao) as 'Total',
MONTH([Data]) as 'Mês'
From Locacoes

Group by Carro, MONTH([Data])

Order by Total asc



select
Carro,
SUM(QuantidadeLocacao) as 'Total',
year([Data]) as 'Ano'
From Locacoes

Group by Carro, year([Data])

Order by Total asc


