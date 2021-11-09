USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Servicio_alta_MDA]    Script Date: 11/08/2021 23:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Servicio_alta_MDA]
@CLI_id int,
@Servicio_fecha date,
@sucursal_id int,
@USU_id int,
@Servicio_Diagnostico varchar(max),
@Servicio_Sucursal varchar(50),
@Servicio_Equipo varchar(50),
@Servicio_FechaRev date,
@Servicio_FechaRep date,
@Servicio_Anticipo decimal(8,2),
@Servicio_Estado varchar(50),
@SucxClie_id int,
@Servicio_Desc_peso decimal(8,2),
@Servicio_Desc_porc decimal(8,2),
@Servicio_IVA decimal(8,2),
@Equipo_id int
as

insert servicio ( CLI_id, Servicio_fecha, sucursal_id, USU_id,
Servicio_Diagnostico,
Servicio_Sucursal,
Servicio_Equipo,
Servicio_FechaRev,
Servicio_FechaRep,
Servicio_Anticipo,
Servicio_Estado,
SucxClie_id,
Servicio_Desc_peso,
Servicio_Desc_porc,
Servicio_IVA,
Equipo_id )

values (@CLI_id,
@Servicio_fecha,
@sucursal_id,
@USU_id,
@Servicio_Diagnostico,
@Servicio_Sucursal,
@Servicio_Equipo,
@Servicio_FechaRev,
@Servicio_FechaRep,
@Servicio_Anticipo,
@Servicio_Estado, 
@SucxClie_id,
@Servicio_Desc_peso,
@Servicio_Desc_porc,
@Servicio_IVA,
@Equipo_id )

select @@IDENTITY 
