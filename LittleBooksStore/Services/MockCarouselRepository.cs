using LittleBooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBooksStore.Services
{
    public class MockCarouselRepository : IRepository<Carousel>
    {
        List<Carousel> _caroucel;

        public bool Add(Carousel item)
        {
            try
            {
                var Carousel = item;
                Carousel.Id = _caroucel.Max(c => c.Id) + 1;
                _caroucel.Add(Carousel);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Carousel item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Carousel item)
        {
            throw new NotImplementedException();
        }

        public Carousel Get(int id)
        {
            return _caroucel.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Carousel> GetAll()
        {
            return _caroucel.ToList();
        }



        public MockCarouselRepository()
        {
            _caroucel = new List<Carousel>();

            _caroucel.Add(new Carousel()
            {
                Id = 1, 
                Title = "Discount Book",
                Description = "Discount books get them all",
                ImageURL = "b1.png"
            });

            _caroucel.Add(new Carousel()
            {
                Id = 2,
                Title = "New Book",
                Description = "All brand new books",
                ImageURL = "b2.png"
            });

            _caroucel.Add(new Carousel()
            {
                Id = 3,
                Title = "Sunscription",
                Description = "Discount on monthly Sunscription",
                ImageURL = "b3.png"
            });

        }
    }
}
