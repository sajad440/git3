using System;

namespace git3
{
    class ppower
    
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter number :");
            var number = Convert.ToInt32(Console.ReadLine());
             System.Console.WriteLine("enter power :");
            var power = Convert.ToInt32(Console.ReadLine());
            var result =P0ower(number , power);
            System.Console.WriteLine(result);



        }

        static int P0ower(int number , int power )
        {
            int result = 1 ; 
            for (int i = 0  ; i < power ; i++)
            {
                result*=number ;
           
            }
          return result ;
        }
    }
}
