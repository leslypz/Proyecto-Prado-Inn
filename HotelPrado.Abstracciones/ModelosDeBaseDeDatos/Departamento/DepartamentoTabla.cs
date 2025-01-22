using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPrado.Abstracciones.ModelosDeBaseDeDatos.Departamento
{
    [Table("Departamento")]

    public class DepartamentoTabla
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
