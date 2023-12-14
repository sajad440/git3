using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_library
{
    public class Fictions : Books
    {


        public  Fictions(string Name , string Author, string Genres, int Pages) :base(Name,Author,Genres,Pages)
        {

            name = Name;
            author = Author;
            topic = Genres;
            pages = Pages;
            
        }
      
        
    }
}
