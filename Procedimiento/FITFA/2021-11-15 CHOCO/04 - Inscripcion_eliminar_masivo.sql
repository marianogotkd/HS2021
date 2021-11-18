create procedure Inscripcion_eliminar_masivo
@inscripcion_id int

as
delete from inscripciones_x_torneo where inscripcion_id = @inscripcion_id 
delete from inscripciones_x_examen where inscripcion_id = @inscripcion_id 
delete from inscripcion where inscripcion.inscripcion_id = @inscripcion_id 
delete from inscripcion_qr where inscripcion_id = @inscripcion_id 



go