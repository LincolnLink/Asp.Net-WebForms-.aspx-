﻿create table Usuario(
	IdUsuario		 integer identity(1,1),
	Nome			 nvarchar(50)	not null,
	[Login]			 nvarchar(25)	not null unique,
	Senha			 nvarchar(50)	not null,
	Foto			 nvarchar(50)	not null unique,
	DataCadastro	 datetime		not	null,
primary key(IdUsuario))
go


create table Tarefa(

IdTarefa			integer				identity(1,1),
NomeTarefa			nvarchar(50)		not null,
DataHora			dateTime			not null,
Descricao			nvarchar(max)		not null,
IdUsuario			integer				not null,
primary key(IdTarefa),
foreign key(IdUsuario) references Usuario(IdUsuario)

)
go