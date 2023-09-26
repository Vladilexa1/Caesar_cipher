using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public class Encoder
    {
        public string EncryptWord(string word, int shift)
        {
            StringBuilder stringBuilder = new StringBuilder();

            char[] arrayLetter = word.ToCharArray();

            for (int i = 0; i < arrayLetter.Length; i++)
            {
                int letterNumber = arrayLetter[i];

                if (1040 <= letterNumber && letterNumber <= 1103) // отсекли все кроме русских букв
                {
                    if (Char.IsUpper(arrayLetter[i])) // отсекли больщие
                    {
                        letterNumber += shift;
                        if (letterNumber > 1071)
                        {
                            letterNumber -= 32;
                        }
                    }
                    else
                    {
                        letterNumber += shift;
                        if (letterNumber > 1103)
                        {
                            letterNumber -= 32;
                        }
                    }
                    stringBuilder.Append((char)letterNumber);
                }
                else
                {
                    stringBuilder.Append((char)letterNumber);
                }
                
            }
            return stringBuilder.ToString();
        }
    }
}
