using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;
using System.Data.Entity;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaContext : DbContext
    {
        public DBEscuelaContext() : base("keyDBEscuela") { }
    }
}
