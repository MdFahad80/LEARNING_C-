using System.Collections;
using System.Collections.Generic;

namespace LearningLINQ
{
    class LINQ
    {

        static void Main(string[] args)
        {
            int[] numbers = {5, 4, 3, 2, 8, 90, 67, 45 };

            IEnumerable<int> even_number = from number in numbers where number % 2 == 0 orderby number select number;

            foreach (int number in even_number)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
