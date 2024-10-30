using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    public static class HelperClass
    {

        public static int GetIntInRange(string message, int min, int max)
        {
            bool isnumber = true;
            int value = 0;
            do
            {
                Console.WriteLine(message);
                isnumber = int.TryParse(Console.ReadLine(), out value);
            }
            while (value <= min && value >= max && !isnumber);
            return value;
        }
        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public static void WriteLineInt(int numbers) 
        {
            Console.WriteLine(numbers);
        }

        public static string ReadLine() 
        { 
        return Console.ReadLine();
        }
        public static int RandomNumber(int min, int max) 
        { 
        Random random = new Random();
        return random.Next(min, max + 1);   
                }
    }
}
