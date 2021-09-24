create procedure Equipo_atributo_buscar
@Equipo_id int
---busco todos los atributos y los listo ordenados por nombre
as
select * from Equipo_atributo_detalle inner  join Equipo_categoria2_caracteristicas on Equipo_categoria2_caracteristicas.Cat2_caract_id = Equipo_atributo_detalle.Cat2_caract_id 
where Equipo_atributo_detalle.Equipo_id = @Equipo_id order by Equipo_categoria2_caracteristicas.Cat2_caract_atributo asc

go