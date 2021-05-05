USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_lote_actualizar_igualar]    Script Date: 01/26/2021 18:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_sucursal_lote_actualizar_igualar]
@lote_nro varchar(max),
@prod_id int,
@sucursal_id int,
@lote_cantidad decimal(38,2), ----este parametro es lo que quiero actualizar
@Prov_id int,
@lote_stock_real_a decimal(38,2),
@lote_aux decimal(38,2)

as
declare @ProdxSuc_ID int
select @ProdxSuc_ID = Producto_x_sucursal.ProdxSuc_ID from Producto_x_sucursal where prod_id = @prod_id and sucursal_id=@sucursal_id 

--declare @stock_lote decimal(38,2)

--select @stock_lote = lote_cantidad from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID=@ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id =@Prov_id

--declare @suma decimal(38,2)
--select @suma = @stock_lote + @lote_cantidad  

update Producto_x_sucursal_lote set lote_cantidad = @lote_cantidad, lote_stock_real=@lote_stock_real_a , lote_aux = @lote_aux  where lote_nro = @lote_nro and 
ProdxSuc_ID = @ProdxSuc_ID and Producto_x_sucursal_lote.Prov_id =@Prov_id

--select lote_id   from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID = @ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id =@Prov_id


select
Producto_x_sucursal_lote.lote_id 
from Producto inner join Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id 
inner join Producto_x_sucursal_lote on Producto_x_sucursal.ProdxSuc_ID = Producto_x_sucursal_lote.ProdxSuc_ID 
inner join Sucursal on Producto_x_sucursal.sucursal_id = sucursal.sucursal_id 
where Producto_x_sucursal_lote.lote_nro = @lote_nro and producto.prod_id = @prod_id and sucursal.sucursal_id = @sucursal_id    
order by Producto_x_sucursal_lote.lote_nro asc    
