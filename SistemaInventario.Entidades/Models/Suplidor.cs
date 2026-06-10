using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Entidades.Models
{
    public class Suplidor
    {
        public int Id { get; set; }

        public string NombreEmpresa { get; set; }

        public string NombreContacto { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string SitioWeb { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public bool Activo { get; set; }

    }
}
