using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Encipher("z", 0));
            Console.WriteLine(Encipher("Z", 0));
           // Console.WriteLine();
           // Console.WriteLine(Encipher("a", 0));
           //Console.WriteLine(Encipher("A", 0));





        }
    

    static char Helper(char[] c, int p)
    {

            if (p > 25)
                throw new ArgumentOutOfRangeException("Only postition between 1 - 26 are allowed");
       // int p = 26;
            //  char c1 = 'z';
            char c1 = (char)c.GetValue(0);
        //char c2 = 'n';
        //Console.WriteLine((int)c1);
        //Console.WriteLine((int)c2);
        //Console.WriteLine();
        //Console.WriteLine((char)(109 % 255));
        //Console.WriteLine((char)(110 % 255));
        //Console.WriteLine();

            //Console.WriteLine((char)(122));
            //Console.WriteLine((char)(122 % 255));
            //Console.WriteLine();
            //Console.WriteLine((char)(90));
            //Console.WriteLine((char)(90 % 255));
            //Console.WriteLine();

            if (c1 >= (int)'a' && c1 <= (int)'z' || c1 >= (int)'A' && c1 <= (int)'Z')
        {

            if (c1 <= 'm' && c1 >= 'a' || c1 <= 'M')
            {
               // Console.WriteLine("below m or M");
            c1 =   (char)((int)c1 + p);
            }

            else
            {
           c1 =   (char)((c1 + p) % 255 - 26);
            }

          

        }

            return c1;
    }

    static string Encipher(string s, int p)
    {
            if (s.Length == 1)

                return Helper(s.ToCharArray(), p).ToString();
            else return s; 

    }  

        static string Decipher(string s)
        {
            return "";
        }

    }

}