using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Encipher("A",13));
            Console.WriteLine(Encipher("a",13));
            Console.WriteLine( );
         //   Console.WriteLine(Encipher("M", 13));
         //  Console.WriteLine(Encipher("m", 13));





        }
    

    static char Helper(char c1, int p)
    {

            if (p < 1)
                throw new ArgumentOutOfRangeException("Only postition between 1 - 26 are allowed");
            // int p = 26;
            //  char c1 = 'z';
            //    char c1 = (char)c.GetValue(0);
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


                Console.WriteLine("below m or M");

                if (p <= 13)//how to prevent letters from n onwards from falling off at 13
                {


                    int positionOfc1InABC = char.IsUpper(c1) ? c1 - 64 : c1 - 96;
                    Console.WriteLine(positionOfc1InABC);
                    if (positionOfc1InABC <= 13 || (positionOfc1InABC > 13 && p<positionOfc1InABC) ) { 
                        c1 = (char)(c1-1 + (((positionOfc1InABC) + p) % 27));
                  //  Console.WriteLine((int)c1);
                    }

                    else
                        c1 = (char)(c1 + (((positionOfc1InABC) + p) % 26));

                }

                else
                {
                    //Console.WriteLine("above m or M");




                    c1 = (char)(c1 - (13 - ((13 + p) % 26)));
                }

            }
            return c1;

        }





































            //    if (c1 >= (int)'a' && c1 <= (int)'z' || c1 >= (int)'A' && c1 <= (int)'Z')
            //{

            //    if ((c1 <= 'm' && c1 >= 'a') || c1 <= 'M')
            //        {    
            //           Console.WriteLine("below m or M");

            //            if (p <= 13) { 

            //              c1 =   (char)(c1 +  p  );}
            //            else
            //                // c1 = (char)(c1 - (p-1)) ;
            //            c1 = (char)(c1 - (13-((13 + p) % 26)));
            //        }

            //    else
            //    {
            //            //Console.WriteLine("above m or M");


            //            if (p < 13)
            //            {
            //                c1 = (char)(c1 + (p));
            //            }
            //            else
            //            {
            //                c1 = (char)(c1 - (13 - ((13 + p) % 26)));
            //            }

            //        }



            //}

    //        return c1;
    //}

    static string Encipher(string s, int p)
    {
            if (s.Length == 1)

                return Helper(s[0], p).ToString();
            else return s; 

    }  

        static string Decipher(string s)
        {
            return "";
        }

    }

}