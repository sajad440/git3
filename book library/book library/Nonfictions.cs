using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_library
{
  public class Nonfictions : Books
    {
        public Nonfictions(string Name , string Author ,string Topic,int Pages) : base(Name,Author,Topic,Pages)
        {
            name = Name;
            author = Author;
            topic = Topic;
            pages = Pages;
        }

    }
}
