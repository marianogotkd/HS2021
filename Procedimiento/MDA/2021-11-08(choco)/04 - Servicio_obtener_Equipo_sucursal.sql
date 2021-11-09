USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Servicio_obtener_Equipo_sucursal]    Script Date: 11/08/2021 23:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Servicio_obtener_Equipo_sucursal]
---traer todos los equipos de una sucursal ordenados por Sector asc
@SucxClie_id int --este es el id de la sucursal
as
select
Cliente_suc_sector.Cliente_suc_sector_descripcion as 'Sector', 
Equipo.Equipo_descripcion,
Equipo.Equipo_denominacion,
Equipo_categoria1.Cat1_equipo_desc as 'Categoria_tipo',
Equipo_categoria2.Cat2_equipo_desc  as 'Categoria_subtipo',
Equipo.Equipo_id,
convert(varchar,Cliente.CLI_id) +'-'+convert(varchar,Cliente_Sucursales.SucxClie_id) +'-'+convert(varchar,Equipo.Equipo_idcat)+'-' +Cliente_suc_sector.Cliente_suc_sector_denominacion+'-'+ Equipo.Equipo_denominacion as 'etiqueta' 
 
from Equipo inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id  
inner join Equipo_categoria2 on Equipo.Equipo_idcat = Equipo_categoria2.Cat2_equipo_id 
inner join Equipo_categoria1 on Equipo_categoria1.Cat1_equipo_id = Equipo_categoria2.Cat1_equipo_id
inner join Cliente on Cliente_Sucursales.CLI_id = Cliente.CLI_id  
where (Equipo.Equipo_activo = 'si') and (Cliente_Sucursales.SucxClie_id = @SucxClie_id ) order by Cliente_suc_sector.Cliente_suc_sector_descripcion, Equipo.Equipo_descripcion  ASC 
