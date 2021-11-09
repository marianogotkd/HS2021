USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Equipo_historial_recuperar]    Script Date: 11/08/2021 23:34:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Equipo_historial_recuperar]
@Equipo_id int

as

select
Equipo_id, 
Equipo_descripcion, 
Equipo_denominacion, 
Equipo.Cliente_suc_sector_id,
Cliente_suc_sector.Cliente_suc_sector_descripcion,
Cliente_Sucursales.SucxClie_id,+
Cliente_Sucursales.SucxClie_nombre as 'Sucursal',
Cliente.CLI_id, Cliente.CLI_Fan as 'Cliente',
Equipo_idcat, 
Equipo_nrocat,
Cliente_suc_sector.Cliente_suc_sector_denominacion+'-'+Equipo.Equipo_denominacion  as 'etiqueta',
Equipo_categoria1.Cat1_equipo_desc + ' / '+Equipo_categoria2.Cat2_equipo_desc as 'categoria'
from Equipo inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id
inner join Equipo_categoria2 on Equipo.Equipo_idcat = Equipo_categoria2.Cat2_equipo_id 
inner join Equipo_categoria1 on Equipo_categoria2.Cat1_equipo_id = Equipo_categoria1.Cat1_equipo_id 
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id 
inner join Cliente on Cliente_Sucursales.CLI_id = Cliente.CLI_id 
where Equipo.Equipo_id = @Equipo_id 

---1) este select solo me va a traer los mantenimientos que ya se realizaron. no los que esten pendientes
select
Mantenimiento.Mantenimiento_id,
Mantenimiento_realizado.Mant_realizados_id,
Equipo.Equipo_id, 
Equipo.Equipo_descripcion as 'Equipo',
Cliente_suc_sector.Cliente_suc_sector_descripcion as 'Sector',
Cliente_suc_sector.Cliente_suc_sector_denominacion+'-'+Equipo.Equipo_denominacion  as 'Etiqueta',
Mantenimiento_tipo.Mant_tipo_descr as 'Tipo_mantenimiento',
'en bd' as 'estado',
Mantenimiento_periodicidad.Mant_periodicidad_desc +' ('+CONVERT(varchar(max), Mantenimiento_periodicidad.Mant_periodicidad_dias )+')' as 'periodicidad',     
Mantenimiento_tipo.Mant_tipo_descr,
Mantenimiento_realizado.Mant_realizados_fecha as 'Fecha',
Equipo_categoria1.Cat1_equipo_desc +' / '+ Equipo_categoria2.Cat2_equipo_desc as 'Categoria',
0 as 'Servicio_id',---todos los mantenimientos tienen 0 en servicio_id
' ' as 'diagnostico' 
from Mantenimiento inner join dbo.Mantenimiento_realizado 
on Mantenimiento.Mantenimiento_id = Mantenimiento_realizado.Mantenimiento_id
inner join Equipo on Mantenimiento.Equipo_id = Equipo.Equipo_id 
inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Mantenimiento_periodicidad on Mantenimiento.Mant_periodicidad_id = Mantenimiento_periodicidad.Mant_periodicidad_id 
inner join Mantenimiento_tipo on Mantenimiento_periodicidad.Mant_tipo_id = Mantenimiento_tipo.Mant_tipo_id
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id 
inner join Equipo_categoria2 on Equipo.Equipo_idcat = Equipo_categoria2.Cat2_equipo_id 
inner join Equipo_categoria1 on Equipo_categoria2.Cat1_equipo_id = Equipo_categoria1.Cat1_equipo_id 
where Equipo.Equipo_id = @Equipo_id order by Mantenimiento_realizado.Mant_realizados_fecha  asc

---2 recupera los detalles de cada mantenmiento realizado
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
where Equipo.Equipo_id = @Equipo_id order by dbo.Mantenimiento_realizado.Mant_realizados_id asc

---3 traigo todas las ordenes de revision.
select 0 as 'Mantenimiento_id',
0 as 'Mant_realizados_id',
0 as 'Equipo_id', 
'' as 'Equipo',
'' as 'Sector',
''  as 'Etiqueta',
'Orden de Revision Nº'+ CONVERT(varchar(max), Servicio.servicio_id) as 'Tipo_mantenimiento',
'en bd' as 'estado',
'' as 'periodicidad',     
'' as Mant_tipo_descr,
servicio.Servicio_id, Servicio_FechaRev as 'Fecha',
'' as 'Categoria',
Servicio.Servicio_id, 
Servicio.Servicio_Diagnostico as 'diagnostico'  
from Servicio INNER JOIN Cliente on Cliente.CLI_id=Servicio.CLI_id 
--where sucursal_id=@sucursal_id  order by Servicio.Servicio_id 
where Servicio.Equipo_id = @Equipo_id and Servicio.Servicio_Estado = 'PENDIENTE' order by Servicio.Servicio_FechaRev asc


---4 traigo todas las ordenes de trabajo
select 0 as 'Mantenimiento_id',
0 as 'Mant_realizados_id',
0 as 'Equipo_id', 
'' as 'Equipo',
'' as 'Sector',
''  as 'Etiqueta',
'Orden de Trabajo Nº'+ CONVERT(varchar(max), Orden_trabajo.Orden_trabajo_id ) as 'Tipo_mantenimiento',
'en bd' as 'estado',
'' as 'periodicidad',     
'' as Mant_tipo_descr,
servicio.Servicio_id, Servicio_FechaRep  as 'Fecha',
'' as 'Categoria',
Servicio.Servicio_id,
Servicio.Servicio_Diagnostico as 'diagnostico'  
from  Servicio INNER JOIN Cliente on Cliente.CLI_id=Servicio.CLI_id inner join Orden_trabajo on Orden_trabajo.Servicio_id = Servicio.Servicio_id  
where Servicio.Equipo_id = @Equipo_id  and (Servicio.Servicio_Estado <> 'PENDIENTE') and (Servicio.Servicio_Estado <> 'ANULADO') order by Servicio.Servicio_FechaRep asc
