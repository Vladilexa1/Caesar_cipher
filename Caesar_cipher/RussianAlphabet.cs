using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public class RussianAlphabet
    {

        public char ReturnLetterByNumber(int number, char c)
        {
            int shiftNumber = number;
            if (alphabet.ContainsValue(shiftNumber))
            {
                foreach (var alphabet in alphabet)
                {
                    if (alphabet.Value == shiftNumber)
                    {
                        return alphabet.Key;
                    }
                }
            }
            return c;
        }
        public int ReturnNumberByLetter(char letter)
        {
            if (alphabet.ContainsKey(letter))
            {
                return alphabet[letter];
            }
            return 999;
        }

        private Dictionary<char, int> alphabet = new Dictionary<char, int>()
        {
            {'а', 1},
            {'б', 2},
            {'в', 3},
            {'г', 4},
            {'д', 5},
            {'е', 6},
            {'ё', 7},
            {'ж', 8},
            {'з', 9},
            {'и', 10},
            {'й', 11},
            {'к', 12},
            {'л', 13},
            {'м', 14},
            {'н', 15},
            {'о', 16},
            {'п', 17},
            {'р', 18},
            {'с', 19},
            {'т', 20},
            {'у', 21},
            {'ф', 22},
            {'х', 23},
            {'ц', 24},
            {'ч', 25},
            {'ш', 26},
            {'щ', 27},
            {'ъ', 28},
            {'ы', 29},
            {'ь', 30},
            {'э', 31},
            {'ю', 32},
            {'я', 33}
        };
    }
}
