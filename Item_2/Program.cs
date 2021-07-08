using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item_2.controlador;

namespace Item_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Servicio serv = new Servicio();

            serv.addImpresoras_lcaro("AE345", 1, "HP", 1200, DateTime.Parse("12/10/2018"));
            serv.addImpresoras_lcaro("OO3OOO", 2, "ACER", 430, DateTime.Parse("14/11/2018"));
            serv.addImpresoras_lcaro("AAWASD", 3, "CANON", 920, DateTime.Parse("02/11/2020"));
            serv.addImpresoras_lcaro("R2D2", 4, "LINK", 758, DateTime.Parse("22/09/2018"));
            serv.addImpresoras_lcaro("RVD", 5, "NONSCOPE", 2300, DateTime.Parse("30/03/2019"));
            serv.addImpresoras_lcaro("Y2J", 6, "XEROX", 991, DateTime.Parse("20/04/2019"));
            serv.addImpresoras_lcaro("55255", 1, "BROTHER", 2, DateTime.Parse("02/02/2020"));


            Console.WriteLine("LISTAA");
            serv.mostrarLista_lcaro();
            Console.WriteLine("END LISTA");

            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("CONSULTA 1");
            Console.WriteLine();
            var result1 = serv.selectCodigo_lcaro("AE345");

            Console.WriteLine();

            serv.mostrarLista_lcaro(result1);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("CONSULTA 2");
            Console.WriteLine();
            var result2 = serv.selectRango_lcaro(700,1000);

            Console.WriteLine();
            serv.mostrarLista_lcaro(result2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CONSULTA 3");
            Console.WriteLine();
            var result3 = serv.selectLike_lcaro("H");

            Console.WriteLine();
            serv.mostrarLista_lcaro(result3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CONSULTA 4");
            Console.WriteLine();
            var result4 = serv.selectJoin_lcaro("Aaw");

            Console.WriteLine();

            foreach (var item in result4)
            {

                Console.WriteLine("{0} || {1} || {2}", item.codigo_lcaro,item.fecha_lcaro,item.nombreMarca_lcaro);

            }


            Console.ReadKey();
        }
    }
}
