using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List ==================================================================

            List<int> Numbers = new List<int>();
            Numbers.Add(11);
            Numbers.Add(22);
            Numbers.Add(33);
            Numbers.Add(22);

            List<string> name = new List<string>();
            name.Add("Md Fahad");

            //Console.WriteLine(name[0]);

            Employ emp1 = new Employ()
            {
                Name = "Md Fahad",
                Age = 22,
                Qulification = "Enginner"
            };

            Employ emp2 = new Employ()
            {
                Name = "Harun",
                Age = 26,
                Qulification = "Doctore"
            };

            Employ emp3 = new Employ()
            {
                Name = "Hasan",
                Age = 22,
                Qulification = "Teacher"
            };
            
            List<Employ> employs = new List<Employ>();
            employs.Add(emp1);
            employs.Add(emp2);
            employs.Add(emp3);

            foreach (Employ item in employs)
            {
                Console.WriteLine("Employ Name {0}, Employ Age {1}, Employ Qulification {2}", item.Name, item.Age, item.Qulification);
            }

            //Dictionary ================================================================

            Dictionary<string, string> dic1 = new Dictionary<string, string>();

            dic1.Add("name", "Md Fahad");
            dic1.Add("qulification", "Softwater Enginner");

            foreach (KeyValuePair<string, string> item in dic1)
            {
                Console.WriteLine($"Your {item.Key} is {item.Value}, Your {item.Key} is {item.Value}");
            }






            Console.ReadLine();
        }
    }
}
