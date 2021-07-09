using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibli_Item_1_Ejerc_1;

namespace Item_1_Ejerc_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Empresa_lcaro emp = new Empresa_lcaro();

            emp.add_lcaro("1-1","Lider",540,DateTime.Parse("20/04/2001"));
            emp.add_lcaro("1-2", "StrongStyle", 2310, DateTime.Parse("21/07/2005"));
            emp.add_lcaro("1-3", "Otaku Store", 40, DateTime.Parse("30/10/2018"));
            emp.add_lcaro("1-4", "McDonalds", 13400, DateTime.Parse("11/11/1982"));
            emp.add_lcaro("1-5", "Adidas", 11540, DateTime.Parse("20/03/1984"));
            emp.add_lcaro("1-6", "Venta de utiles", 33, DateTime.Parse("13/08/2008"));
            emp.add_lcaro("1-7", "Unimarc", 540, DateTime.Parse("21/02/2002"));
            emp.add_lcaro("1-8", "shaa", 45, DateTime.Parse("23/02/2021"));



            Console.WriteLine("---------------EJERCICIO 1----------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("AGREGA UNA EMPRESA");
            Console.WriteLine();
            Console.WriteLine("RUT");
            string rutAdd = Console.ReadLine();
            Console.WriteLine("RAZON SOCIAL");
            string razon_socAdd = Console.ReadLine();
            Console.WriteLine("CANTIDAD DE SOCIOS");
            int cant_sociosAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("FECHA FORMATO(DD/MM/AAAA)");
            DateTime fechaAdd = DateTime.Parse(Console.ReadLine());



            emp.add_lcaro(rutAdd,razon_socAdd,cant_sociosAdd,fechaAdd);
            emp.mostrarLista_lcaro();


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("ELIMINA UNA EMPRESA");
            Console.WriteLine();

            Console.WriteLine("RUT");
            string rutDelete = Console.ReadLine();

            bool value_delete = emp.eliminar_lcaro(rutDelete);

            if (value_delete)
            {

                Console.WriteLine("Eliminado");

            }
            else
            {
                Console.WriteLine("Hubo un error");

            }

            emp.mostrarLista_lcaro();

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("EDITA UNA EMPRESA");
            Console.WriteLine();
            Console.WriteLine("RUT");
            string rutBusc = Console.ReadLine();
            Console.WriteLine("NEW RUT");
            string rutNew = Console.ReadLine();
            Console.WriteLine("NEW RAZON SOCIAL");
            string newRazon_soc = Console.ReadLine();
            Console.WriteLine("NEW CANTIDAD DE SOCIOS");
            int newCantidad_soc = int.Parse(Console.ReadLine());
            Console.WriteLine("FECHA FORMATO(DD/MM/AAAA)");
            DateTime newfecha = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            bool value_edit=emp.editar_lcaro(rutBusc,rutNew,newRazon_soc,newCantidad_soc,newfecha);
            

            if (value_edit)
            {

                Console.WriteLine("Editado");

            }
            else
            {

                Console.WriteLine("No se pudo editar");

            }

            emp.mostrarLista_lcaro();

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("BUSCA POR RANGOS DE FECHA");

          
            Console.WriteLine();

            var result = emp.buscarYear_lcaro("01/01/2000","31/12/2020");

            emp.mostrarLista_lcaro(result);

            

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("BUSCA POR SOCIOS");


            Console.WriteLine();

            var result_soc = emp.buscarSocios_lcaro(200);

            emp.mostrarLista_lcaro(result_soc);



            Console.WriteLine();
            Console.WriteLine();



            Console.ReadKey();




        }
    }
}
