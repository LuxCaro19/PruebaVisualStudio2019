using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_2.modelo
{
    public class Impresora_lcaro
    {

        public string codigo_lcaro { get; set; }
        public Marca_lcaro marca_lcaro { get; set; }
        public int stock_lcaro { get; set; }
        public DateTime fecha_lcaro { get; set; }

        public Impresora_lcaro()
        {

        }

        public Impresora_lcaro(string codigo_lcaro, Marca_lcaro marca_lcaro, int stock_lcaro, DateTime fecha_lcaro)
        {
            this.codigo_lcaro = codigo_lcaro;
            this.marca_lcaro = marca_lcaro;
            this.stock_lcaro = stock_lcaro;
            this.fecha_lcaro = fecha_lcaro;
        }
    }
}
