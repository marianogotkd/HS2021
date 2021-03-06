USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Mantenimiento_realizado_buscar_todos]    Script Date: 11/09/2021 16:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Mantenimiento_realizado_buscar_todos]
@SucxClie_id int
as
---0) este select solo me va a traer los mantenimientos que ya se realizaron. no los que esten pendientes
select
Mantenimiento.Mantenimiento_id,
Mantenimiento_realizado.Mant_realizados_id,
Equipo.Equipo_id, 
Equipo.Equipo_descripcion as 'Equipo',
Cliente_suc_sector.Cliente_suc_sector_descripcion as 'Sector',
CONVERT(varchar, Cliente_Sucursales.CLI_id)+'-'+CONVERT(varchar, Cliente_suc_sector.SucxClie_id)+'-'+CONVERT(varchar, Equipo.Equipo_idcat)+'-'+Cliente_suc_sector.Cliente_suc_sector_denominacion+'-'+Equipo.Equipo_denominacion  as 'Etiqueta',
Mantenimiento_tipo.Mant_tipo_descr as 'Tipo_mantenimiento',
'en bd' as 'estado',
Mantenimiento_periodicidad.Mant_periodicidad_desc +' ('+CONVERT(varchar(max), Mantenimiento_periodicidad.Mant_periodicidad_dias )+')' as 'periodicidad',     
Mantenimiento_tipo.Mant_tipo_descr,
Mantenimiento_realizado.Mant_realizados_fecha as 'Fecha',
Equipo_categoria1.Cat1_equipo_desc +' / '+ Equipo_categoria2.Cat2_equipo_desc as 'Categoria' 
from Mantenimiento inner join dbo.Mantenimiento_realizado on Mantenimiento.Mantenimiento_id = Mantenimiento_realizado.Mantenimiento_id
inner join Equipo on Mantenimiento.Equipo_id = Equipo.Equipo_id 
inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Mantenimiento_periodicidad on Mantenimiento.Mant_periodicidad_id = Mantenimiento_periodicidad.Mant_periodicidad_id 
inner join Mantenimiento_tipo on Mantenimiento_periodicidad.Mant_tipo_id = Mantenimiento_tipo.Mant_tipo_id
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id 
inner join Equipo_categoria2 on Equipo.Equipo_idcat = Equipo_categoria2.Cat2_equipo_id 
inner join Equipo_categoria1 on Equipo_categoria2.Cat1_equipo_id = Equipo_categoria1.Cat1_equipo_id 
where Cliente_Sucursales.SucxClie_id =@SucxClie_id order by Mantenimiento_realizado.Mant_realizados_fecha  asc

--1) este select me trae los mantenimientos iniciales para que a partir de esos: se calcule los que corresponden a la fecha vigente.
select
Mantenimiento.Mantenimiento_id,
Equipo.Equipo_id, 
Equipo.Equipo_descripcion,
Cliente_suc_sector.Cliente_suc_sector_descripcion,
Cliente_suc_sector.Cliente_suc_sector_denominacion+'-'+Equipo.Equipo_denominacion  as 'etiqueta',
Mantenimiento_tipo.Mant_tipo_descr,
'en bd' as 'estado',
Mantenimiento_periodicidad.Mant_periodicidad_dias,
Mantenimiento.Mantenimiento_fecha_inicio,
Cliente_Sucursales.SucxClie_id,
Mantenimiento_periodicidad.Mant_periodicidad_desc +' ('+CONVERT(varchar(max), Mantenimiento_periodicidad.Mant_periodicidad_dias )+')' as 'periodicidad'    
from Mantenimiento 
inner join Equipo on Mantenimiento.Equipo_id = Equipo.Equipo_id 
inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Mantenimiento_periodicidad on Mantenimiento.Mant_periodicidad_id = Mantenimiento_periodicidad.Mant_periodicidad_id 
inner join Mantenimiento_tipo on Mantenimiento_periodicidad.Mant_tipo_id = Mantenimiento_tipo.Mant_tipo_id
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id 
where Cliente_Sucursales.SucxClie_id =@SucxClie_id and Mantenimiento.Mantenimiento_activo='si' order by Cliente_suc_sector.Cliente_suc_sector_descripcion  asc

--2 recupero la info del cliente

select
Cliente.CLI_dni ,
Cliente.CLI_Fan, 
Cliente_Sucursales.SucxClie_nombre,
Cliente_Sucursales.SucxClie_dir  
from Cliente inner join Cliente_Sucursales on Cliente.CLI_id = Cliente_Sucursales.CLI_id where Cliente_Sucursales.SucxClie_id = @SucxClie_id 

---3 recupera los detalles de cada mantenmiento realizado
select
dbo.Mantenimiento.Mantenimiento_id, 
dbo.Mantenimiento_realizado.Mant_realizados_id,
dbo.Mantenimiento_realizado_detalle.Mant_realizado_detalle_id,
Tareas_asignadas.Tareas_asignadas_id, 
Tareas.Tareas_desc, 
dbo.Mantenimiento_realizado_detalle.Mant_detalle,
'en_bd' as 'Estado'
from 
dbo.Mantenimiento_realizado_detalle inner join dbo.Mantenimiento_realizado on dbo.Mantenimiento_realizado_detalle.Mant_realizados_id =  dbo.Mantenimiento_realizado.Mant_realizados_id
inner join Mantenimiento on dbo.Mantenimiento_realizado.Mantenimiento_id = Mantenimiento.Mantenimiento_id
inner join Tareas_asignadas on dbo.Mantenimiento_realizado_detalle.Tareas_asignadas_id = Tareas_asignadas.Tareas_asignadas_id 
inner join Tareas on Tareas_asignadas.Tareas_id = Tareas.Tareas_id 
--inner join Equipo_categoria2_caracteristicas on dbo.Mantenimiento_realizado_detalle.Cat2_caract_id = Equipo_categoria2_caracteristicas.Cat2_caract_id 
inner join Equipo on Mantenimiento.Equipo_id = Equipo.Equipo_id 
inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id 
where Cliente_Sucursales.SucxClie_id =@SucxClie_id order by dbo.Mantenimiento_realizado.Mant_realizados_id asc

--4) este select es un auxiliar para cargar los campos atributos en caso de q no exista registrado un mantenimiento_realizado
select
dbo.Mantenimiento.Mantenimiento_id, 
Tareas_asignadas.Tareas_asignadas_id,
Tareas.Tareas_desc  
from Mantenimiento inner join Equipo on Mantenimiento.Equipo_id = Equipo.Equipo_id 
inner join Tareas_asignadas on Mantenimiento.Mantenimiento_id = Tareas_asignadas.Mantenimiento_id 
inner join Tareas on Tareas_asignadas.Tareas_id = Tareas.Tareas_id 
inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id 
where Cliente_Sucursales.SucxClie_id =@SucxClie_id order by Mantenimiento.Mantenimiento_id  asc
