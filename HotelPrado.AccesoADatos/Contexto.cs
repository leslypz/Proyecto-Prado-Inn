using HotelPrado.Abstracciones.ModelosDeBaseDeDatos.Departamento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPrado.AccesoADatos
{
    public class Contexto : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartamentoTabla>().ToTable("Departamento");
        }
        public DbSet<DepartamentoTabla> DepartamentoTabla { get; set; }


    }
}
