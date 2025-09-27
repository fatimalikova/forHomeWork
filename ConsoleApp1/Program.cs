using System.Numerics;

namespace ConditionExample
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region TASK1
            //int sum = 0;
            //for (int i = 0; i < 100; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region TASK2
            //int number = 245;
            //if (number <= 1)
            //{
            //    Console.WriteLine("This number is neither simple nor complex.");
            //    return;
            //}

            //bool simple = true;

            //for (int i = 2; i <= number / 2; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        simple = false;
            //        break;
            //    }
            //}

            //if (simple)
            //{
            //    Console.WriteLine("This number is simple");
            //}
            //else
            //{
            //    Console.WriteLine("This number is complex");
            //} 
            #endregion

            #region TASK3

            //  MAIN STRUCTURE:
            int num = 1234;
            int length = 0;
            int numCopy = num;

            
            while (num > 0)
            {
                num /= 10;
                length++;
            }


            for (int i = length - 1; i >= 0; i--)
            {
                int digit = numCopy / (int)Math.Pow(10, i);
                Console.WriteLine(digit);
                numCopy %= (int)Math.Pow(10, i);
            }


            #endregion

            #region TASK4
            //double number = 1024;
            //while (number % 2 == 0)
            //{
            //    number /= 2;
            //}
            //if (number != 1)
            //{
            //    Console.WriteLine("Not a power of two");
            //}
            //else
            //{
            //    Console.WriteLine("Is a power of two");
            //} 
            #endregion

        }
    }
}