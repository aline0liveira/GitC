
--1 Trazer somente as marcas que Felipe cadastrou
Select Nome from Marcas where UsuInc = 1;

--Trazer somente as marcas que Giomar cadastrou
Select Nome from Marcas where UsuInc = 2;

--2Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
Select 
Count(*) as'Quantidade Marcas'
From Marcas where UsuInc = 1 
Order by 'Quantidade Marcas' desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
Select 
Count(*) as 'Quantidade Marcas'
From Marcas where UsuInc =2
Order by 'Quantidade Marcas' asc;


--3Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
Select Count(*) as 'Quantidade Marcas'
From Marcas where UsuInc= 1 or UsuInc=2;

--4Trazer somente os carros que Felipe cadastrou
Select Modelo from Carros where UsuInc = 1;

--Trazer somente os carros que Giomar cadastrou
Select Modelo from Carros where UsuInc = 2;

--5 Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
Select 
Count(*)as'Quantidade Carros'
From Carros where UsuInc = 1 
Order by 'Quantidade Carros' desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
Select 
Count(*) as'Quantidade Carros'
From Carros where UsuInc = 2
Order by 'Quantidade Carros' asc;

--6 Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
Select Count(*) as 'Quantidade Carros'
From Carros where UsuInc= 1 or UsuInc=2;


--7 Trazer somente os carros das marcas que Felipe cadastrou
Select
C.Modelo as'Marcas Felipe'
From Carros C 
 inner join  Marcas M on M.Id = C.Marca
 where M.UsuInc = 1;

 --Trazer somente os carros das marcas que Giomar cadastrou
 Select
C.Modelo as'Marcas Giomar'
From Carros C 
 inner join  Marcas M on M.Id = C.Marca
 where M.UsuInc = 2

 --8Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor

 Select
 Count(C.Modelo) as'Quantidade Carros Felipe'
From Carros C 
 inner join  Marcas M on M.Id = C.Marca
 where M.UsuInc = 1
Order by 'Quantidade Carros Felipe' desc;


--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
 Select
 Count(C.Modelo) as'Quantidade Carros Giomar'
From Carros C 
 inner join  Marcas M on M.Id = C.Marca
 where M.UsuInc = 2
Order by 'Quantidade Carros Giomar' asc;

-- 9Trazer o valor total de vendas 2019 isolado

Select 
		Sum(V.Quantidade * V.Valor) as 'Total vendas em 2019'
	From  Vendas V 
where year(V.DatInc) = 2019;

--Trazer a quantidade total de vendas 2019 isolado
Select 
		Sum(V.Quantidade) as 'Quantidade Total vendas em 2019'
	From  Vendas V 
where year(V.DatInc) = 2019;

--10 Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
Select 
	
	Sum(V.Quantidade * V.Valor) as 'Total Por ano ',
	YEAR(V.DatInc) as 'Ano'
	From  Vendas V 
	Group by YEAR(V.DatInc) 
	Order by  'Total Por ano 'desc;

	--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
	Select
	Sum(V.Quantidade) as 'Total Por Ano ',
	year(V.DatInc) as 'Ano'
	From  Vendas V 
	Group by year(V.DatInc) 
	Order by  'Total Por Ano 'desc;


--11Trazer o mês de cada ano que retornou a maior quantidade de vendas
Select
		Sum(V.Quantidade) as 'Total ',
		Month(V.DatInc) as 'Mês',
		year(V.DatInc) as 'Ano'
	From  Vendas V 
Group by Month (V.DatInc) ,year(V.DatInc) 
Order by  'Total 'desc;


--12Trazer o mês de cada ano que retornou o maior valor de vendas
Select
		Sum(V.Quantidade*Valor) as 'Total ',
		Month(V.DatInc) as 'Mês',
		year(V.DatInc) as 'Ano'
	From  Vendas V 
Group by Month (V.DatInc) ,year(V.DatInc) 
Order by  'Total 'desc;

--13 Trazer o valor total de vendas que Felipe realizou

 Select
Sum(V.Quantidade*Valor) as 'Total de Vendas'
From Vendas V
 where V.UsuInc = 1;

 --Trazer o valor total de vendas que Giomar realizou
  Select
Sum(V.Quantidade*Valor) as 'Total de Vendas'
From Vendas V
 where V.UsuInc = 2


 --14 Trazer a quantidade total de vendas que Felipe realizou
  Select
Sum(V.Quantidade) as 'Quantidade de Vendas'
From Vendas V
 where V.UsuInc = 1;


 --Trazer a quantidade de vendas que Giomar realizou
   Select
Sum(V.Quantidade) as 'Quantidade de Vendas'
From Vendas V
 where V.UsuInc = 2;

 --15 Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para meno
     Select
Sum(V.Quantidade * V.Valor) as 'Total de Vendas'
From Vendas V
 where V.UsuInc = 1 or V.UsuInc=2
 Order by 'Total de Vendas' desc;

 --16Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
    Select
Sum(V.Quantidade) as 'Quantidade de Vendas'
From Vendas V
 where V.UsuInc = 1 or V.UsuInc=2
 Order by 'Quantidade de Vendas' asc;

 --17 Trazer  a marca mais vendida de todos os anos
		-- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"

 Select 
		M.Nome,
		SUM(V.Quantidade) as 'Total',
		year(V.DatInc) as 'Ano'
	from Vendas V
INNER JOIN  Carros C ON C.Id = V.Carro
inner join  Marcas M ON C.Marca= M.Id
Group by year(V.DatInc), M.Nome
Order BY  'Total' desc;


--Trazer o valor total da marca mais vendida de todos os anos		

 Select 
		M.Nome,
		SUM(V.Quantidade*V.Valor) as 'Total',
		year(V.DatInc) as 'Ano'
	from Vendas V
INNER JOIN  Carros C ON C.Id = V.Carro
inner join  Marcas M ON C.Marca= M.Id
Group by  year(V.DatInc), M.Nome
Order BY  'Total' desc;

--18 Trazer a quantidade do carro mais vendido de todos os anos
 
  Select 
		C.Modelo,
		SUM(V.Quantidade) as 'Total',
		year(V.DatInc) as 'Ano'
	from Vendas V
INNER JOIN  Carros C ON C.Id = V.Carro
Group by year(V.DatInc), C.Modelo

--Trazer o valor do carro mais vendido de todos os anos
 Select 
		C.Modelo,
		SUM(V.Quantidade*V.Valor) as 'TOTAL',
		year(V.DatInc) as 'Ano'
	from Vendas V
INNER JOIN  Carros C ON C.Id = V.Carro
Group by  year(V.DatInc), C.Modelo


