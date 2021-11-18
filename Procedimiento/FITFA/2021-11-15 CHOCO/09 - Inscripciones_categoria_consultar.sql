alter procedure Inscripciones_categoria_consultar
---consulto la cant de inscriptos en una categoria determinada, de un evento puntual
@evento_id int,
@categoria_id int
as
select * from inscripciones_x_torneo inner join inscripcion on inscripciones_x_torneo.inscripcion_id = inscripcion.inscripcion_id 
where evento_id = @evento_id and categoria_id = @categoria_id  

go