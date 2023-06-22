using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01.Models
{
    public class Venta
    {
        public Venta()
        {
            Id = 0;
            Comentarios = string.Empty;
            CantidadVentas = 0;
        }

        public Venta(int id, string comentarios, int cantidadVentas)
        {
            Id = id;
            Comentarios = comentarios;
            CantidadVentas = cantidadVentas;
        }


        public int Id;
        public string Comentarios;
        public int CantidadVentas;
    }
}
