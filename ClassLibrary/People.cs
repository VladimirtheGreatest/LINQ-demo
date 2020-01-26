using ClassLibrary.Helpers;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class People
    {
        public static List<PeopleModel> LoadData()
        {
            List<PeopleModel> ListOfEmployees = new List<PeopleModel>();
            Random rnd = new Random();


            for (int i = 0; i < 1000; i++)
            {
               ListOfEmployees.Add(new PeopleModel { FirstName = Guid.NewGuid().ToString("n").Substring(0, 8), Surname = Guid.NewGuid().ToString("n").Substring(0, 8), Age = rnd.Next(18, 80), Occupation = "developer", Id = Guid.NewGuid() } );
            }


            return ListOfEmployees;
        }
    }
}
