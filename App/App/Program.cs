using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            
      


      

 
         int p = 1;
            char c1 = 'Z';
            char c2 = 'n';
            Console.WriteLine((int)c1);
            Console.WriteLine((int)c2);
            Console.WriteLine();
            Console.WriteLine((char)(109 % 255));
            Console.WriteLine((char)(110 % 255));
            Console.WriteLine();

            Console.WriteLine((char)(122));
            Console.WriteLine((char)(122 % 255));
            Console.WriteLine();
            Console.WriteLine((char)(90));
            Console.WriteLine((char)(90 % 255));
            Console.WriteLine();

            if (c1 >= (int)'a' && c1 <= (int)'z' || c1 >= (int)'A' && c1 <= (int)'Z')
            {

                if (c1 <= 'm' && c1 >= 'a' || c1 <= 'M')
                {
                    Console.WriteLine("below m or M");
                    Console.WriteLine((char)((int)c1 + p));
                }

                else
                {
                    Console.WriteLine((char)((c1 + p) % 255 - 26));
                }

            }
        }
    
    static string Encipher(string s, int n)
        {
            return "";
        }

        static string Decipher(string s)
        {
            return "";
        }

    }
}
