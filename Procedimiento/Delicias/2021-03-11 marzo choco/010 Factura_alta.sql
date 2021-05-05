USE [Delicias]
GO
/****** Object:  StoredProcedure [dbo].[Factura_alta]    Script Date: 03/12/2021 11:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Factura_alta]
@ventaprod_id int,
@factura_fecha datetime ,
@CAJA_id int
as
insert Factura (ventaprod_id, factura_fecha, CAJA_id ) values (@ventaprod_id, @factura_fecha, @CAJA_id  ) 

select factura_id from Factura where Factura.ventaprod_id = @ventaprod_id 

