using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT
{

    public class Producto
    {
        public long Id { get; set; }
        public string Descripciones { get; set; }
        public string Costo { get; set; }
        public string PrecioVenta { get; set; }
        public string Stock { get; set; }
        public string IdUsuario { get; set; }

    }
}
