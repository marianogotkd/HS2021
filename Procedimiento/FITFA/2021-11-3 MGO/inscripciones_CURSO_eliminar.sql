USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[inscripciones_x_examen_eliminar]    Script Date: 11/03/2021 16:25:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[inscripciones_CURSO_eliminar]
@inscripcion_id int

as


delete from inscripcion where inscripcion.inscripcion_id = @inscripcion_id 


