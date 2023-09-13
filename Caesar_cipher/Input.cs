using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public static class Input
    {
        public static string InputString()
        {
            Console.WriteLine("Write your text");
            string input = Console.ReadLine();
            return input;
        }
        public static int InputShift()
        {
            Console.WriteLine("Write shift from 1 to 32");
            while (true)
            {
                string input = Console.ReadLine();

                int.TryParse(input, out int result);
                if (result == 0)
                {
                    Console.WriteLine("Invalid shift, please enter a number from 1 to 32 ");
                    continue;
                }
                if (result < 0)
                {
                    Console.WriteLine("Invalid shift, please enter a number from 1 to 32 ");
                    continue;
                }
                if (result > 32)
                {
                    Console.WriteLine("Invalid shift, please enter a number from 1 to 32 ");
                    continue;
                }
                return result;
            }
        }
        public static bool DecodingStatus()
        {
            while (true)
            {
                Console.WriteLine("Write status program. (ex. d - its decoding, e - its encoding");
                string statusProgramm = Console.ReadLine();
                if (statusProgramm.ToLower() == "d")
                {
                    return true;
                }
                if (statusProgramm.ToLower() == "e")
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
           
        }
    }
}
