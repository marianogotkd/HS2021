USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[Curso_recuperar_inscriptos]    Script Date: 11/03/2021 16:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Curso_recuperar_inscriptos]
@evento_id int

as
select * from(SELECT dbo.evento.evento_id, dbo.inscripcion.inscripcion_id, dbo.inscripcion.usuario_id, dbo.usuario.graduacion_id, dbo.evento.evento_descripcion, dbo.evento.evento_fecha, dbo.evento.evento_costo, dbo.evento.evento_direccion, 
                     usuario.usuario_apellido+', '+usuario.usuario_nombre as 'Alumno', dbo.graduacion.graduacion_desc, usuario.usuario_doc

FROM         dbo.evento INNER JOIN
                      dbo.inscripcion ON dbo.evento.evento_id = dbo.inscripcion.evento_id INNER JOIN
                      dbo.usuario ON dbo.inscripcion.usuario_id = dbo.usuario.usuario_id INNER JOIN
                      dbo.graduacion ON dbo.usuario.graduacion_id = dbo.graduacion.graduacion_id 
                      
                      where evento.evento_id=@evento_id) T1 
full outer join 
(select inscripcion_id, instructor.instructor_id, usuario.usuario_apellido+', '+usuario.usuario_nombre as 'instructor' 
	from inscripcion inner join instructor on inscripcion.inscripcion_instructor_id = instructor.instructor_id inner join usuario 
		on instructor.usuario_id = usuario.usuario_id where inscripcion.evento_id = @evento_id) T2 ON T1.inscripcion_id = T2.inscripcion_id
ORDER BY 1,2
