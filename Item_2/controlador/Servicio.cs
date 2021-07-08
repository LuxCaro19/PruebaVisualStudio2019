using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item_2.modelo;
using Item_2.modelo.viewModel;

namespace Item_2.controlador
{
    public class Servicio
    {


        private List<Impresora_lcaro> imp = new List<Impresora_lcaro>();
        private List<Marca_lcaro> marc = new List<Marca_lcaro>();


        public void addImpresoras_lcaro(string codigo, int marcaID, string marcaNombre, int stock, DateTime fecha)
        {

            Marca_lcaro mar = new Marca_lcaro(marcaID,marcaNombre);

            Impresora_lcaro im = new Impresora_lcaro(codigo, mar, stock,fecha);


            imp.Add(im);
            marc.Add(mar);
            


        }

        public List<Impresora_lcaro> selectCodigo_lcaro(string codigo)
        {
            var result = from i in imp
                         where i.codigo_lcaro.Equals(codigo)
                         select i;

            return result.ToList();


        }

        public List<Impresora_lcaro> selectRango_lcaro(int desde, int hasta)
        {

            try
            {
                var result = from i in imp
                             where i.stock_lcaro >= desde && i.stock_lcaro <= hasta
                             select i;

                return result.ToList();


            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Impresora_lcaro> selectLike_lcaro(string letra)
        {

            var result = from i in imp
                         where i.marca_lcaro.nombre.ToLower().StartsWith(letra.ToLower())
                         select i;

            return result.ToList();

        }

        public List<vmMarcaImpresora_lcaro> selectJoin_lcaro(string codigo)
        {

            var result = from i in imp
                         join m in marc
                         on i.marca_lcaro.codigo equals m.codigo
                         where i.codigo_lcaro.ToLower().Contains(codigo.ToLower())
                         select new vmMarcaImpresora_lcaro
                         {

                             codigo_lcaro = i.codigo_lcaro,
                             fecha_lcaro = i.fecha_lcaro,
                             nombreMarca_lcaro = m.nombre
                             

                         };


            return result.ToList();

        }





        public List<Impresora_lcaro> listarImpresoras_lcaro()
        {

            return imp;


        }


        public void mostrarLista_lcaro()
        {

            foreach (var items in listarImpresoras_lcaro())
            {

                Console.WriteLine("{0} || {1} || {2} || {3}", items.codigo_lcaro, items.marca_lcaro.nombre, items.stock_lcaro, items.fecha_lcaro);

            }


        }

        public void mostrarLista_lcaro(List<Impresora_lcaro> impresoras)
        {

            foreach (var items in impresoras)
            {

                Console.WriteLine("{0} || {1} || {2} || {3}", items.codigo_lcaro, items.marca_lcaro.nombre, items.stock_lcaro, items.fecha_lcaro);

            }


        }






    }
}
