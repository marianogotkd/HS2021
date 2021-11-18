USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[Inscripcion_modificar]    Script Date: 11/18/2021 01:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Inscripcion_modificar]
@inscripcion_id int,
@inscripcion_peso decimal(5,2),
@categoria_id_vieja int,
@categoria_id_nueva int
as
update inscripcion set inscripcion_peso = @inscripcion_peso where inscripcion.inscripcion_id = @inscripcion_id 
update inscripciones_x_torneo set categoria_id = @categoria_id_nueva  where inscripcion_id = @inscripcion_id and categoria_id = @categoria_id_vieja  
go