using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your first Number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second Number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //try
            //{
            //    int resutl = num1 / num2;
            //    Console.WriteLine($"Your divide number {resutl}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can not divide a by Zero...");
            //    Console.WriteLine (ex.Message );
            //}


            //Console.WriteLine("Reminimg Statement 1");
            //Console.WriteLine("Reminimg Statement 2");
            //Console.WriteLine("Reminimg Statement 3");

            //Index out of Range
            int[] arr = new int[3];

            try
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 3;

                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Blog is Running!");
            }

            int account_amount = 5000;
            int widrew_amount = 6000;

            try
            {
                if (account_amount < widrew_amount)
                {
                    throw new Exception("Your current amount is very low..");
                }
                else
                {
                    account_amount = account_amount - widrew_amount;
                    Console.WriteLine("Your account amount is " + account_amount);
                    Console.WriteLine("Your transation is conplited!");
                }
            }catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            



            Console.ReadLine(); 
        }
    }
}
