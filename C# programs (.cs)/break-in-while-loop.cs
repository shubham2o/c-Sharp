using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
                if (i==4)
                {
                    break;
                }
            }
        }
    }
}





// OUTPUT 
//   0
//   1
//   2
//   3