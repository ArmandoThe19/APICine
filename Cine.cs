using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APICine.Models
{
    public class Cine
    {
        [Key]
        public required string Id { get; set; }
        public required  string RazonSocial { get; set; }
        public required string Salas { get; set; }
        public required string IdCiudad { get; set; }
        public required string IdDistrito { get; set; }
        public required string Formatos { get; set; }
        public required string Direccion { get; set; }
        public required string Telefonos { get; set; }
        public required string Ciudad { get; set; }
        public required string Distrito { get; set; }
        public required string Formatoss { get; set; }
        public required  List<Pelicula> Peliculas { get; set; }
        public required List<Tarifa> Tarifas { get; set; }
    }

    public class Pelicula
    {
        public required string Titulo { get; set; }
        public required string Horarios { get; set; }
    }

    public class Tarifa
    {
        public required string DiasSemana { get; set; }
        public required string Precio { get; set; }
    }
}