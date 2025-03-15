# Gestion de Biblioteca con ASP.NET MVC


## Modelo Relacional.
![image](https://github.com/user-attachments/assets/1533f164-013a-4824-a89b-0e266232ba6f)


## Script de la base de datos:
  ```bash
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

```
-----------------
# Instrucciones:
1. Abre la terminal:
```bash
git clone https://github.com/HansDussich/gestionBiblioteca
```
2.  ```bash
    cd gestionBiblioteca
    ```
    


------------------
### Index
![image](https://github.com/user-attachments/assets/80180914-01bb-4b85-9b94-12629c54ca82)

### Crear Nuevo Libro
![image](https://github.com/user-attachments/assets/6c7f124b-9e1b-4577-9816-1f514ca65b30)

### Editar Libro
![image](https://github.com/user-attachments/assets/6d5cd908-440c-4f38-8dae-f9e8bf5b43a4)

### Detalles del Libro
![image](https://github.com/user-attachments/assets/b48f58ba-88cf-42df-b0ba-268f893610f9)

### Eliminar Libro
![image](https://github.com/user-attachments/assets/aedafeb5-9aff-4243-bb70-53f1d9fad159)

### Ver Autores
![image](https://github.com/user-attachments/assets/42e7a226-c2ef-4a3a-ad09-b2375b13783e)

### Crear Autor
![image](https://github.com/user-attachments/assets/3881e06c-576e-4e78-a3fd-cf1d89bcef96)

### Editar Autor
![image](https://github.com/user-attachments/assets/97756b84-c4b5-45e5-961f-25c97e0ce457)

### Detalles del Autor
![image](https://github.com/user-attachments/assets/27cfc5f9-9663-4514-b39f-da9bf4a43f71)

### Eliminar Autor
![image](https://github.com/user-attachments/assets/47b2df5c-b5a9-4143-902a-955707673d18)



