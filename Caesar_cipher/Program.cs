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
                bool decoding = Input.DecodingStatus();
                Encoder encoder = new Encoder(new RussianAlphabet());
                Decoder decoder = new Decoder(new RussianAlphabet());
                string result = "";
                while (true)
                {
                    string[] splitString = inputString.Split(" ", 2);
                    
                    result += encoder.EncryptWord(splitString[0], shift);

                    if (decoding)
                    {
                        result += decoder.DecodingWord(splitString[0], shift);
                    }
                    else
                    {
                        result += encoder.EncryptWord(splitString[0], shift);
                    }
                    if (splitString.Length > 1)
                    {
                        inputString = splitString[1];
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(result);

            }
        }
        static void encoding()
        {

        }
    }
}