using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibli_Item_1_Ejerc_1
{
    public class Empresa_lcaro
    {


        private List<Empresa_lcaro> emp = new List<Empresa_lcaro>();

        public string rut_lcaro { get; set; }

        public string razon_social_lcaro { get; set; }

        public int cantidad_socios_lcaro { get; set; }

        public DateTime fecha_creacion_lcaro { get; set; }


        public Empresa_lcaro()
        {

        }

        public Empresa_lcaro(string rut_lcaro, string razon_social_lcaro, int cantidad_socios_lcaro, DateTime fecha_creacion_lcaro)
        {
            this.rut_lcaro = rut_lcaro;
            this.razon_social_lcaro = razon_social_lcaro;
            this.cantidad_socios_lcaro = cantidad_socios_lcaro;
            this.fecha_creacion_lcaro = fecha_creacion_lcaro;
        }


        public void add_lcaro(string rut, string razon_social, int cant_socios, DateTime fecha_creacion)
        {

            Empresa_lcaro empresa = new Empresa_lcaro(rut, razon_social, cant_socios, fecha_creacion);

            emp.Add(empresa);

        }

        public bool eliminar_lcaro(string rut)
        {

            try
            {


                int remove = emp.RemoveAll(e=>e.rut_lcaro == rut);

                return remove > 0;

            }
            catch (Exception)
            {


                return false;

            }

        }

        public bool editar_lcaro(string rut,string newRut, string newRazon_social, int newCant_socios, DateTime newFecha_creacion)
        {


            try
            {

                int pos = emp.FindIndex(e => e.rut_lcaro == rut);

                emp[pos].rut_lcaro = newRut;
                emp[pos].razon_social_lcaro = newRazon_social;
                emp[pos].cantidad_socios_lcaro = newCant_socios;
                emp[pos].fecha_creacion_lcaro = newFecha_creacion;

                return true;

            }
            catch (Exception)
            {

                return false;
            }


        }

        public List<Empresa_lcaro> listar_lcaro()
        {

            return emp;

        }


        public List<Empresa_lcaro> buscarYear_lcaro(string desde, string hasta)
        {

            try
            {


                var result = emp.FindAll(e => e.fecha_creacion_lcaro>=DateTime.Parse(desde) && e.fecha_creacion_lcaro<=DateTime.Parse(hasta));

                return result;
                

            }
            catch (Exception)
            {

                return null;

            }

        }


        public List<Empresa_lcaro> buscarSocios_lcaro(int desde)
        {

            try
            {


                var result = emp.FindAll(e => e.cantidad_socios_lcaro>desde);

                return result;

            }
            catch (Exception)
            {


                return null;

            }

        }




        public void mostrarLista_lcaro()
        {

            foreach (var items in listar_lcaro())
            {

                Console.WriteLine("{0} || {1} || {2} || {3}", items.rut_lcaro, items.razon_social_lcaro, items.cantidad_socios_lcaro, items.fecha_creacion_lcaro);

            }


        }


        public void mostrarLista_lcaro(List<Empresa_lcaro> empresas)
        {

            foreach (var items in empresas)
            {

                Console.WriteLine("{0} || {1} || {2} || {3}", items.rut_lcaro, items.razon_social_lcaro, items.cantidad_socios_lcaro, items.fecha_creacion_lcaro);

            }


        }


    }
}
