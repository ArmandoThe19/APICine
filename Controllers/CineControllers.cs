using APICine.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CineController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCine()
        {
            var cine = new Cine
            {
                Id = "1",
                RazonSocial = "Cinestar Excelsior",
                Salas = "8",
                IdCiudad = "2",
                IdDistrito = "4",
                Formatos = "2",
                Direccion = "Jr. De la Unión 780",
                Telefonos = "714-1865",
                Ciudad = "Lima",
                Distrito = "Lima",
                Formatoss = "2D",
                Peliculas = new List<Pelicula>
                {
                    new Pelicula { Titulo = "Locos de Amor 2 (+14)", Horarios = "13:30 / 21:30" },
                    new Pelicula { Titulo = "El Despertar de los Muertos Vivientes (+14) (HD - Doblada)", Horarios = "17:30 / 22:00" },
                    new Pelicula { Titulo = "Pantera Negra", Horarios = "13:30 / 16:00 / 18:45 / 19:15 / 21:20" },
                    new Pelicula { Titulo = "El cavernícola", Horarios = "13:30 / 15:15" },
                    new Pelicula { Titulo = "A tu lado", Horarios = "13:15 / 15:15 / 17:15 / 19:15 / 21:15" },
                    new Pelicula { Titulo = "Una Jungla de Locura", Horarios = "13:00 / 15:00 / 17:00 / 19:00 / 21:00" },
                },
                Tarifas = new List<Tarifa>
                {
                    new Tarifa { DiasSemana = "Lunes y Miércoles", Precio = "S/. 5.00" },
                    new Tarifa { DiasSemana = "Martes", Precio = "S/. 4.50" },
                    new Tarifa { DiasSemana = "Jueves y Viernes", Precio = "S/. 7.00" },
                    new Tarifa { DiasSemana = "Sábado, Domingo y Feriados", Precio = "S/. 8.00" },
                    new Tarifa { DiasSemana = "Adulto mayor y niños de 2 hasta 8 años (Jueves a Domingos)", Precio = "S/. 6.00" },
                    new Tarifa { DiasSemana = "3D - Martes", Precio = "S/. 6.00" },
                    new Tarifa { DiasSemana = "3D - Jueves a Domingos", Precio = "S/. 11.00" },
                }
            };

            return Ok(new { success = true, data = cine, message = "Registros encontrados" });
        }
    }
}