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
                string inputString = Input.InputString();  //File.ReadAllText("test.txt");  
                int shift = Input.InputShift();
                Encoder encoder = new Encoder();

                Console.WriteLine(encoder.EncryptWord(inputString, shift));
            }
        }
    }
}