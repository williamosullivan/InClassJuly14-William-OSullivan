using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassJuly14_William_OSullivan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> { };
            string[] array = new string[] { "1", "2", "3", "4" };
            Dictionary<string, Person> map = new Dictionary<string, Person>();
            foreach (string i in array)
            {
                map[i] = new Person();
                people.Add(map[i]);
            }
        }
    }
}
