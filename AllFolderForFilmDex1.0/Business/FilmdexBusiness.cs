using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    /// <summary>
    /// Business logic layer for the Filmdex application.
    /// </summary>
    public class FilmdexBusiness
    {
        private FilmdexContext filmdexContext;
        /// <summary>
        /// Returns a list of all films in the database.
        /// </summary>
        /// <returns>A list of Film objects.</returns>
        public List<Film> GetAllFilms()
        {
            using (filmdexContext = new FilmdexContext())
            {

                return filmdexContext.Film.ToList();
            }
                
        }
        /// <summary>
        /// Returns a Film object with the specified id.
        /// </summary>
        /// <param name="id">The id of the Film object to retrieve.</param>
        /// <returns>A Film object.</returns>
        public Film GetFilm(int id)
        {
            using (filmdexContext = new FilmdexContext())
            {
                return filmdexContext.Film.Find(id);
            }
        }
        /// <summary>
        /// Adds a new Film object to the database.
        /// </summary>
        /// <param name="film">The Film object to add.</param>
        public void AddFilm(Film film)
        {
            using (filmdexContext = new FilmdexContext())
            {
                    filmdexContext.Film.Add(film);
                    filmdexContext.SaveChanges();
            }
        }
        /// <summary>
        /// Updates an existing Film object in the database.
        /// </summary>
        /// <param name="film">The Film object to update.</param>
        public void UpdateFilm(Film film)
        {
            using (filmdexContext = new FilmdexContext())
            {
                var item = filmdexContext.Film.Find(film.Id);
                if (item != null)
                {
                    filmdexContext.Entry(item).CurrentValues.SetValues(film);
                    filmdexContext.SaveChanges();
                }

            }
        }
        /// <summary>
        /// Deletes a Film object with the specified id from the database.
        /// </summary>
        /// <param name="id">The id of the Film object to delete.</param>
        public void DeleteFilm(int id)
        {
            using (filmdexContext = new FilmdexContext())
            {
                var film = filmdexContext.Film.Find(id);
                if (film != null)
                {
                    filmdexContext.Film.Remove(film);
                    filmdexContext.SaveChanges();
                }
            }
        }
    }
}
