using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibli_Item_1_Ejerc_3;

namespace Item_1_Ejerc_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Supermercado_lcaro su = new Supermercado_lcaro();

            su.add_lcaro("Lider",22,DateTime.Parse("14/02/2019"));
            su.add_lcaro("waSted", 32, DateTime.Parse("11/04/2001"));
            su.add_lcaro("Starken", 11, DateTime.Parse("14/12/2009"));
            su.add_lcaro("laSes", 2, DateTime.Parse("02/02/2019"));
            su.add_lcaro("Word", 3, DateTime.Parse("22/12/1999"));
            su.add_lcaro("Dinamo", 8, DateTime.Parse("09/09/2013"));
            su.add_lcaro("Stone", 22, DateTime.Parse("14/02/2011"));



            Console.WriteLine("---------------EJERCICIO 3----------------");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("CREA UN SUPERMERCADO");
            Console.WriteLine();
            Console.WriteLine("RAZON SOCIAL");
            string razonAdd = Console.ReadLine();
            Console.WriteLine("CANTIDAD DE LOCALES");
            int cant_locAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("FECHA FORMATO(DD/MM/AAAA)");
            DateTime fechaAdd = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            su.add_lcaro(razonAdd,cant_locAdd,fechaAdd);

            Console.WriteLine();

            su.mostrarLista_lcaro();

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("ELIMINA UN SUPERMERCADO");
            Console.WriteLine();
            Console.WriteLine("ID");
            int keyBuscDelete = int.Parse(Console.ReadLine());

            bool respDelete = su.delete_lcaro(keyBuscDelete);

            if (respDelete)
            {
                Console.WriteLine("Eliminado");
            }
            else
            {

                Console.WriteLine("No se pudo eliminar");
            }

            Console.WriteLine();
            su.mostrarLista_lcaro();
            Console.WriteLine();


            Console.WriteLine("EDITA UN SUPERMERCADO");
            Console.WriteLine();
            Console.WriteLine("ID");
            int keyBusc = int.Parse(Console.ReadLine());
            Console.WriteLine("RAZON SOCIAL");
            string razonEdit = Console.ReadLine();
            Console.WriteLine("CANTIDAD DE LOCALES");
            int cant_locEdit = int.Parse(Console.ReadLine());
            Console.WriteLine("FECHA FORMATO(DD/MM/AAAA)");
            DateTime fechaEdit = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            bool respEdit = su.editar_lcaro(keyBusc,razonEdit,cant_locEdit,fechaEdit);

            if (respEdit)
            {

                Console.WriteLine("Editado");
            }
            else
            {

                Console.WriteLine("No se pudo editar");


            }

            Console.WriteLine();
            su.mostrarLista_lcaro();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("BUSCAR POR NOMBRE");
            Console.WriteLine();
            Console.WriteLine("NOMBRE");
            string nombre = Console.ReadLine();

            var result = su.buscarSuperPorName_lcaro(nombre);

            Console.WriteLine();
            su.mostrarLista_lcaro(result);

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("BUSCAR POR KEY");
            Console.WriteLine();
            Console.WriteLine("KEY");
            int key = int.Parse(Console.ReadLine());
            var list= su.buscarPorKey_lcaro(key);
            Console.WriteLine();
            Console.WriteLine("{0} || {1} || {2} || {3}", list.Key, list.Value.razon_social_lcaro, list.Value.cantidad_locales_lcaro,list.Value.fecha_creacion_lcaro);


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("BUSCAR POR LETRA");
            Console.WriteLine();

            var result2 = su.buscarPorLetra_lcaro("S");

            su.mostrarLista_lcaro(result2);


            Console.ReadKey();


        }
    }
}
