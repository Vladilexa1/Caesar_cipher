using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string inputString = Input.InputString();
                int shift = Input.InputShift();
                StringBuilder stringBuilder = new StringBuilder();
                Encoder encoder = new Encoder();
               
                while (true)
                {
                    string[] splitString = inputString.Split(" ", 2);

                    stringBuilder.Append(encoder.EncryptWord(splitString[0], shift) + " ");
                    
                    if (splitString.Length > 1)
                    {
                        inputString = splitString[1];
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(stringBuilder);
            }
        }
    }
}