using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibli_Item_1_Ejerc_2
{
    public class Departamento_lcaro
    {

        private List<Departamento_lcaro> dep = new List<Departamento_lcaro>();

        public int codigo_lcaro { get; set; }

        public string nombre_lcaro { get; set; }

        public int cantidad_trabajadores_lcaro { get; set; }


        public Departamento_lcaro()
        {

        }

        public Departamento_lcaro(int codigo_lcaro, string nombre_lcaro, int cantidad_trabajadores_lcaro)
        {
            this.codigo_lcaro = codigo_lcaro;
            this.nombre_lcaro = nombre_lcaro;
            this.cantidad_trabajadores_lcaro = cantidad_trabajadores_lcaro;
        }


        public void add_lcaro(int codigo, string nombre, int cant_trabajadores)
        {

            Departamento_lcaro depa = new Departamento_lcaro(codigo, nombre,cant_trabajadores);

            dep.Add(depa);

        }

        public bool eliminar_lcaro(int codigo)
        {

            try
            {


                int remove = dep.RemoveAll(d => d.codigo_lcaro == codigo);

                return remove > 0;

            }
            catch (Exception)
            {


                return false;

            }

        }

        public bool editar_lcaro(int codigo, string newNombre, int newCant_trabajadores)
        {


            try
            {

                int pos = dep.FindIndex(d => d.codigo_lcaro == codigo);


                dep[pos].nombre_lcaro = newNombre;
                dep[pos].cantidad_trabajadores_lcaro = newCant_trabajadores;

                return true;

            }
            catch (Exception)
            {

                return false;
            }


        }

        public List<Departamento_lcaro> listar_lcaro()
        {

            return dep;

        }

        public List<Departamento_lcaro> buscar_dep_lcaro(string letra)
        {

            try
            {

                var result = dep.FindAll(d=>d.nombre_lcaro.ToLower().StartsWith(letra.ToLower()));

                return result;

            }
            catch (Exception)
            {


                return null;

            }



        }

        public List<Departamento_lcaro> buscar_dep_id_lcaro(int id)
        {

            try
            {

                var result = dep.FindAll(d => d.codigo_lcaro==id);

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

                Console.WriteLine("{0} || {1} || {2}", items.codigo_lcaro, items.nombre_lcaro, items.cantidad_trabajadores_lcaro);

            }


        }


        public void mostrarLista_lcaro(List<Departamento_lcaro> departments)
        {

            foreach (var items in departments)
            {

                Console.WriteLine("{0} || {1} || {2}", items.codigo_lcaro, items.nombre_lcaro, items.cantidad_trabajadores_lcaro);
            }


        }

    }
}
