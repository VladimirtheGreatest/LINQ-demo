using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqdemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //random number generator
            int[] randomNum = new int[1000];
            Random RandomNumber = new Random();
            List<int> termsList = new List<int>();


            for (int i = 0; i < 1000; i++)
            {
                randomNum[i] = RandomNumber.Next(1, 1000);
            }


            foreach (int j in randomNum)
            {
                termsList.Add(j);
            }

            //termsList.ForEach(i => Console.Write("{0}\t", i));



            //Define the query expression.
            IEnumerable<int> scoreQuery =
                from something in termsList
                where something > 800 && something < 1000
                select something;

            //Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
