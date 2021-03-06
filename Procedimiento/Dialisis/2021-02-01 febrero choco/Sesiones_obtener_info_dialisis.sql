USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Sesiones_obtener_info_dialisis]    Script Date: 02/04/2021 11:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[Sesiones_obtener_info_dialisis]

@Sesiones_id int
as

select 
Dialisis_id, Dialisis.Sesiones_id, Dialisis_PesoS, Dialisis_Talla, Dialisis_HI, Dialisis_HE, Dialisis_TiempoHD, Dialisis_PesoI, Dialisis_PesoE, Dialisis_TAI, Dialisis_TAE, Dialisis_Filtro, Dialisis_Obs,
AccesoVascular, Sesiones.Sesiones_estado  
from Sesiones inner join Dialisis on
Sesiones.Sesiones_id = Dialisis.Sesiones_id
where Sesiones.Sesiones_id = @Sesiones_id  


select
Consumo_mercaderiadetalle_id, 
Consumo_mercaderiadetalle_cantidad, 
Consumo_Mercaderia.Consumo_mercaderia_id , 
Producto.prod_codinterno, 
Consumo_Mercaderia_detalle.lote_id,
Producto_x_sucursal_lote.lote_nro,  
Producto.prod_descripcion,
Producto_x_sucursal_lote.lote_vence ,
Producto_x_sucursal_lote.lote_fechafab,
Producto_x_sucursal_lote.lote_fechavto,
Producto.prod_unidadmedida,
Producto_x_sucursal_lote.Prov_id,
Producto_x_sucursal_lote.lote_aux       
from Consumo_Mercaderia inner join Consumo_Mercaderia_detalle on Consumo_Mercaderia.Consumo_mercaderia_id = Consumo_Mercaderia_detalle.Consumo_mercaderia_id 
inner join Producto on Consumo_Mercaderia_detalle.prod_codinterno = Producto.prod_codinterno   
inner join Producto_x_sucursal_lote on Consumo_Mercaderia_detalle.lote_id = Producto_x_sucursal_lote.lote_id   
where Consumo_Mercaderia.Sesiones_id = @Sesiones_id order by Consumo_Mercaderia_detalle.Consumo_mercaderiadetalle_id asc  

