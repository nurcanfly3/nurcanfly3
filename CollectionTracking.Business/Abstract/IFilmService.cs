using CollectionTracking.Entities.Concrete;
using System.Collections.Generic;

namespace CollectionTracking.Business.Abstract
{
    public interface IFilmService
    {
        List<Film> GetAll();

        //Search işlemi için service kısmı
        List<Film> GetFilmsByFilmName(string filmName);

        void Add(Film film);
        void Update(Film film);
        void Delete(Film film);
    }
}
