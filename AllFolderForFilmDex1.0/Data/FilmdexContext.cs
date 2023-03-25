using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data
{
    /// <summary>
    /// Represents the database context for the Filmdex application.
    /// </summary>
    public class FilmdexContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the FilmdexContext class with the connection string "FilmdexContext".
        /// </summary>
        public FilmdexContext() : base("name=FilmdexContext")
        {

        }
        /// <summary>
        /// Gets or sets the collection of films in the database.
        /// </summary>
        public DbSet<Film> Film { get; set; }
    }
}
