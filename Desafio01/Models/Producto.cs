using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01.Models
{
    public class Producto
    {
        public Producto()
        {
            Id = 0;
            Descripcion = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
            IdUsuario = 0;

        }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }

        public int Id;
        public string Descripcion;
        public double Costo;
        public double PrecioVenta;
        public int Stock;
        public int IdUsuario;
    }
}
