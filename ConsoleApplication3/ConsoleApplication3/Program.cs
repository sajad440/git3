using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = new int[6] ;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("enter number"+ i );
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            maximumNumber(numbers);
        }
        static void maximumNumber(int[] numbers)
        {

            if (numbers[0] > numbers[1] && numbers[0] > numbers[2] && numbers[0] > numbers[3] && numbers[0] > numbers[4])
            {
                Console.WriteLine("maximum nuber is :" + numbers[0]);
            } else if (numbers[1] > numbers[0] && numbers[1] > numbers[2] && numbers[2] > numbers[3] && numbers[3] > numbers[4])
            {
                Console.WriteLine("maximum nuber is :" + numbers[1]);
            } else if (numbers[2] > numbers[0] && numbers[2] > numbers[1] && numbers[2] > numbers[3] && numbers[2] > numbers[4])
            { Console.WriteLine("maximum nuber is :" + numbers[2]); }
            else if (numbers[3] > numbers[0] && numbers[3] > numbers[1] && numbers[3] > numbers[2] && numbers[3] > numbers[4])
            { Console.WriteLine("maximum nuber is :" + numbers[3]); }
            else if (numbers[4] > numbers[0] && numbers[4] > numbers[1] && numbers[4] > numbers[2] && numbers[4] > numbers[3])
            {
                Console.WriteLine("maximum nuber is :" + numbers[4]);
            }
            else { Console.WriteLine("error . please enter number correct"); }


        }
    }
}
