--USE [master]
--GO
--/****** Object:  Database [db_a86310_adminpanal]    Script Date: 06/06/2022 19:28:19 ******/
CREATE DATABASE [db_a86310_adminpanal]
use [db_a86310_adminpanal]

/****** Object:  Table [dbo].[Usuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdPais] [int] NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Genero] [varchar](10) NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaNacimietno] [datetime] NULL,
	[FotoPerfil] [image] NULL,
	[FotoPortada] [image] NULL,
	[Estado] [bit] NULL,
	[RoldeUsuario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Amigos]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Amigos](
	[IdAmigos] [int] NOT NULL,
	[IdUsuario] [int] NULL,
	[IdUsuario2] [int] NULL,
	[FechaEnvio] [datetime] NULL,
	[FechaRespuesta] [datetime] NULL,
	[Respuesta] [bit] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAmigos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FMostrar_AmigosConexion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   function [dbo].[FMostrar_AmigosConexion](@IdUsuario int)
returns table
as return(
	select IdAmigos,Usuario.IdUsuario,FotoPerfil,NombreUsuario from Usuario
	inner join Amigos on Usuario.IdUsuario in (Amigos.IdUsuario,Amigos.IdUsuario2)
	where Amigos.Estado=1 and @IdUsuario in (Amigos.IdUsuario,Amigos.IdUsuario2)
	and Usuario.IdUsuario!=@IdUsuario)
GO
/****** Object:  UserDefinedFunction [dbo].[FMostrar_Amigos]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   function [dbo].[FMostrar_Amigos](@IdUsuario int)
returns table
as return(
	select IdAmigos,FotoPerfil,'NombreCompleto'=Nombre+' '+Apellidos,Usuario.IdUsuario from Usuario
	inner join Amigos on Usuario.IdUsuario in (Amigos.IdUsuario,Amigos.IdUsuario2)
	where Amigos.Estado=1 and @IdUsuario in (Amigos.IdUsuario,Amigos.IdUsuario2)
	and Usuario.IdUsuario!=@IdUsuario)
GO
/****** Object:  UserDefinedFunction [dbo].[FMostrar_Usuarios]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   function [dbo].[FMostrar_Usuarios](@IdUsuario int)
returns table
as return(
		select IdUsuario,FotoPerfil,'NombreCompleto'=Nombre+' '+Apellidos,Correo,'CasoUsuario'=
		(case
			when IdUsuario=@IdUsuario
				then '0' --Usuario principal
			when exists(select * from Amigos where @IdUsuario in (IdUsuario,IdUsuario2) and	USUARIO.IdUsuario in (IdUsuario,IdUsuario2)
			and Estado=1)
				then '1' --Ya son amigos
			when exists(select * from Amigos where IdUsuario=USUARIO.IdUsuario and IdUsuario2=@IdUsuario and FechaRespuesta is null)
				then '2' --Ya te envio solicitud
			when exists(select * from Amigos where IdUsuario=@IdUsuario and IdUsuario2=USUARIO.IdUsuario and FechaRespuesta is null)
				then '3' --Ya enviaste solicitud
			else '4' --enviar solicitud
		end)
	from Usuario where Estado=1)
GO
/****** Object:  Table [dbo].[Chat]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chat](
	[IdChat] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario1] [int] NULL,
	[IdUsuario2] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdChat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[IdComentario] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdPublicacion] [int] NULL,
	[Comentario] [varchar](1000) NULL,
	[FechaComentario] [datetime] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdComentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conexiones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conexiones](
	[IdConexiones] [int] NOT NULL,
	[IdUsuario] [int] NULL,
	[HoraInicioSesion] [datetime] NULL,
	[HoraCierreSesion] [datetime] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdConexiones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mensaje]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mensaje](
	[IdMensaje] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdChat] [int] NULL,
	[Mensaje] [varchar](500) NULL,
	[FechaCreacion] [datetime] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMensaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notificacion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notificacion](
	[IdNotificacion] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[visto] [int] NULL,
	[tipo] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNotificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[IdPais] [int] IDENTITY(1,1) NOT NULL,
	[NombrePais] [varchar](50) NULL,
	[CodigoTelfPais] [varchar](50) NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicaciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create or alter  function [dbo].[FMostrar_UsuarioUltimaConexion](@IdUsuario int)
returns varchar(20)
as begin
	if exists(select*from Conexiones where IdUsuario=@IdUsuario and Estado=1)
	return 'activo(a)'
	declare @ultimaConexion varchar(20)
	declare @minuto int,@hora int,@dia int
	select @minuto=DATEDIFF(MINUTE,HoraCierreSesion,DATEADD(HOUR,3,GETDATE()))
	from Conexiones
	where IdUsuario=@IdUsuario and HoraCierreSesion is not null
	order by IdConexiones

	select @hora=DATEDIFF(HOUR,HoraCierreSesion,DATEADD(HOUR,3,GETDATE()))
	from Conexiones
	where IdUsuario=@IdUsuario and HoraCierreSesion is not null
	order by IdConexiones

	select @dia=DATEDIFF(DAY,HoraCierreSesion,DATEADD(HOUR,3,GETDATE()))
	from Conexiones
	where IdUsuario=@IdUsuario and HoraCierreSesion is not null
	order by IdConexiones
	select @ultimaConexion=(
	case
		when @minuto<60
			then str(@minuto)+' min'
		when @hora<24
			then str(@hora)+' hora(s)'
		else str(@dia)+' dia(s)'
	end
	)
	return @ultimaConexion
end
GO

CREATE TABLE [dbo].[Publicaciones](
	[IdPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Descripcion] [varchar](1000) NULL,
	[FechaPublicacion] [datetime] NOT NULL,
	[FotoPublicacion] [image] NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reaccion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reaccion](
	[IdReaccion] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[TipoReaccion] [varchar](50) NOT NULL,
	[FechaAudoria] [datetime] NULL,
	[EstadoAuditoria] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reacciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reacciones](
	[IdReacciones] [int] IDENTITY(1,1) NOT NULL,
	[IdPublicacion] [int] NULL,
	[IdUsuario] [int] NULL,
	[IdReaccion] [int] NULL,
	[FechaAudoria] [datetime] NULL,
	[EstadoAuditoria] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReacciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReaccionesCom]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReaccionesCom](
	[IdReaccionesCom] [int] IDENTITY(1,1) NOT NULL,
	[IdComentario] [int] NULL,
	[IdUsuario] [int] NULL,
	[IdReaccion] [int] NULL,
	[FechaAudoria] [datetime] NULL,
	[EstadoAuditoria] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReaccionesCom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaIPs]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaIPs](
	[IdUsuario] [int] NOT NULL,
	[DireccionIP] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Amigos]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Amigos]  WITH CHECK ADD FOREIGN KEY([IdUsuario2])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD FOREIGN KEY([IdUsuario1])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD FOREIGN KEY([IdUsuario2])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([IdPublicacion])
REFERENCES [dbo].[Publicaciones] ([IdPublicacion])
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Conexiones]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Mensaje]  WITH CHECK ADD FOREIGN KEY([IdChat])
REFERENCES [dbo].[Chat] ([IdChat])
GO
ALTER TABLE [dbo].[Mensaje]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Reaccion]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Reacciones]  WITH CHECK ADD FOREIGN KEY([IdPublicacion])
REFERENCES [dbo].[Publicaciones] ([IdPublicacion])
GO
ALTER TABLE [dbo].[Reacciones]  WITH CHECK ADD FOREIGN KEY([IdReaccion])
REFERENCES [dbo].[Reaccion] ([IdReaccion])
GO
ALTER TABLE [dbo].[Reacciones]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ReaccionesCom]  WITH CHECK ADD FOREIGN KEY([IdComentario])
REFERENCES [dbo].[Comentario] ([IdComentario])
GO
ALTER TABLE [dbo].[ReaccionesCom]  WITH CHECK ADD FOREIGN KEY([IdReaccion])
REFERENCES [dbo].[Reaccion] ([IdReaccion])
GO
ALTER TABLE [dbo].[ReaccionesCom]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[TablaIPs]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdPais])
REFERENCES [dbo].[Pais] ([IdPais])
GO
/****** Object:  StoredProcedure [dbo].[eliminarUsuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[eliminarUsuario]
@Correo varchar (50)
as begin
	update Usuario set Estado = 0
	where Correo = @Correo
end
GO
/****** Object:  StoredProcedure [dbo].[modificarUsuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[modificarUsuario]
@Pais varchar (50),
@Nombre varchar (50),
@Apellidos varchar(50),
@NombreUsuario varchar(50),
@Contraseña varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Genero varchar(50),
@FechaNacimiento datetime,
@FotoPerfil image,
@FotoPortada image

as begin
	declare @paisaux int = (select IdPais from Pais where NombrePais = @Pais)
	update Usuario set IdPais = @paisaux, Nombre = @Nombre, Apellidos = @Apellidos, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, 
			Correo = @Correo, Telefono = @Telefono, Genero = @Genero, FechaNacimietno = @FechaNacimiento, FotoPerfil = @FotoPerfil, FotoPortada = @FotoPortada, RoldeUsuario = 'Usuario'
			where Correo = @Correo
end
GO
/****** Object:  StoredProcedure [dbo].[PConsultarImagenUsuarioPubl]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[PConsultarImagenUsuarioPubl]
@IdUsuario int
as begin
	select FotoPerfil
	from Usuario where IdUsuario=@IdUsuario
end;
GO
/****** Object:  StoredProcedure [dbo].[PConsultarPublicaciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create       procedure [dbo].[PConsultarPublicaciones]
@IdUsuario int
as begin
	select IdPublicacion,NombreUsuario,Descripcion,FechaPublicacion,FotoPublicacion
	from Publicaciones inner join Usuario	
		on Publicaciones.IdUsuario=Usuario.IdUsuario
	where Publicaciones.Estado=1
end;
GO
/****** Object:  StoredProcedure [dbo].[PConsultarPublicaciones22]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[PConsultarPublicaciones22]
@IdUsuario int
as begin
	select Publicaciones.IdPublicacion,Publicaciones.IdUsuario,Descripcion,FechaPublicacion,
			FotoPublicacion,NombreUsuario,Nombre,Apellidos,FotoPerfil
	from Publicaciones inner join Usuario
		on Publicaciones.IdUsuario=Usuario.IdUsuario
	where (Publicaciones.IdUsuario in(select IdUsuario2 
						from Amigos where IdUsuario=@IdUsuario and Estado=1)
		or Publicaciones.IdUsuario in (select IdUsuario from Amigos
						where IdUsuario2=@IdUsuario and Estado=1)
		OR Publicaciones.IdUsuario=@IdUsuario) and Publicaciones.Estado=1
end;
GO
/****** Object:  StoredProcedure [dbo].[PConsultarPublicaciones33]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    procedure [dbo].[PConsultarPublicaciones33]
@IdUsuario int
as begin
	select Publicaciones.IdPublicacion,Publicaciones.IdUsuario,Descripcion,FechaPublicacion,
			FotoPublicacion,NombreUsuario,Nombre,Apellidos
	from Publicaciones inner join Usuario
		on Publicaciones.IdUsuario=Usuario.IdUsuario
	where (Publicaciones.IdUsuario in(select IdUsuario2 
						from Amigos where IdUsuario=@IdUsuario and Estado=1)
		or Publicaciones.IdUsuario in (select IdUsuario from Amigos
						where IdUsuario2=@IdUsuario and Estado=1)
		OR Publicaciones.IdUsuario=@IdUsuario) and Publicaciones.Estado=1
end;
GO
/****** Object:  StoredProcedure [dbo].[PEditarPublicacion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[PEditarPublicacion]
@IdPublicacion int,
@IdUsuario int,
@Descripcion varchar(1000),
@FotoPublicacion image,
@Respuesta bit output,
@Mensaje varchar(500) output
as begin
	set @Respuesta=0
	set @Mensaje=''
	if exists(select*from Publicaciones where IdPublicacion=@IdPublicacion)
	begin
	update Publicaciones
	set IdUsuario=@IdUsuario,Descripcion=@Descripcion,
		FotoPublicacion=@FotoPublicacion
	where IdPublicacion=@IdPublicacion
	set @Respuesta=1
	set @Mensaje='Publicación modificada con éxito'
	end
	else
	set @Mensaje='No existe el id de la publicacion'
end;
GO
/****** Object:  StoredProcedure [dbo].[PEliminarLogPublicacion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[PEliminarLogPublicacion]
@IdPublicacion int,
@IdUsuario int,
@Resultado bit output,
@Mensaje varchar(500) output
as begin
	set @Resultado=0
	set @Mensaje=''
	if exists(select*from Publicaciones 
				where IdPublicacion=@IdPublicacion
				and IdUsuario=@IdUsuario)
	begin
		update Publicaciones
		set Estado=0
		where IdPublicacion=@IdPublicacion
			and IdUsuario=@IdUsuario
		set @Mensaje='La publicación se ha eliminado'
		set @Resultado=1
	end
end;
GO
/****** Object:  StoredProcedure [dbo].[PGuardarIP]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[PGuardarIP]
@IdUsuario int,
@DireccionIP varchar(30)
as begin
	if not exists(select*from TablaIPs where IdUsuario=@IdUsuario)
		insert into TablaIPs
		values (@IdUsuario,@DireccionIP)
	else
		update TablaIPs
		set DireccionIP=@DireccionIP
		where IdUsuario=@IdUsuario		
end;
GO
/****** Object:  StoredProcedure [dbo].[PLeerIP]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[PLeerIP]
@IdUsuario int,
@DireccionIP varchar(30) output
as begin
	select @DireccionIP=DireccionIP from TablaIPs
	where IdUsuario=@IdUsuario
end;
GO
/****** Object:  StoredProcedure [dbo].[PLoginUsuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[PLoginUsuario]
@nombreUsuario varchar(50),
@password varchar(50),
@salida int output,
@idUsuario int output
as begin
	if exists(select * from Usuario where 
					nombreUsuario=@nombreUsuario and Contraseña=@password)
		begin
		set @salida=1
		select @idUsuario=idUsuario
			from Usuario where nombreUsuario=@nombreUsuario and Contraseña=@password
		end
	else
		set @salida=0
end;
GO
/****** Object:  StoredProcedure [dbo].[PLoginUsuario22]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[PLoginUsuario22]
@nombreUsuario varchar(50),
@password varchar(50),
@salida int output
as begin
	if exists(select * from Usuario where 
					nombreUsuario=@nombreUsuario and Contraseña=@password)
		begin
		set @salida=1
		select *
			from Usuario where nombreUsuario=@nombreUsuario and Contraseña=@password
		end
	else
		set @salida=0
end;
GO
/****** Object:  StoredProcedure [dbo].[PLoginUsuario33]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[PLoginUsuario33]
@nombreUsuario varchar(50),
@password varchar(50),
@salida int output,
@idUsuario int output
as begin
	if exists(select * from Usuario where 
					nombreUsuario=@nombreUsuario and Contraseña=@password)
		begin
		set @salida=1		
		select @idUsuario=IdUsuario
			from Usuario where nombreUsuario=@nombreUsuario and Contraseña=@password
		end
	else
		set @salida=0
end;
GO
/****** Object:  StoredProcedure [dbo].[PLoginUsuarioalterno]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PLoginUsuarioalterno]
@nombreUsuario varchar(50),
@password varchar(50),
@salida int output,
@Rol int output,
@idUsuario int output

as begin
set @Rol = 0
	if exists(select * from Usuario where 
					nombreUsuario=@nombreUsuario and Contraseña=@password and RoldeUsuario = 'usuario')
		begin
		set @salida=1
		set @rol = 1
		select @idUsuario=idUsuario
		from Usuario where nombreUsuario=@nombreUsuario and Contraseña=@password
		            
		end
	else
		set @salida=0
end;
GO
/****** Object:  StoredProcedure [dbo].[PRegistrarPublicacion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       procedure [dbo].[PRegistrarPublicacion]
@IdUsuario int,
@Descripcion varchar(1000),
@FotoPublicacion image,
@Respuesta bit output,
@Mensaje varchar(500) output
as begin
	set @Respuesta=0
	set @Mensaje=''
	insert into Publicaciones
	values(@IdUsuario,@Descripcion,GETDATE(),@FotoPublicacion,1)
	set @Respuesta=1
	set @Mensaje='Publicación realizada con éxito'
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_CambiarContraseña]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_CambiarContraseña]
@Correo varchar(50),
@Contraseña varchar(50)
as begin
	update Usuario set Contraseña = @Contraseña
	where Correo = @Correo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARPAIS]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_EDITARPAIS]
@IDPAIS INT,
@NOMBREDELPAIS VARCHAR(50),
@CODIGOTELEFPAIS VARCHAR(50)

AS BEGIN

if not exists(SELECT*FROM Pais WHERE NombrePais= @NOMBREDELPAIS
and IdPais !=@IDPAIS)
begin
update Pais set
NombrePais=@NOMBREDELPAIS,
CodigoTelfPais=@CODIGOTELEFPAIS
where IdPais = @IDPAIS

end

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINACIONLOGPAIS]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_ELIMINACIONLOGPAIS]
@IDPAIS INT
AS BEGIN

UPDATE Pais
SET Estado =0
WHERE IdPais = @IDPAIS


END
GO
/****** Object:  StoredProcedure [dbo].[SP_login]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_login]

	@Usersql varchar(100),
	@Contraseniasql varchar(100)
	
AS
BEGIN

	SET NOCOUNT ON;


	SELECT * from Usuario where NombreUsuario=@Usersql and contraseña=@Contraseniasql and RoldeUsuario = 'administrador'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARPAIS]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_REGISTRARPAIS]
@NOMBREPAIS VARCHAR(50),
@CODIGODELPAIS VARCHAR(50)
AS BEGIN
IF NOT EXISTS(SELECT * FROM Pais WHERE NombrePais = @NOMBREPAIS)
BEGIN
INSERT INTO Pais(NombrePais,CodigoTelfPais,Estado) VALUES(@NOMBREPAIS,@CODIGODELPAIS,1)
END
END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarUsuarios]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPBuscarUsuarios]
@Nombre varchar(50),
@Apellidos varchar(50),
@NombreUsuario varchar(50)
as begin
if exists (select * from Usuario
where Nombre = @Nombre or Apellidos= @Apellidos or NombreUsuario = @NombreUsuario)
begin
select Nombre,Apellidos, NombreUsuario,Correo,Telefono,FotoPerfil,Idusuario,NombrePais from usuario inner join Pais on usuario.IdPais = Pais.IdPais where Nombre = @Nombre or Apellidos = @Apellidos or NombreUsuario = @NombreUsuario
end
end
GO
/****** Object:  StoredProcedure [dbo].[SPcantidad_Comentario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPcantidad_Comentario]
@IdPublicacion int
as begin
select count(IdComentario) as 'cantidad' from Comentario where IdPublicacion = @IdPublicacion
end
GO
/****** Object:  StoredProcedure [dbo].[SPConsultaNoti]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPConsultaNoti]
@IdUsuario int,
@resultado int OUTPUT,
@tipo int OUTPUT
as begin
	set @resultado = (select count(IdUsuario) from Notificacion where IdUsuario = @IdUsuario)
	set @tipo = (SELECT TOP 1 tipo FROM Notificacion WHERE IdUsuario = @IdUsuario ORDER BY idNotificacion DESC )
end
GO
/****** Object:  StoredProcedure [dbo].[SPConsultaNotiChat]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPConsultaNotiChat]
@IdUsuario int,
@resultado int OUTPUT,
@tipo int OUTPUT
as begin
	set @resultado = (select TOP 1 visto from Notificacion where IdUsuario = @IdUsuario ORDER BY idNotificacion DESC)
	set @tipo = (SELECT TOP 1 tipo FROM Notificacion WHERE IdUsuario = @IdUsuario ORDER BY idNotificacion DESC)
end
GO
/****** Object:  StoredProcedure [dbo].[SPConsultar_IdAmigos]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPConsultar_IdAmigos]
@IdUsuario int,
@IdUsuario2 int,
@IdAmigos int output
as begin
	select @IdAmigos=IdAmigos from Amigos
	where IdUsuario=@IdUsuario2 and IdUsuario2=@IdUsuario and FechaRespuesta is null
end
GO
/****** Object:  StoredProcedure [dbo].[SPConsultar_IdAmigos2]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPConsultar_IdAmigos2]
@IdUsuario int,
@IdUsuario2 int,
@IdAmigos int output
as begin
	select @IdAmigos=IdAmigos from Amigos
	where IdUsuario=@IdUsuario and IdUsuario2=@IdUsuario2 and FechaRespuesta is null
end
GO
/****** Object:  StoredProcedure [dbo].[SPEliminar_Amigos]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPEliminar_Amigos]
@IdAmigos int
as begin
	if exists(select * from Amigos where IdAmigos=@IdAmigos)
	begin
		update Amigos set Estado=0
		where IdAmigos=@IdAmigos
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SPEliminar_Reaccion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create     PROCEDURE  [dbo].[SPEliminar_Reaccion]
    @IdReaccion int
AS
BEGIN
	if exists(select * from Reaccion Where IdReaccion = @IdReaccion)
			BEGIN
					update Reaccion set 
					EstadoAuditoria = 0
					where IdReaccion = @IdReaccion
			END
END
GO
/****** Object:  StoredProcedure [dbo].[SPEliminar_Reacciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPEliminar_Reacciones]
@IdPublicacion int
as begin 
	if exists (select * from Reacciones where IdPublicacion = @IdPublicacion)
	begin
	update Reacciones 
	set EstadoAuditoria = 0
	end 
end
GO
/****** Object:  StoredProcedure [dbo].[SPModificar_Reaccion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE  [dbo].[SPModificar_Reaccion]
    @IdReaccion int,
	@TipoReaccion varchar(50)
AS
BEGIN
	if not exists(select * from Reaccion1 Where IdReaccion = @IdReaccion)
		BEGIN
				update Reaccion set 
				TipoReaccion = @TipoReaccion,
				FechaAudoria = getdate()
				where IdReaccion = @IdReaccion
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SPModificar_Reacciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPModificar_Reacciones]
@IdReacciones int,
@IdPublicacion int,
@IdUsuario int,
@IdReaccion int
as begin 
	if exists (select * from Reacciones where IdReacciones = @IdReacciones)
begin
	update Reacciones set IdPublicacion=@IdPublicacion, IdUsuario=@IdUsuario, 
	IdReaccion=@IdReaccion
	end
end 
GO
/****** Object:  StoredProcedure [dbo].[SPMostrar_Amigos]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPMostrar_Amigos]
@IdUsuario int
as begin
	select * from dbo.FMostrar_Amigos(@IdUsuario)
end
GO
/****** Object:  StoredProcedure [dbo].[SPMostrar_AmigosBuscar]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPMostrar_AmigosBuscar]
@IdUsuario int,
@Nombre varchar(50)
as begin
	select * from dbo.FMostrar_Amigos(@IdUsuario)
	where NombreCompleto LIKE '%'+@Nombre+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPMostrar_AmigosConexion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPMostrar_AmigosConexion]
@IdUsuario int
as begin
	select FotoPerfil,NombreUsuario,'estadoConexion'=dbo.FMostrar_UsuarioUltimaConexion(IdUsuario)
	from dbo.FMostrar_AmigosConexion(@IdUsuario)
end
GO
/****** Object:  StoredProcedure [dbo].[SPMostrar_Solicitudes]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPMostrar_Solicitudes]
@IdUsuario int
as begin
	select IdAmigos,FotoPerfil,'NombreCompleto'=Nombre+' '+Apellidos from Usuario
	inner join Amigos on Usuario.IdUsuario=Amigos.IdUsuario
	where Amigos.IdUsuario2=@IdUsuario and FechaRespuesta is null
end
GO
/****** Object:  StoredProcedure [dbo].[SPMostrar_Usuarios]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPMostrar_Usuarios]
@IdUsuario int
as begin
	select * from dbo.FMostrar_Usuarios(@IdUsuario)
end
GO
/****** Object:  StoredProcedure [dbo].[SPMostrar_UsuariosBuscar]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPMostrar_UsuariosBuscar]
@IdUsuario int,
@Nombre varchar(50)
as begin
	select * from dbo.FMostrar_Usuarios(@IdUsuario)
	where NombreCompleto  LIKE '%'+@Nombre+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPmostrarReaccion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create       procedure [dbo].[SPmostrarReaccion]
as begin
select IdReaccion,TipoReaccion from Reaccion
end;
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_Chat]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPRegistrar_Chat]
@IdUsuario1 int,
@IdUsuario2 int
as begin 
	if not exists(select * from Chat where IdUsuario1=@IdUsuario1 and IdUsuario2=@IdUsuario2 or IdUsuario1=@IdUsuario2 and IdUsuario2=@IdUsuario1)
		insert into Chat values (@IdUsuario1,@IdUsuario2,getdate(),1)
end 
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_CierreSesion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPRegistrar_CierreSesion]
@IdUsuario int
as begin
	update Conexiones set HoraCierreSesion=DATEADD(HOUR,3,GETDATE()),Estado=0
	where IdUsuario=@IdUsuario and Estado=1
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_Comentario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPRegistrar_Comentario]
@IdUsuario int,
@IdPublicacion int,
@Comentario varchar(1000),
@Respuesta bit OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
as begin
	SET @Respuesta = 0
	set @Mensaje = 'El comentario ya esta registrado'
		insert into Comentario
		values(@IdUsuario,@IdPublicacion,@Comentario,GETDATE(),1)
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_InicioSesion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPRegistrar_InicioSesion]
@IdUsuario int
as begin
	declare @Id int=(select MAX(IdConexiones)+1 from Conexiones)
	if @Id is null
		set @Id=1
	update Conexiones set Estado=0 where IdUsuario=@IdUsuario and Estado=1
	insert into Conexiones values(@Id,@IdUsuario,DATEADD(HOUR,3,GETDATE()),null,1)
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_Mensaje]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPRegistrar_Mensaje]
@IdUsuario int,
@IdUsuario2 int,
@IdChat int,
@Mensaje varchar(500)
as begin 
insert into Mensaje values (@IdUsuario,@IdChat,@Mensaje,getdate(),1)
insert into Notificacion values(@IdUsuario2,@IdUsuario,2,0)
end 
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_Reaccion]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create     procedure [dbo].[SPRegistrar_Reaccion]
	@TipoReaccion varchar(50)
AS
BEGIN
	if not exists(select * from Reaccion Where TipoReaccion = @TipoReaccion)
		BEGIN
		insert into Reaccion values(null,@TipoReaccion,getdate(),1)
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_Reacciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPRegistrar_Reacciones]
@IdUsuario int,
@IdPublicacion int,
@IdReaccion int
as begin 
	if exists(select * from Reacciones where IdPublicacion=@IdPublicacion and IdUsuario=@IdUsuario)
	begin
		update Reacciones set IdReaccion=@IdReaccion
		where IdPublicacion=@IdPublicacion and IdUsuario=@IdUsuario
	end
	else
		insert into Reacciones values (@IdPublicacion,@IdUsuario,@IdReaccion,getdate(),1)
end 
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_ReaccionesCom]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPRegistrar_ReaccionesCom]
@IdUsuario int,
@IdComentario int,
@IdReaccion int
as begin 
	if exists(select * from ReaccionesCom where IdComentario=@IdComentario and IdUsuario=@IdUsuario)
	begin
		update ReaccionesCom set IdReaccion=@IdReaccion
		where IdComentario=@IdComentario AND IdUsuario=@IdUsuario
	end
	else
		insert into ReaccionesCom values (@IdComentario,@IdUsuario,@IdReaccion,getdate(),1)
end 
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_SolicitudAceptada]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPRegistrar_SolicitudAceptada]
@IdAmigos int
as begin
	update Amigos set FechaRespuesta=GETDATE(),Respuesta=1,Estado=1
	where IdAmigos=@IdAmigos
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_SolicitudCancelada]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPRegistrar_SolicitudCancelada]
@IdAmigos int
as begin
	update Amigos set FechaRespuesta=GETDATE()
	where IdAmigos=@IdAmigos
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_SolicitudEnvio]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPRegistrar_SolicitudEnvio]
@IdUsuario int,
@IdUsuario2 int
as begin
	declare @id int
	set @id=(select MAX(IdAmigos)+1 from Amigos)
	if @id is null
		set @id=1
	insert into Amigos values(@id,@IdUsuario,@IdUsuario2,GETDATE(),null,null,0)
	insert into Notificacion values(@IdUsuario2,0,1,0)
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_SolicitudRechazada]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPRegistrar_SolicitudRechazada]
@IdAmigos int
as begin
	update Amigos set FechaRespuesta=GETDATE(),Respuesta=0
	where IdAmigos=@IdAmigos
end
GO
/****** Object:  StoredProcedure [dbo].[SPRegistrar_Usuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[SPRegistrar_Usuario]
@Pais varchar (50),
@Nombre varchar (50),
@Apellidos varchar(50),
@NombreUsuario varchar(50),
@Contraseña varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Genero varchar(50),
@FechaNacimiento datetime,
@FotoPerfil image,
@FotoPortada image,
@RoldeUsuario varchar(50),
@IdUsuarioResultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
as 
begin
	SET @IdUsuarioResultado = 0
	SET @Mensaje = ' '
	declare @paisaux int = (select IdPais from Pais where NombrePais = @Pais)
	if not exists(select * from Usuario Where @Correo = Correo)
	begin 
		insert into Usuario(IdPais,Nombre, Apellidos, NombreUsuario, Contraseña,Correo,Telefono, Genero,FechaCreacion,FechaNacimietno,FotoPerfil,FotoPortada,Estado,RoldeUsuario)
		values (@paisaux,@Nombre,@Apellidos,@NombreUsuario,@Contraseña,@Correo,@Telefono,@Genero,GETDATE(),@FechaNacimiento,@FotoPerfil,@FotoPortada,1,'Usuario')
		set @IdUsuarioResultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El correo ya esta asociado a una cuenta usa otro correo electronico'
end
GO
/****** Object:  StoredProcedure [dbo].[SPValidar_Correo]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPValidar_Correo]
@Correo varchar(50)
as begin
	select*from Usuario where Correo=LTRIM(RTRIM(@Correo))
end
GO
/****** Object:  StoredProcedure [dbo].[SPValidar_NombreUsuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPValidar_NombreUsuario]
@NombreUsuario varchar(50)
as begin
	select*from Usuario where NombreUsuario=LTRIM(RTRIM(@NombreUsuario))
end
GO
/****** Object:  StoredProcedure [dbo].[SPVer_Chat]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPVer_Chat]
@IdUsuario1 int,
@IdUsuario2 int
as begin 
select * from Chat where (IdUsuario1 = @IdUsuario1 and IdUsuario2 = @IdUsuario2) or (IdUsuario1 = @IdUsuario2 and IdUsuario2 = @IdUsuario1)
end
GO
/****** Object:  StoredProcedure [dbo].[SPver_Comentario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPver_Comentario]
@IdPublicacion int
as begin
select IdPublicacion,Usuario.IdUsuario,NombreUsuario,Comentario,FechaComentario,IdComentario from Usuario inner join Comentario on Comentario.IdUsuario = Usuario.IdUsuario
 where IdPublicacion = @IdPublicacion
end
GO
/****** Object:  StoredProcedure [dbo].[SPVer_Mensaje]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPVer_Mensaje]
@IdChat int
as begin 
select NombreUsuario, mensaje from Mensaje inner join Usuario on Mensaje.IdUsuario = Usuario.IdUsuario where IdChat = @IdChat
end 
GO
/****** Object:  StoredProcedure [dbo].[SPVer_reacciones]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPVer_reacciones]
@IdUsuario int,
@IdPublicacion int
as begin 
	if exists(select * from Reacciones where IdPublicacion=@IdPublicacion and IdUsuario=@IdUsuario)
	begin
		select IdReaccion from Reacciones where IdPublicacion = @IdPublicacion and IdUsuario = @IdUsuario
	end
	else
		select '0' as 'IdReaccion'
end 
GO
/****** Object:  StoredProcedure [dbo].[SPVer_reaccionesC]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPVer_reaccionesC]
@IdComentario int
as begin 
		select IdReaccion, NombreUsuario, FotoPerfil from ReaccionesCom inner join Usuario
		on ReaccionesCom.IdUsuario = Usuario.IdUsuario where IdComentario = @IdComentario
end 
GO
/****** Object:  StoredProcedure [dbo].[SPVer_reaccionesCom]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPVer_reaccionesCom]
@IdUsuario int,
@IdComentario int
as begin 
	if exists(select * from ReaccionesCom where IdComentario=@IdComentario and IdUsuario=@IdUsuario)
	begin
		select IdReaccion from ReaccionesCom where IdComentario = @IdComentario and IdUsuario = @IdUsuario
	end
	else
		select '0' as 'IdReaccion'
end 
GO
/****** Object:  StoredProcedure [dbo].[SPVer_reaccionesP]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPVer_reaccionesP]
@IdPublicacion int
as begin 
		select IdReaccion, NombreUsuario, FotoPerfil from Reacciones inner join Usuario
		on Reacciones.IdUsuario = Usuario.IdUsuario where IdPublicacion = @IdPublicacion
end 
GO
/****** Object:  StoredProcedure [dbo].[SPVer_Usuario]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPVer_Usuario]
@IdUsuario int
as begin 
		select nombre, Apellidos from Usuario where IdUsuario = @IdUsuario
end 
GO
/****** Object:  StoredProcedure [dbo].[SPVer_Usuario_Alterno]    Script Date: 06/06/2022 19:28:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPVer_Usuario_Alterno]
@IdUsuario int
as begin 
		select nombre, Apellidos, Correo, Telefono, FotoPerfil, Genero, NombreUsuario, Contraseña, FechaNacimietno, FotoPortada from Usuario where IdUsuario = @IdUsuario
end 
GO
USE [master]
GO
ALTER DATABASE [db_a86310_adminpanal] SET  READ_WRITE 
GO
