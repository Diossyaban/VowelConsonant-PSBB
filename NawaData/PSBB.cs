
using System;
using System.Text.RegularExpressions;

namespace NawaDataTes
{
    internal class SortCharacter
    {
        public string procVowel(string input)
        {
            char[] chars = input.ToCharArray();
            char[] vowel = new char[chars.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u' ||
                    chars[i] == 'A' || chars[i] == 'E' || chars[i] == 'I' || chars[i] == 'O' || chars[i] == 'Z')
                {
                    vowel[i] = chars[i];
                }
                else
                {
                    vowel[i] = ' ';
                }
            }
            Array.Sort(vowel);
            var vowels = new string(vowel);
            vowels = Regex.Replace(vowels, @"\s+", String.Empty);
            String result = vowels.ToLower();
            return result;
        }

        public string procConsonant(string input)
        {
            char[] chars = input.ToCharArray();
            char[] consonant = new char[chars.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' ||
                    input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'Z')
                {
                    consonant[i] = ' ';
                }
                else
                {
                    consonant[i] = chars[i];
                }
            }
            Array.Sort(consonant);
            var consonants = new string(consonant);
            consonants.ToLower();
            consonants = Regex.Replace(consonants, @"\s+", String.Empty);
            String result = consonants.ToLower();
            return result;
        }
        public static void Main()
        {
            Console.Write("Masukan Kalimat : ");
            string input = Console.ReadLine();

            var mc = new SortCharacter();

            string charVowel = mc.procVowel(input);
            string charConsonant = mc.procConsonant(input);

            Console.WriteLine("Vowel Characters : ");
            Console.WriteLine(charVowel);
            Console.WriteLine("Consonant Characters : ");
            Console.WriteLine(charConsonant);

            Console.ReadLine();
        }

    }
}
