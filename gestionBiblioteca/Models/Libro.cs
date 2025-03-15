using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionBiblioteca.Models;


public class Libro
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El título es obligatorio.")]
    public string Titulo { get; set; } = null!;

    [Required(ErrorMessage = "Debes seleccionar un autor.")]
    [ForeignKey("Autor")]  // Indica que esta es la clave foránea
    public int AutorId { get; set; }

    public virtual Autor? Autor { get; set; } // Permitir null para evitar validación forzada
}