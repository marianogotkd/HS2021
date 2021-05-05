USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Consumos_mercaderia_obtener_rango_fechas]    Script Date: 03/02/2021 17:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------------------------------------------------------------------

ALTER procedure [dbo].[Consumos_mercaderia_obtener_rango_fechas]
@desde date,
@hasta date

as
select
Producto.prod_codinterno,
Producto.prod_descripcion + ' Lote Nº '+ Producto_x_sucursal_lote.lote_nro as 'prod_descripcion',
Consumo_Mercaderia_detalle.Consumo_mercaderiadetalle_cantidad,
sucursal_id_Origen, 
Sucursal.sucursal_nombre as 'Origen',
Usuario.USU_ape+', '+Usuario.USU_nom as 'Usuario', 
usuario.USU_id,
Consumo_Mercaderia.Consumo_mercaderia_id, 
Consumo_mercaderia_concepto, 
Consumo_mercaderia_FechaHora
from dbo.Consumo_Mercaderia inner join Sucursal on Consumo_Mercaderia.sucursal_id_Origen = Sucursal.sucursal_id
inner join Usuario on Consumo_Mercaderia.USU_id= Usuario.USU_id
inner join dbo.Consumo_Mercaderia_detalle on dbo.Consumo_Mercaderia.Consumo_mercaderia_id=dbo.Consumo_Mercaderia_detalle.Consumo_mercaderia_id 
inner join Producto 
on Consumo_Mercaderia_detalle.prod_codinterno = Producto.prod_codinterno 
inner join Producto_x_sucursal_lote on Consumo_Mercaderia_detalle.lote_id = Producto_x_sucursal_lote.lote_id
where (Consumo_Mercaderia.Consumo_mercaderia_FechaHora between @desde and @hasta)
--where (Consumo_Mercaderia.Consumo_mercaderia_FechaHora between @desde and DATEADD(day, 1, @hasta))
order by Consumo_Mercaderia.Consumo_mercaderia_id asc


---1) ordenados por concepto
select
Consumo_mercaderia_id, 
Consumo_mercaderia_concepto, 
Consumo_mercaderia_FechaHora, 
sucursal_id_Origen, 
Sucursal.sucursal_nombre as 'Origen',
Usuario.USU_ape+', '+Usuario.USU_nom as 'Usuario', 
usuario.USU_id
from dbo.Consumo_Mercaderia inner join Sucursal on Consumo_Mercaderia.sucursal_id_Origen = Sucursal.sucursal_id
inner join Usuario on Consumo_Mercaderia.USU_id= Usuario.USU_id where (Consumo_Mercaderia.Consumo_mercaderia_FechaHora between @desde and @hasta)
order by Consumo_Mercaderia.Consumo_mercaderia_id asc

