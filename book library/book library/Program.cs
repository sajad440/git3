using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_library
{
   public class Program 
    {
        static void Main(string[] args)
        {
            Books[] LibraryBooksList = new Books[]
                {
                    new Fictions("spider-man 1","Marvel","action",100),
                    new Fictions("spider-man 2","Marvel","action",80),
                    new Nonfictions("animal farm", "George Orwell","Political satire",92),
                    new Nonfictions("Uncle Tom's Cabin","Harriet Beecher Stowe"," novel",392)
                };


            Library.DisplayBooks(LibraryBooksList);
        }
    }
}
