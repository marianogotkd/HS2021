USE [Delicias]
GO
/****** Object:  StoredProcedure [dbo].[Venta_obtenerProducto_Combos]    Script Date: 03/11/2021 02:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Venta_obtenerProducto_Combos]
@USU_id int --este id se recupera desde el login ...FORM INICIO
as
--actualizacion 09-09-2018 ...esta rutina trae el precio de venta minorista solamente
select	prod_id, prod_descripcion, prod_nrocat'CAT_nom', Marca_nom
from (Producto inner join Marca on Producto.marca_id = Marca.Marca_id)
---CHOCO : AQUI VOY A HACER TODOS LOS TIPOS DE BUSQUEDA POR DESCRIPCION...DEPENDIENDO DEL COMBO Q SELECIONE EN VISUAL
---2) solo trae productos...no combos
declare @sucursal_id int
select @sucursal_id = sucursal_id  from Usuario where Usuario.USU_id =@USU_id 
select
dbo.Producto.prod_id, 
dbo.Producto.prod_codinterno, 
dbo.Producto.prod_descripcion, 
dbo.Producto.prod_descrilarga, 
dbo.Producto.prod_precio_vta, 
dbo.Producto_x_sucursal.ProdxSuc_stock as prod_stock,
dbo.Producto_x_sucursal.ProdxSuc_ptorepo as prod_ptorepo, 
Producto.prod_codbarra,
Producto.prod_precio_vta_May,
prod_tipo,
prod_precio_editable    
from Producto inner join Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id 
inner join Sucursal  on Producto_x_sucursal.sucursal_id = Sucursal.sucursal_id
where Producto_x_sucursal.sucursal_id=@sucursal_id and Producto.prod_eliminado='no' 

--esta trae los combos declarados
SELECT    ProdCombo_id as prod_id, 
ProdCombo_codinterno as prod_codinterno, 
ProdCombo_descripcion as prod_descripcion, 
'' as prod_descrilarga,
ProdCombo_total as prod_precio_vta,
0 as prod_stock,
0 as prod_ptorepo,
'' as prod_codbarra
FROM         dbo.ProductoCombo                                                                                    
--esta trae los detalles de cada combo
SELECT     ProdCombo_id, ProdComboDet_id, ProductoComboDetalle.prod_id , ProdComboDet_cantidad, ProdComboDet_precio, ProdComboDet_subtotal, Producto.prod_descripcion 
FROM         dbo.ProductoComboDetalle inner join Producto on ProductoComboDetalle.prod_id=Producto.prod_id   order by prod_id  asc 