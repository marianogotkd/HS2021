se modifico la tabls producto_alta_new

USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_alta_New]    Script Date: 01/21/2021 17:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_alta_New]

@prod_descripcion varchar(max),
@prod_descrilarga varchar (max),
@prod_precio_vta decimal(8,2),
@prod_stock int,
@prod_ptorepo int,
@prod_codinterno int,
@prod_codbarra varchar (max),
@prod_idcat int,
@prod_nrocat int,
@marca_id int,
@prod_unidadmedida varchar(max), 
@prod_foto varbinary(max),
@prod_precio_vta_May decimal(8,2),
@prod_tipo varchar(50),
@prod_lote varchar(2),
@prod_contenido decimal (38,2)

as
insert Producto (prod_descripcion,prod_descrilarga,prod_precio_vta,prod_stock,prod_ptorepo,prod_codinterno,prod_codbarra,
                 prod_idcat,prod_nrocat,marca_id,prod_unidadmedida,prod_foto,prod_precio_vta_May, prod_eliminado,prod_tipo, prod_lote, prod_contenido ) 

values (@prod_descripcion,@prod_descrilarga,@prod_precio_vta,@prod_stock,@prod_ptorepo,@prod_codinterno,@prod_codbarra,
		@prod_idcat,@prod_nrocat,@marca_id,@prod_unidadmedida,@prod_foto,@prod_precio_vta_May, 'no', @prod_tipo, @prod_lote, @prod_contenido )

select prod_id from Producto where prod_codinterno=@prod_codinterno

select sucursal_id, sucursal_nombre from Sucursal order by Sucursal.sucursal_id asc 
