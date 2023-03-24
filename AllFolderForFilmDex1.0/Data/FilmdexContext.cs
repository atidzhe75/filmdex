using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data
{
    public class FilmdexContext : DbContext
    {
        public FilmdexContext() : base("name=FilmdexContext")
        {

        }
        public DbSet<Film> Film { get; set; }
    }
}
