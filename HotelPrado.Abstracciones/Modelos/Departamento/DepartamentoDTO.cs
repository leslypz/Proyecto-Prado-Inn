using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPrado.Abstracciones.Modelos.Departamento
{
    public class DepartamentoDTO
    {
        [Key]
        public int IdDepartamento { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int IdTipoDepartamento { get; set; }
        public decimal Precio { get; set; }
        public int NumeroHabitaciones { get; set; }
        public bool Estado { get; set; }

    }
}
