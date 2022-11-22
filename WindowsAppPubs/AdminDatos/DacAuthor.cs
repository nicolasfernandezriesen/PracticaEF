using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        public static PubsContext context = new PubsContext();

        public static List<Author> Listar()
        {
            List<Author> authors = context.Authors.ToList();
           
            return authors;
        }
        public static Author TraerUno(string id)
        {
            Author author = context.Authors.Find(id);

            return author;
        }
        public static int Nuevo(Author author)
        {
            context.Authors.Add(author);
            
            int filasAfectadas = context.SaveChanges();

            return filasAfectadas;
        }
        public static int Modificar(Author author)
        {
            int filasAfectadas = 0;

            Author DbAuthor = context.Authors.Find(author.au_id);

            if (DbAuthor != null)
            {
                DbAuthor.au_lname= author.au_lname;
                DbAuthor.au_fname= author.au_fname;
                DbAuthor.phone= author.phone;
                DbAuthor.address= author.address;
                DbAuthor.city= author.city;
                DbAuthor.state= author.state;
                DbAuthor.zip= author.zip;
                DbAuthor.contract= author.contract;
                filasAfectadas = context.SaveChanges();
            }

            return filasAfectadas;
        }
        public static int Eliminar(Author author)
        {
            int filasAfectadas =0;

            if (author != null )
            {
                context.Authors.Remove(author);
                filasAfectadas = context.SaveChanges();
            }
            
            return filasAfectadas;
        }
    }
}
