using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_library
{
    public class Books
    {
        
        public string name, author, topic;
        public int pages;
        public Books(string Name , string Author,string Topic, int Pages)
        {
            name = Name;
            author = Author;
            topic = Topic;
            pages = Pages;
        }
       
    }
}
