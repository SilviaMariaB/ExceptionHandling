using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1 - array out of bounds
            //int[] numbers = new int[] { 1 };

            //try
            //{
            //    Console.WriteLine(numbers[1]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index out of range.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Something went wrong.");
            //}

            //task2 - custom tryparse function
            //bool success = true;

            //while (success)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insert a number:");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        success = false;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Number too big or too small.");
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Something went wrong.");
            //    }
            //}

            //Console.WriteLine("Insert a number:");

            //if(CustomTryParse(Console.ReadLine(), out int result))
            //{
            //    Console.WriteLine("Succesfull! " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Oh no...");
            //}


            //task3 - divide by 0

            //int result = num1 / num2;

            /*bool check = false;
            int num1 = 0;
            int num2 = 0;

            while (!check)
            {
                check = ReadNumber(out num1, "Please insert number 1: ");
            }

            check = false;

            while (!check)
            {
                check = ReadNumber(out num2, "Please insert number 2: ");
            }

            try
            {
                int result = num1 / num2;
                Console.WriteLine("The result is " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong...");
            }*/

            //task4 - int overflow
            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.WriteLine("Insert a number: ");
                    int number4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number4);
                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too big or too small.");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            Console.ReadLine();
        }

        static bool ReadNumber(out int number, string message)
        {
            number = 0;
            try
            {
                Console.WriteLine(message);
                number = Convert.ToInt32(Console.ReadLine());
                return true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too big or too small.");
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong...");
                return false;
            }
        }
        static bool CustomTryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
