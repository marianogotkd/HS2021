ALTER procedure [dbo].[Torneo_recuperar_inscriptos]
@evento_id int

as
select evento_id, evento_descripcion, CONVERT(varchar, evento_fecha, 103) as 'evento_fecha',
evento_direccion from evento where evento_id = @evento_id 

select * from inscripcion inner join inscripciones_x_torneo on inscripcion.inscripcion_id = inscripciones_x_torneo.inscripcion_id
inner join categoria on inscripciones_x_torneo.categoria_id = categoria.categoria_id 
 where evento_id = '105' order by categoria.categoria_tipo asc , categoria_gradinicial asc 
 
 select * from graduacion order by graduacion.graduacion_id asc 
 
 select * from inscripcion where inscripcion.evento_id = @evento_id 
go