USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[alumuno_x_instructor_Actulizar]    Script Date: 10/19/2021 02:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[alumuno_x_instructor_Actulizar]
@instructor_id int,
@usuario_id INT
as
update alumnos_x_instructor set instructor_id=@instructor_id where usuario_id=@usuario_id