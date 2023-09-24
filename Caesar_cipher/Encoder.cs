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
            string output = "";

            char[] arrayLetter = word.ToCharArray();
            
            for (int i = 0; i < arrayLetter.Length; i++)
            {
                int letterNumber = arrayLetter[i];
               
                if (1040 <= letterNumber && letterNumber <= 1103) // отсекли все кроме русских букв
                {
                    if (Char.IsUpper((char)letterNumber)) // отсекли больщие
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
                    output += (char)letterNumber;
                }
                else
                {
                    output += (char)letterNumber;
                }
            }
            return output;
        }
        //public string encryptWord(string word, int shift)
        //{
        //    string output = "";

        //    char[] arrayLetter = word.ToCharArray();

        //    for (int i = 0; i < arrayLetter.Length; i++)
        //    {
        //        int letterNumber = arrayLetter[i];
        //        if (letterNumber <= 1071)
        //        {
        //            if (letterNumber + shift > 1071)
        //            {
        //                letterNumber += shift - 33;
        //            }
        //        }
        //        if (letterNumber >= 1103)
        //        {
        //            letterNumber -= 32;
        //        }
        //        if (letterNumber < 1071)
        //        {
        //            output += arrayLetter[i];
        //            continue;
        //        }
        //        letterNumber += shift;
        //        char res = (char)letterNumber;
        //        output += res;
        //    }
        //    return output;
        //}
    }
}
