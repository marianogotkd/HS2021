USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_lote_actualizar_suma]    Script Date: 01/26/2021 17:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_sucursal_lote_actualizar_suma]
@lote_nro varchar(max),
@prod_id int,
@sucursal_id int,
@lote_cantidad decimal(38,2), ----este parametro es lo que quiero quitar
@Prov_id int,
@lote_stock_real_a decimal(38,2)

as
declare @ProdxSuc_ID int
select @ProdxSuc_ID = Producto_x_sucursal.ProdxSuc_ID from Producto_x_sucursal where prod_id = @prod_id and sucursal_id=@sucursal_id 

declare @stock_lote decimal(38,2)

select @stock_lote = lote_cantidad from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID=@ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id =@Prov_id

declare @suma decimal(38,2)
select @suma = @stock_lote + @lote_cantidad  
----------manejo de stock real, choco 26-01-2021
declare @lote_st_real decimal(38,2)
select @lote_st_real = lote_stock_real from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID=@ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id =@Prov_id

declare @suma_real decimal (38,2)
select @suma_real = @lote_st_real + @lote_stock_real_a ---sumo la cant real ingresada del lote, mas lo que tenia ya  
------------

update Producto_x_sucursal_lote set lote_cantidad = @suma, lote_stock_real = @suma_real where lote_nro = @lote_nro and 
ProdxSuc_ID = @ProdxSuc_ID and Producto_x_sucursal_lote.Prov_id =@Prov_id

--select lote_id   from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID = @ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id =@Prov_id


select
Producto_x_sucursal_lote.lote_id 
from Producto inner join Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id 
inner join Producto_x_sucursal_lote on Producto_x_sucursal.ProdxSuc_ID = Producto_x_sucursal_lote.ProdxSuc_ID 
inner join Sucursal on Producto_x_sucursal.sucursal_id = sucursal.sucursal_id 
where Producto_x_sucursal_lote.lote_nro = @lote_nro and producto.prod_id = @prod_id and sucursal.sucursal_id = @sucursal_id    
order by Producto_x_sucursal_lote.lote_nro asc    

