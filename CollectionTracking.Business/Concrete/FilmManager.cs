using CollectionTracking.Business.Abstract;
using CollectionTracking.Business.ValidationRules.FluentValidation;
using CollectionTracking.Core.Utilities;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace CollectionTracking.Business.Concrete
{
    public class FilmManager : IFilmService
    {
        private IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        //Ekleme işlemi
        public void Add(Film film)
        {
            ValidationTool.Validate(new FilmValidator(), film); //validasyon işlemi
            _filmDal.Add(film);
        }

        //Silme işlemi
        public void Delete(Film film)
        {
            try
            {
                _filmDal.Delete(film);
            }
            catch
            {
                throw new Exception("Silme başarısız");
            }
        }

        //Tümünü listele
        public List<Film> GetAll()
        {
            return _filmDal.GetList();
        }

        //Search işlemi için manager kodu
        public List<Film> GetFilmsByFilmName(string filmName)
        {
            return _filmDal.GetList(p => p.Name.ToLower().Contains(filmName.ToLower()));
        }

        //Güncelleme işlemi
        public void Update(Film film)
        {
            ValidationTool.Validate(new FilmValidator(), film); //validasyon işlemi
            _filmDal.Update(film);
        }
    }
}
