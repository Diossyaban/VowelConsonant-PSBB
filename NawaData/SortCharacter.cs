using System;
using System.Text.RegularExpressions;





namespace NawaDataTes
{
    internal class PSBB
    {

        public static int[] ArrayStringToInt(string input)
        {
            String[] arrayInput = input.Split(' ');

            int[] arrayResult = new int[arrayInput.Length];

            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayResult[i] = Convert.ToInt32(arrayInput[i]);
            }

            return arrayResult;
        }
        static void Main(string[] args)
        {
            int countBus = 0, sum = 0;

            Console.Write("Input the number of families             : ");
            int family = int.Parse(Console.In.ReadLine());
            Console.Write("Input the number of member in the family : ");
            String memberFamily = Console.ReadLine();


            int[] arrayMemberFamily = ArrayStringToInt(memberFamily);

            if (arrayMemberFamily.Length == family)
            {

                for (int i = 0; i < family; i++)
                {
                    sum = sum + arrayMemberFamily[i];
                }

                countBus = sum / 4;

                if (sum % 4 == 0)
                {
                    Console.WriteLine("Minimum bus required is : " + countBus);
                }
                else
                {
                    countBus = countBus + 1;
                    Console.WriteLine("Minimum bus required is : " + countBus);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Input must be equal with count of family");
                Console.ReadLine();
            }
        }
    }
}
