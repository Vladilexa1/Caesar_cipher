using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public class Encoder
    {
        RussianAlphabet russian;
        public Encoder(RussianAlphabet russian)
        {
            this.russian = russian;
        }
        public string EncryptWord(string word, int shift)
        {
            string output = "";

            char[] arrayLetter = word.ToCharArray();
            
            for (int i = 0; i < arrayLetter.Length; i++)
            {
                char encryptLetter;
                if (Char.IsUpper(arrayLetter[i]))
                {
                    char temp = Char.ToLower(arrayLetter[i]);
                    encryptLetter = EncryptChar(temp, shift);
                    output += Char.ToUpper(encryptLetter);
                }
                else
                {
                    encryptLetter = EncryptChar(arrayLetter[i], shift);
                    output += encryptLetter;
                }
            }
            return output;
        }
        private char EncryptChar(char c, int shift)
        {
            int numberLetter = russian.ReturnNumberByLetter(c) + shift;
            char encryptLetter = russian.ReturnLetterByNumber(numberLetter, c);
            return encryptLetter;
        }
        
    }
}
