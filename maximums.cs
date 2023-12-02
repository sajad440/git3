using System;

namespace git3
{
    class maximums
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter numbers");
            for(int x = 1 ; x<6;i++)
            { System.Console.WriteLine($"enter number {x}");
               var numbers=Convert.ToInt32(Console.ReadLine());
            }
           int[] max =new int[numbers];

        }
        static int maximumNumber(int[max])
        {
            foreach (var item in int[max])
            {
                if(max[0]>max[1]&&max[0]>max[2]&&max[0]>max[3]&&max[0]>max[4])
                {
                    Console.Writeline(max[0]);
                }
            }

        }
    
    }
}
