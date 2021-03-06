USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA]    Script Date: 11/08/2021 23:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA]
@Servicio_id int
as
--table(0)
select Servicio_id,servicio.CLI_id,Servicio_fecha,Servicio_Diagnostico,Servicio_Sucursal,Servicio_Estado,Servicio_Desc_peso,Servicio_Desc_porc,Servicio_IVA, 
Servicio_Equipo,Servicio_Anticipo,Servicio_FechaRev,Servicio_FechaRep, Cliente.CLI_Fan,CLI_dir,CLI_tel,CLI_dni,
Cliente_Sucursales.SucxClie_id, Cliente_Sucursales.SucxClie_nombre,
Cliente_Sucursales.SucxClie_dir, Cliente_Sucursales.SucxClie_tel, SucxClie_mail, IVA.IVA_Descripcion, Provincia.provincia, Localidades.Localidad,
Servicio.Equipo_id      
from Servicio inner join Cliente on Servicio.CLI_id= Cliente.CLI_id 
inner join Cliente_Sucursales on Servicio.SucxClie_id = Cliente_Sucursales.SucxClie_id
inner join IVA on Cliente.CLI_tipoiva = IVA.IVA_id 
inner join Provincia on Cliente_Sucursales.SucxClie_Prov = provincia.Prov_id 
inner join Localidades on Cliente_Sucursales.SucxClie_Loc = Localidades.id  
where Servicio_id =@Servicio_id

---table(1)
SELECT     dbo.Servicio_Producto.Servicio_Producto_Costo as 'Costo', 
dbo.Servicio_Producto.Servicio_Producto_Cantidad as 'Cantidad', 
dbo.Producto_x_sucursal.ProdxSuc_stock as 'Stock', 
dbo.Producto.prod_descripcion as 'Descripcion', 
dbo.Producto_x_sucursal.ProdxSuc_ID as 'ProdxSuc_ID', 
dbo.Producto.prod_codinterno as 'Cod_prod',
Servicio_Producto.Servicio_Producto_subtotal as 'subtotal',
dbo.Producto.prod_id as 'prod_id' 
FROM         dbo.Servicio_Producto INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Servicio_Producto.prod_id = dbo.Producto_x_sucursal.ProdxSuc_ID INNER JOIN
                      dbo.Producto ON dbo.Producto_x_sucursal.prod_id = dbo.Producto.prod_id where Servicio_id=@Servicio_id
                      
---table(2)                      
select Servicio_id, Orden_trabajo.Orden_trabajo_id, Cuadrilla_id     from Orden_trabajo where Orden_trabajo.Servicio_id = @Servicio_id 

--table(3)
---este ultimo select trae los datos de la sucursal q se eligi?? para mostrar en la factura
select Servicio.Servicio_id,servicio.CLI_id,Servicio_fecha,Servicio_Diagnostico,Servicio_Sucursal,Servicio_Estado,
Servicio_Equipo,Servicio_Anticipo,Servicio_FechaRev,Servicio_FechaRep, Cliente.CLI_Fan,CLI_dir,CLI_tel,CLI_dni,
Cliente_Sucursales.SucxClie_id, Cliente_Sucursales.SucxClie_nombre,
Cliente_Sucursales.SucxClie_dir, Cliente_Sucursales.SucxClie_tel, SucxClie_mail, IVA.IVA_Descripcion, Provincia.provincia, Localidades.Localidad     
from Servicio inner join Cliente on Servicio.CLI_id= Cliente.CLI_id 
inner join Venta_Producto on Servicio.Servicio_id = Venta_Producto.Servicio_id 
inner join Cliente_Sucursales on Venta_Producto.SucxClie_id = Cliente_Sucursales.SucxClie_id
inner join IVA on Cliente.CLI_tipoiva = IVA.IVA_id 
inner join Provincia on Cliente_Sucursales.SucxClie_Prov = provincia.Prov_id 
inner join Localidades on Cliente_Sucursales.SucxClie_Loc = Localidades.id  
where Servicio.Servicio_id =@Servicio_id