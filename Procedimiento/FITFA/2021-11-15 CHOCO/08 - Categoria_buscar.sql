create procedure Categoria_buscar
@categoria_sexo varchar(50),
@categoria_tipo varchar(50),
@categoria_gradinicial varchar(50),
@categoria_gradfinal varchar(50),
@categoria_edadinicial varchar(50),
@categoria_edadfinal varchar(50),
@categoria_peso_inicial varchar(50),
@categoria_peso_Final varchar(50)
as
select * from categoria where categoria_sexo = @categoria_sexo and categoria_tipo = @categoria_tipo 
		and categoria_gradinicial = @categoria_gradinicial and categoria_gradfinal = @categoria_gradfinal 
		and categoria_edadinicial = @categoria_edadinicial and categoria_edadfinal = @categoria_edadfinal
		and categoria_peso_inical = @categoria_peso_inicial and categoria_peso_Final = @categoria_peso_Final      
go