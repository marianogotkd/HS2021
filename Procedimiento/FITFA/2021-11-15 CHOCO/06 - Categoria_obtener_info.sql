create procedure Categoria_obtener_info

@categoria_id int
as
select
		categoria_id, 
		categoria_sexo, 
		categoria_gradinicial, 
		categoria_gradfinal, 
		categoria_edadinicial, 
		categoria_edadfinal, 
		categoria_peso_inical, 
		categoria_peso_Final, 
		categoria_tipo
from categoria where categoria.categoria_id = @categoria_id 

go