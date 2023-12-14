using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_library
{
    public static class Library
    {
        public static void DisplayBooks(Books[] books)
        {
            foreach (var Boks in books)
            {
                Console.WriteLine("\n-----------------");
                Console.WriteLine($"Name :{Boks.name}");
                
                Console.WriteLine($"\n Author : {Boks.author}");
               
                Console.WriteLine($"\n Topic : {Boks.topic}");
               
                Console.WriteLine($"pages : {Boks.pages}" );
                Console.WriteLine("\n-----------------");
            }
        }
    }
}
