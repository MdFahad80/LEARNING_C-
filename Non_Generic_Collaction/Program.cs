using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Non_Generic_Collaction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Collection of Array ===================================================================

            ArrayList myList = new ArrayList();
            Console.WriteLine(myList.Capacity);
            myList.Add(10);
            Console.WriteLine(myList.Capacity);
            myList.Add(20);
            Console.WriteLine(myList.Capacity);
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            myList.Insert(2, 30);

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            myList.Remove(30);
            myList.Insert(2, 30);
            myList.RemoveAt(2);

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("========================================================");

            //Hash-Table ============================================================================
            Hashtable H1 = new Hashtable()
            {
                {"Id", 1254 },
                {"Name", "Md Fahad" },
                {"Age", 22 },
            };

            //H1.Add("Id", 1254);
            //H1.Add("Name", "Md Fahad");
            //H1.Add("Age", 22);

            //Console.WriteLine(H1["Name"]);
            //Console.WriteLine(H1.Count);
            //Console.WriteLine(H1.Contains("Name")); //return true/false value
            //Console.WriteLine(H1.ContainsKey("Gender")); //return true/false value
            //Console.WriteLine(H1.ContainsValue(22));

            //H1.Remove("Id");
            //H1.Clear();

            foreach (object key in H1.Keys)
            {
                Console.WriteLine($"{key} : {H1[key]}");
            }

            foreach (object key in H1.Values)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("========================================================");

            //Stack LIFO - Last in Fast Out ===================================================================================

            Stack myStack = new Stack();
            myStack.Push("Md Fahad");
            myStack.Push(22);
            myStack.Push("Student");
            myStack.Push(false);
            myStack.Push("Softwar Enginner");

            //Console.WriteLine(myStack.Count);
            //Console.WriteLine(myStack.Contains("Md Fahad"));
            //Console.WriteLine(myStack.Peek());
            //myStack.Pop();
            myStack.Clear();

            foreach (object item in myStack) {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("========================================================");

            //Queue FIFO - Fast in Fast Out ===============================================================================

            Queue myQueue = new Queue();

            myQueue.Enqueue("Md Fahad");
            myQueue.Enqueue("Student");
            myQueue.Enqueue("Softwar Enginner");
            myQueue.Enqueue(22);

            //Console.WriteLine(myQueue.Count);
            //Console.WriteLine(myQueue.Contains("Md Fahad"));
            //Console.WriteLine(myQueue.Peek());

            //while (myQueue.Count > 0)
            //{
            //    myQueue.Dequeue();
            //}

            myQueue.Clear();

            foreach (object item in myQueue)
            {
                Console.WriteLine(item + " ");
            }









            Console.ReadLine();
        }
    }
}
