USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[Inscripcion_eliminar_alumno_torneo]    Script Date: 11/18/2021 01:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Inscripcion_eliminar_alumno_torneo]
@inscripcion_id int,
@categoria_id int

as
delete from inscripciones_x_torneo where inscripcion_id = @inscripcion_id and categoria_id = @categoria_id  

---y ademas voy a listar 
select * from inscripciones_x_torneo where inscripcion_id = @inscripcion_id  

