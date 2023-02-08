using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Segitiga
{
    public static void main(String[] args)
    {
        int x = 5;
        for (int i = 1; i <= x; i++)
        {
            for (int j = 4; j >= i; j--)
            {
                Console.Write("");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            for (int l = 1; l <= i - 1; l++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}
