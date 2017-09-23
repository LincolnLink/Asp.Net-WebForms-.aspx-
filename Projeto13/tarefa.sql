
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