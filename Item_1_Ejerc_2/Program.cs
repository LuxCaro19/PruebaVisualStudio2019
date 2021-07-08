using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibli_Item_1_Ejerc_2;

namespace Item_1_Ejerc_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Departamento_lcaro dep = new Departamento_lcaro();

            dep.add_lcaro(1,"Recursos Humanos",43);
            dep.add_lcaro(2, "Administracion", 82);
            dep.add_lcaro(3, "Logistica", 44);
            dep.add_lcaro(4, "Redes", 23);
            dep.add_lcaro(5, "Atencion", 13);
            dep.add_lcaro(6, "Contaduria", 76);
            dep.add_lcaro(7, "Jefatura", 24);


            Console.WriteLine("----------------EJERCICIO 2------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("AGREGA UN DEPARTAMENTO");
            Console.WriteLine();
            Console.WriteLine("CODIGO");
            int idAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE");
            string nombreAdd = Console.ReadLine();
            Console.WriteLine("CANTIDAD DE TRABAJADORES");
            int trabAdd = int.Parse(Console.ReadLine());

            dep.add_lcaro(idAdd,nombreAdd,trabAdd);

            Console.WriteLine();
            dep.mostrarLista_lcaro();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ELIMINA UN DEPARTAMENTO");
            Console.WriteLine();
            Console.WriteLine("CODIGO");
            int idDelete = int.Parse(Console.ReadLine());

            bool resp_delete= dep.eliminar_lcaro(idDelete);

            if (resp_delete)
            {

                Console.WriteLine("Eliminado");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar");

            }

            Console.WriteLine();

            dep.mostrarLista_lcaro();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("EDITA UN DEPARTAMENTO");
            Console.WriteLine();
            Console.WriteLine("CODIGO");
            int idBusc = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE");
            string nombreNew = Console.ReadLine();
            Console.WriteLine("CANTIDAD DE TRABAJADORES");
            int trabNew = int.Parse(Console.ReadLine());


            bool result_edit = dep.editar_lcaro(idBusc, nombreNew,trabNew);

            if (result_edit)
            {
                Console.WriteLine("Editado");
            }
            else
            {
                Console.WriteLine("No se pudo editar");

            }

            Console.WriteLine();
            dep.mostrarLista_lcaro();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("BUSQUEDA POR LETRA");
            Console.WriteLine();
            var result = dep.buscar_dep_lcaro("C");

            Console.WriteLine();
            dep.mostrarLista_lcaro(result);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("BUSQUEDA POR ID");
            Console.WriteLine();
            Console.WriteLine("ID");
            int busc_id = int.Parse(Console.ReadLine());

            var result_id = dep.buscar_dep_id_lcaro(busc_id);

            Console.WriteLine();
            dep.mostrarLista_lcaro(result_id);

            

            Console.WriteLine();
            Console.WriteLine();
            


            Console.ReadKey();


        }
    }
}
