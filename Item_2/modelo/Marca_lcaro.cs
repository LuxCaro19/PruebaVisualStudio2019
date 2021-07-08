using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_2.modelo
{
    public class Marca_lcaro
    {

        public int codigo { get; set; }
        public string nombre { get; set; }

        public Marca_lcaro()
        {

        }

        public Marca_lcaro(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
