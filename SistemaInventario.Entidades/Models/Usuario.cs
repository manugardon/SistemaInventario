using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Entidades.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string UsuarioNombre { get; set; }

        public string Clave { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Activo { get; set; }

    }
}
