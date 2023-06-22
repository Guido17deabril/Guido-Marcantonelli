using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;
            Mail = string.Empty;

        }
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Mail = mail;
        }

        public int Id;
        public string Nombre;
        public string Apellido;
        public string NombreUsuario;
        public string Contraseña;
        public string Mail;

    }
}
