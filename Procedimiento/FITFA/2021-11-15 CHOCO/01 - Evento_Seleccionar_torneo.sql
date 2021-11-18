Create Procedure [dbo].[Evento_Seleccionar_torneo]	
as
Select evento_id, evento_descripcion, CONVERT(varchar, evento_fecha, 103) as 'evento_fecha' from evento where evento.evento_tipoevento='Torneo'
order by evento_fecha asc
go