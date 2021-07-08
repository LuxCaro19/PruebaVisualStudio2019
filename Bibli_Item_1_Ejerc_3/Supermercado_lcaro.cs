using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bibli_Item_1_Ejerc_3
{
    public class Supermercado_lcaro
    {

        Dictionary<int, Supermercado_lcaro> super = new Dictionary<int, Supermercado_lcaro>();

        //el codigo lo dejaré como Key

        public string razon_social_lcaro { get; set; }
        public int cantidad_locales_lcaro { get; set; }
        public DateTime fecha_creacion_lcaro { get; set; }


        public Supermercado_lcaro()
        {

        }

        public Supermercado_lcaro(string razon_social_lcaro, int cantidad_locales_lcaro, DateTime fecha_creacion_lcaro)
        {
            this.razon_social_lcaro = razon_social_lcaro;
            this.cantidad_locales_lcaro = cantidad_locales_lcaro;
            this.fecha_creacion_lcaro = fecha_creacion_lcaro;
        }

        public int generarKey_lcaro()
        {

            if (super.Count > 0)
            {

                return super.Max(x => x.Key) + 1;

            }

            return 1;

        }

        public void add_lcaro(string razon_soc, int cant_local, DateTime fecha)
        {

            Supermercado_lcaro s = new Supermercado_lcaro(razon_soc,cant_local,fecha);

            super.Add(generarKey_lcaro(), s);


        }

        public bool delete_lcaro(int key)
        {

            bool existe = super.ContainsKey(key);

            if (existe)
            {
                super.Remove(key);
            }

            return existe;

        }


        public bool editar_lcaro(int key, string razon_soc, int locales, DateTime fecha)
        {
            bool existe = super.ContainsKey(key);

            if (existe)
            {
                super[key] = new Supermercado_lcaro(razon_soc,locales,fecha);
                return true;
            }


            return false;
        }

        public Dictionary<int, Supermercado_lcaro> listar_lcaro()
        {

            return super;

        }

        public Dictionary<int, Supermercado_lcaro> buscarSuperPorName_lcaro(string nombre)
        {

            Dictionary<int, Supermercado_lcaro> superList = new Dictionary<int, Supermercado_lcaro>();

            foreach (var item in super)
            {

                if (item.Value.razon_social_lcaro.ToLower().Equals(nombre.ToLower()))
                {

                    Supermercado_lcaro s = new Supermercado_lcaro();
                    s = item.Value;

                    superList.Add(item.Key, s);


                }



            }

            return superList;

        }

        public KeyValuePair<int, Supermercado_lcaro> buscarPorKey_lcaro(int key)
        {

            bool existe = super.ContainsKey(key);

            KeyValuePair<int, Supermercado_lcaro> superList = new KeyValuePair<int, Supermercado_lcaro>();

            if (existe)
            {
                superList = super.First(s => s.Key == key);
            }

            return superList;
        }


        public Dictionary<int, Supermercado_lcaro> buscarPorLetra_lcaro(string letra)
        {

            Dictionary<int, Supermercado_lcaro> superList = new Dictionary<int, Supermercado_lcaro>();

            foreach (var item in super)
            {

                if (item.Value.razon_social_lcaro.Contains(letra))
                {

                    Supermercado_lcaro sup = new Supermercado_lcaro();

                    sup = item.Value;
               

                    superList.Add(item.Key, sup);


                }



            }

            return superList;

        }


        public void mostrarLista_lcaro()
        {


            foreach (var item in listar_lcaro())
            {

                Console.WriteLine("{0} || {1} || {2} || {3}", item.Key, item.Value.razon_social_lcaro, item.Value.cantidad_locales_lcaro, item.Value.fecha_creacion_lcaro);

            }

        }

        public void mostrarLista_lcaro(Dictionary<int, Supermercado_lcaro> supermercados)
        {

            foreach (var item in supermercados)
            {

                Console.WriteLine("{0} || {1} || {2} || {3}", item.Key, item.Value.razon_social_lcaro, item.Value.cantidad_locales_lcaro, item.Value.fecha_creacion_lcaro);

            }


        }

    }
}
