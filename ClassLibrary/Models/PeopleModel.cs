using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class PeopleModel
    {

        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Occupation { get; set; }
    }
}
