USE [Delicias]
GO
/****** Object:  StoredProcedure [dbo].[Remito_productos_modificar]    Script Date: 03/11/2021 03:49:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Remito_productos_modificar]

@ventaprod_id int,
@ventaprod_total as decimal(38,2),
@usuario_id as integer,
@ventaprod_tipovta as varchar(max),
@cliente_id as integer,
@ventaprod_subtotal as decimal(38,2), --este parametro trae el total sumado de productos, sin descuento ni iva aplicado
@ventaprod_descuento_pesos as decimal (38,2), 
@ventaprod_descuento_porcentaje as decimal (5,2),
@ventaprod_iva_porcentaje as decimal (5,2),
@ventaprod_iva_pesos as decimal (38,2),
@ventaprod_observacion as varchar(50),
@Servicio_id  int,
@vendedor_id int,
@ventaprod_estado varchar(max)
as

update Venta_Producto set ventaprod_total = @ventaprod_total , 
usuario_id = @usuario_id ,
ventaprod_tipovta = @ventaprod_tipovta ,
cliente_id = @cliente_id ,
ventaprod_estado = @ventaprod_estado ,
ventaprod_subtotal = @ventaprod_subtotal ,
ventaprod_descuento_pesos = @ventaprod_descuento_pesos ,
ventaprod_descuento_porcentaje = @ventaprod_descuento_porcentaje ,
ventaprod_iva_porcentaje = @ventaprod_iva_porcentaje ,
ventaprod_iva_pesos = @ventaprod_iva_pesos ,
ventaprod_observacion = @ventaprod_observacion ,
Servicio_id = @Servicio_id , 
vendedor_id = @vendedor_id
where ventaprod_id = @ventaprod_id 

