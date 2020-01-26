using ClassLibrary;
using ClassLibrary.Models;
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


            List<PeopleModel> employees = People.LoadData();

            employees = employees.OrderBy(x => x.Age).ToList();


            for (int i = 0; i < 1000; i++)
            {
                randomNum[i] = RandomNumber.Next(1, 1000);
            }


            foreach (int j in randomNum)
            {
                termsList.Add(j);
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.Surname} {employee.Age} {employee.Id}");
            }





            //termsList.ForEach(i => Console.Write("{0}\t", i));




            //Define the query expression.
            IEnumerable<int> scoreQuery =
                from something in termsList
                where something > 800 && something < 1000
                orderby something ascending
                select something;



            //Execute the query.
            //foreach (int i in scoreQuery)
            //{
            //    Console.Write(i + " ");
            //}


           // termsList.ForEach(i => Console.WriteLine(i + " "));
            Console.ReadLine();
        }
    }
}
