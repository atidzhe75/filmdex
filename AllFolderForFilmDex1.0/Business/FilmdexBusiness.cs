using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class FilmdexBusiness
    {
        private FilmdexContext filmdexContext;

        public List<Film> GetAllFilms()
        {
            using (filmdexContext = new FilmdexContext())
            {

                return filmdexContext.Film.ToList();
            }
                
        }

        public Film GetFilm(int id)
        {
            using (filmdexContext = new FilmdexContext())
            {
                return filmdexContext.Film.Find(id);
            }
        }

        public void AddFilm(Film film)
        {
            using (filmdexContext = new FilmdexContext())
            {
                    filmdexContext.Film.Add(film);
                    filmdexContext.SaveChanges();
            }
        }

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
