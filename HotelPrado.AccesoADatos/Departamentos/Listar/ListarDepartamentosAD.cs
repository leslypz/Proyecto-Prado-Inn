using HotelPrado.Abstracciones.Interfaces.AccesoADatos.Departamentos.Listar;
using HotelPrado.Abstracciones.Modelos.Departamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPrado.AccesoADatos.Departamentos.Listar
{
    public class ListarDepartamentosAD : IListarDepartamentosAD
    {
        Contexto _contexto;

        public ListarDepartamentosAD() 
        { 
        _contexto = new Contexto();
        }

        public List<DepartamentoDTO> Listar() 
        {
            List<DepartamentoDTO> laListaDeDepartamento = (from elDepartamento in _contexto.DepartamentoTabla
                                                           select new DepartamentoDTO {
                                                               IdDepartamento = elDepartamento.IdDepartamento,
                                                               Nombre = elDepartamento.Nombre,
                                                               IdTipoDepartamento = elDepartamento.IdTipoDepartamento,
                                                               Precio = elDepartamento.Precio,
                                                               NumeroHabitaciones = elDepartamento.NumeroHabitaciones,
                                                               Estado = elDepartamento.Estado

                                                           }).ToList();
            return laListaDeDepartamento;
        }
    }
}
