USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Movimiento_Mercaderia_Alta_obtener_detalle]    Script Date: 02/01/2021 13:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Movimiento_Mercaderia_Alta_obtener_detalle]
@MovMer_id int

as
select Producto.prod_codinterno,
Producto.prod_descripcion + ' Lote Nº '+ Producto_x_sucursal_lote.lote_nro as 'prod_descripcion',
Movimiento_Mercaderia_Detalle.MovMerDet_Cantidad,
MovMerDet_precioU, 
MovMerDet_subtotal
from Movimiento_Mercaderia_Detalle inner join Producto 
on Movimiento_Mercaderia_Detalle.prod_codinterno = Producto.prod_codinterno 
inner join Producto_x_sucursal_lote on Movimiento_Mercaderia_Detalle.lote_id = Producto_x_sucursal_lote.lote_id   

where Movimiento_Mercaderia_Detalle.MovMer_id=@MovMer_id 

select Proveedor.Prov_nombre, MovMer_IVA,
MovMer_TOTAL from Movimiento_Mercaderia inner join Proveedor on Movimiento_Mercaderia.Prov_id = Proveedor.Prov_id  where Movimiento_Mercaderia.MovMer_id = @MovMer_id