using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1

            //int[] arrayNum = {1, 332, 4};
            //TaskOne.metod(arrayNum);

            SecondTask<int> A = new SecondTask<int>(5);
            Console.WriteLine(A);


            Console.ReadKey();
        }

        
    }

   

}
