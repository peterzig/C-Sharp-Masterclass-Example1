using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        // C# Masterclass Udemy code

        //const values never change
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "13.02.1996";
        const string birthday2 = "02.13.1996";
        const string birthday3 = "1996-02-13";

        

        static void Main(string[] args)
        {
            double[] numbers = { 1.23, 32.23 };
            double[] new_numbers = new double[3] { 3.14, 12.34, 15.65 };

            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("The value number {0} is {1}", i, new_numbers[i].ToString());
            }

            WriteYourText("I am an argument called from a method");
            WriteSth();

            //Methods
            Console.WriteLine(Add(21, 37));
            Console.WriteLine(Multiply(10, 122));
            Console.WriteLine(Divide(12, 3));

            GreetFriend();
            AddUserInput();
            Console.Read();
            
        }

        public static void WriteSth()
        {
            Console.WriteLine("I am called from a method");
            
        }

        public static void WriteYourText(string text)
        {
            Console.WriteLine(text);
            
        }
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static void GreetFriend()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ",  my friend");
        }

        public static int AddUserInput()
        {
            int num1 = 0, num2 = 0;
            Console.WriteLine("Please enter the first number: ");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            string num2Input = Console.ReadLine();
  
            try
            {
                num1  = int.Parse(num1Input);
                num2 = int.Parse(num2Input);
            }
            catch(FormatException)
            {
                Console.WriteLine("Format exception, only int32 are acceptable.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, only int32 are acceptable.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument cannot be NULL (empty), only int32 are acceptable.");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            int result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}",num1, num2, result);

            return result;
        }
    }
}
