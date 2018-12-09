using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibArtist
{
    public class Artist
    {
        private double price;
        private string artname;
        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
            }
        }
        public string Surname { get; set; }
        public ChooseGenre Genre { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
          public string Artname
        {
            get { return artname; }
            set
            {
                artname = value;
            }
        }
        public Countries Country { get; set; }

        public Artist(Countries country, string artname, ChooseGenre genre, double price, int count)
        {
            Country = country;
            Artname = artname;
            Price = price;
            Genre = genre;
            Count = count;
        }


        public Artist()
        {
            Count = 100;
            Price = 500;
            Artname = "Олексій";
            Surname = "Стокроцький";
        }
        public enum Countries
        {
            Україна,
            Росія,
            США,
            Польша,
            Канада,
            Кита,
            Інша
        }

        public enum ChooseGenre
        {
            Рок,
            Реп,
            Поп,
            Кантрі,
            Блюз,
            Джаз,
            Електро,
            Класика,
            Інший
        }
    }
}
