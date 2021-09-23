CREATE procedure Equipo_obtener_todos_de_sucursal
---traer todos los equipos de una sucursal ordenados por Sector asc
@SucxClie_id int --este es el id de la sucursal
as
select
Cliente_suc_sector.Cliente_suc_sector_descripcion as 'Sector', 
Equipo.Equipo_descripcion,
Equipo.Equipo_denominacion,
Equipo_categoria1.Cat1_equipo_desc as 'Categoria_tipo',
Equipo_categoria2.Cat2_equipo_desc  as 'Categoria_subtipo',
Equipo.Equipo_id 
from Equipo inner join Cliente_suc_sector on Equipo.Cliente_suc_sector_id = Cliente_suc_sector.Cliente_suc_sector_id 
inner join Cliente_Sucursales on Cliente_suc_sector.SucxClie_id = Cliente_Sucursales.SucxClie_id  
inner join Equipo_categoria2 on Equipo.Equipo_idcat = Equipo_categoria2.Cat2_equipo_id 
inner join Equipo_categoria1 on Equipo_categoria1.Cat1_equipo_id = Equipo_categoria2.Cat1_equipo_id 
where (Equipo.Equipo_activo = 'si') and (Cliente_Sucursales.SucxClie_id = @SucxClie_id ) order by Cliente_suc_sector.Cliente_suc_sector_descripcion, Equipo.Equipo_descripcion  ASC 
go
