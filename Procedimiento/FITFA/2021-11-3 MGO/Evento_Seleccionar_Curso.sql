USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[Evento_Seleccionar_Curso]    Script Date: 11/03/2021 16:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Evento_Seleccionar_Curso]	
as
Select * from evento where evento.evento_tipoevento='Curso'