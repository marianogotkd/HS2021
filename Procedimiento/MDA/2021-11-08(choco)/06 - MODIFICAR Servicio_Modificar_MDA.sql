USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Servicio_Modificar_MDA]    Script Date: 11/08/2021 23:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Servicio_Modificar_MDA]
@CLI_id int,
@Servicio_fecha date,
@sucursal_id int,
@USU_id int,
@Servicio_Diagnostico varchar(50),
@Servicio_Sucursal varchar(50),
@Servicio_Equipo varchar(50),
@Servicio_FechaRev date,
@Servicio_FechaRep date,
@Servicio_Anticipo decimal(8,2),
@Servicio_id int,
@estado varchar(max),
@Servicio_Desc_peso decimal(8,2),
@Servicio_Desc_porc decimal(8,2),
@Servicio_IVA decimal(8,2),
@Equipo_id int

as

update servicio set 
CLI_id=@CLI_id, 
Servicio_fecha=@Servicio_fecha, 
sucursal_id=@sucursal_id, 
USU_id=@USU_id, 
Servicio_Diagnostico=@Servicio_Diagnostico, 
Servicio_Sucursal=@Servicio_Sucursal, 
Servicio_Equipo=@Servicio_Equipo, 
Servicio_FechaRev=@Servicio_FechaRev,
Servicio_FechaRep=@Servicio_FechaRep,
Servicio_Anticipo=@Servicio_Anticipo,
Servicio_Estado = @estado,
Servicio_Desc_peso=@Servicio_Desc_peso,
Servicio_Desc_porc=@Servicio_Desc_porc,
Servicio_IVA=@Servicio_IVA,
Equipo_id = @Equipo_id 

 


where Servicio.Servicio_id=@Servicio_id

delete Servicio_Producto where Servicio_Id=@Servicio_id