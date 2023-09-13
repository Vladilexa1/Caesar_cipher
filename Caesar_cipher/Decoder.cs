using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public class Decoder
    {
        RussianAlphabet russian;
        public Decoder(RussianAlphabet russian)
        {
            this.russian = russian;
        }
        public string DecodingWord(string word, int shift)
        {
                string output = "";

                char[] arrayLetter = word.ToCharArray();

                for (int i = 0; i < arrayLetter.Length; i++)
                {
                    char decodingLetter;
                    if (Char.IsUpper(arrayLetter[i]))
                    {
                        char temp = Char.ToLower(arrayLetter[i]);
                        decodingLetter = DecodingChar(temp, shift);
                        output += Char.ToUpper(decodingLetter);
                    }
                    else
                    {
                        decodingLetter = DecodingChar(arrayLetter[i], shift);
                        output += decodingLetter;
                    }
                }
                return output;
        }
        private char DecodingChar(char c, int shift)
        {
            int numberLetter = russian.ReturnNumberByLetter(c) + ( 33 - shift);
            char decodingLetter = russian.ReturnLetterByNumber(numberLetter, c);
            return decodingLetter;
        }
    }
}
