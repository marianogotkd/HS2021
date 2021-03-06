USE [fitfaBD]
GO
/****** Object:  StoredProcedure [dbo].[Datos_Personales_Obtener_Datos_Usuarios]    Script Date: 10/19/2021 02:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Datos_Personales_Obtener_Datos_Usuarios]
@Us_id as int
as
set dateformat dmy

SELECT     dbo.usuario.usuario_nombre, dbo.usuario.usuario_apellido, Convert(varchar(10),dbo.usuario.usuario_fechanac,103) as fechaNac, dbo.usuario.usuario_nacionalidad, dbo.usuario.usuario_sexo, dbo.estado_civil.estadocivil_id, 
                      dbo.ciudad.ciudad_desc, dbo.provincia.provincia_desc, dbo.usuario.usuario_domicilio, dbo.usuario.usuario_profesion, dbo.usuario.usuario_codigopostal, dbo.usuario.usuario_telefono, 
                      dbo.usuario.usuario_mail, dbo.usuario.usuario_tipo, dbo.usuario.usuario_id, dbo.usuario.provincia_id, dbo.usuario.ciudad_id, usuario.usuario_foto,
                      dbo.usuario.graduacion_id , usuario.usuario_doc,
                      dbo.usuario.usuario_nrolibreta
FROM         dbo.usuario INNER JOIN
                      dbo.estado_civil ON dbo.usuario.estadocivil_id = dbo.estado_civil.estadocivil_id INNER JOIN
                      dbo.provincia ON dbo.usuario.provincia_id = dbo.provincia.provincia_id INNER JOIN
                      dbo.ciudad ON dbo.usuario.ciudad_id = dbo.ciudad.ciudad_id
                      
where
			usuario_id=@Us_id
			
select usuario_usuario from usuario where usuario_id=@Us_id

select instructor_id, usuario_id  from instructor where usuario_id = @Us_id ---esto lo uso para validar el master -choco:18-07-2019 

select instructor_id  from alumnos_x_instructor where usuario_id = @Us_id