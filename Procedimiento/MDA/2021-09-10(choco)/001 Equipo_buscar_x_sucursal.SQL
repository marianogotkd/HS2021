ALTER procedure [dbo].[Equipo_buscar_x_sucursal]
@SucxClie_id int

as

select 
Equipo.Equipo_id ,
Equipo.Equipo_descripcion ,
Equipo.Equipo_denominacion ,
Cliente_suc_sector.Cliente_suc_sector_descripcion,
Cliente_suc_sector.Cliente_suc_sector_denominacion,
Cliente_suc_sector.Cliente_suc_sector_denominacion+'-'+Equipo.Equipo_denominacion  as 'etiqueta',
Equipo_categoria1.Cat1_equipo_desc+' / '+Equipo_categoria2.Cat2_equipo_desc as 'Categoria',
  Cliente_suc_sector.Cliente_suc_sector_id,
  Equipo_categoria2.Cat2_equipo_id  
  from equipo inner join Cliente_suc_sector on Cliente_suc_sector.Cliente_suc_sector_id = Equipo.Cliente_suc_sector_id 
inner join Cliente_Sucursales on Cliente_Sucursales.SucxClie_id = Cliente_suc_sector.SucxClie_id
inner join Equipo_categoria2 on Equipo.Equipo_idcat = Equipo_categoria2.Cat2_equipo_id 
inner join Equipo_categoria1 on Equipo_categoria2.Cat1_equipo_id = Equipo_categoria1.Cat1_equipo_id  
where Cliente_Sucursales.SucxClie_id = @SucxClie_id and Equipo.Equipo_activo='si' order by Cliente_suc_sector.Cliente_suc_sector_descripcion, Equipo.Equipo_descripcion  asc
