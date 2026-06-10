using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Entidades.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int CategoriaId { get; set; }

        public int SuplidorId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public bool Activo { get; set; }

    }
}
