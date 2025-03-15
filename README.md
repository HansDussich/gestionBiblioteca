# Gestion de Biblioteca con ASP.NET MVC

## Script de la base de datos:
  ´´´
  -- Crear base de datos
create database biblioteca;

--creacion tabla autores
create table autores(
	autorId int primary key identity(1,1),
	nombre nvarchar(255) not null
)

--Creacion tabla libros
create table libros(
	id int primary key identity(1,1),
	titulo nvarchar(255) not null,
	autorId int not null,
	constraint fk_libros_autores foreign key (autorId) references Autores(autorId) on delete cascade
)
