using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Venta
    {
        public Venta() 
        {
            Id = 0;
            Comentarios = string.Empty;
            IdUsuario = 0;   
        }

        public Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }


        private int Id;
        private string Comentarios;
        private int IdUsuario;
    }
}
