using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        public static PubsContext context = new PubsContext();

        public static List<Store> Listar()
        {
            List<Store> lista = context.Stores.ToList();

            return lista;
        }
        public static Store TraerUno(string id)
        {
            Store store = context.Stores.Find(id);

            return store;
        }
        public static int Nuevo(Store store)
        {
            context.Stores.Add(store);

            int filasAfectadas = context.SaveChanges();

            return filasAfectadas;
        }
        public static int Modificar(Store store)
        {
            Store storeDB = context.Stores.Find(store.stor_id);
            int filasAfectadas = 0;

            if (storeDB != null)
            {
                storeDB.stor_id = store.stor_id;
                storeDB.stor_name = store.stor_name;
                storeDB.stor_address = store.stor_address;
                storeDB.city = store.city;
                storeDB.state = store.state;
                storeDB.zip = store.zip;
                filasAfectadas = context.SaveChanges();
            }

            return filasAfectadas;
        }
        public static int Eliminar(Store store)
        {
            int filasAfectadas = 0;

            if (store != null)
            {
                context.Stores.Remove(store);
                filasAfectadas = context.SaveChanges();
            }

            return filasAfectadas;
        }
    }
}
