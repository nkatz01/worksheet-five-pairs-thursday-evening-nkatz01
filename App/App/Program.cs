using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {


       //   Console.WriteLine(Encipher("xyza", 1));
             Console.WriteLine(Encipher("z",25));
           Console.WriteLine(Encipher("Caesar cipher? I prefer Caesar salad.", 25));
           //Console.WriteLine(Encipher("Z", 26));
           // Console.WriteLine(Encipher("z",26));





        }


        //static char Helper(char c1, int p)
        //{

        //        if (p < 1)
        //            throw new ArgumentOutOfRangeException("Only postition between 1 - 26 are allowed");




        //        if ((c1 >=  'a' && c1 <=  'z' )|| (c1 >=  'A' && c1 <=  'Z'))
        //        {
        //                int c1sPosInABC = char.IsUpper(c1) ? c1 - 64 : c1 - 96;



        //            if (p <= 13)
        //            {


        //                if (c1sPosInABC + p <= 26  )  { 
        //                    c1 = (char)(c1 + p) ;
        //                }

        //                else {



        //                    c1 = (char)(c1 -(c1sPosInABC - ((c1sPosInABC + p) % 26)));

        //                }

        //            }

        //            else
        //            {


        //                if (c1sPosInABC + p <= 26)
        //                { 
        //                    c1 = (char)(c1 + p);
        //                }
        //                else {


        //                c1 = (char)(c1 - (c1sPosInABC - ((c1sPosInABC + p) % 26))); }
        //            }

        //        }
        //        return c1;

        //    }


        static char Helper(char c1, int p)
        {

            if (p < 1)
                throw new ArgumentOutOfRangeException("Only postition between 1 - 26 are allowed");




            if ((c1 >= 'a' && c1 <= 'z') || (c1 >= 'A' && c1 <= 'Z'))
            {
                int c1sPosInABC = char.IsUpper(c1) ? c1 - 64 : c1 - 96;



                

                    if (c1sPosInABC + p <= 26)
                    {
                        c1 = (char)(c1 + p);
                    }

                    else
                    {



                        c1 = (char)(c1 - (c1sPosInABC - ((c1sPosInABC + p) % 26)));

                    }

               

                
                 

            }
            return c1;

        }





        static string Encipher(string s, int p)
    { string newStr = "";
            if (s.Length == 0)

                return newStr;

           newStr += Encipher(s.Substring(0, s.Length - 1), p);
            return newStr +=  Helper(s[s.Length - 1], p).ToString();


        }

        static string Decipher(string s)
        {
            return "";
        }

    }

}