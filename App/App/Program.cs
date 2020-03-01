using System;
using System.Linq;
using System.Text.RegularExpressions;
using WeCantSpell.Hunspell;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // string text = System.IO.File.ReadAllText("en_GB.dic");

            // Display the file contents to the console. Variable text is a string.
            // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);






            Console.WriteLine(Encipher("xyza", 1));
            Console.WriteLine(Encipher("z", 25));
            Console.WriteLine(Encipher("Caesar cipher? I prefer Caesar salad.", 25));
            Console.WriteLine(Decipher("An education is what remains after we forget everything we have learned"));

              Console.WriteLine(Decipher("Bzdrzq bhogdq? H oqdedq Bzdrzq rzkzc."));
              Console.WriteLine(Decipher("Hu lkbjhapvu pz doha ylthpuz hmaly dl mvynla lclyfaopun dl ohcl slhyulk."));
 
        }





        static char Helper(char c, int p)
        {

            if (p < 1)
                throw new ArgumentOutOfRangeException("Only postition between 1 - 26 are allowed");




            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                int CsPosInABC = char.IsUpper(c) ? c - 64 : c - 96;





                if (CsPosInABC + p <= 26)
                {
                    c = (char)(c + p);
                }

                else
                {



                    c = (char)(c - (CsPosInABC - ((CsPosInABC + p) % 26)));

                }






            }
            return c;

        }





        static string Encipher(string s, int p)
        {
            string newStr = "";
            if (s.Length == 0)

                return newStr;

            newStr += Encipher(s.Substring(0, s.Length - 1), p);
            return newStr += Helper(s[s.Length - 1], p).ToString();


        }
        static string Decipher(string s)
        {
            string[] array = new string[s.Split().Length];//https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
            string decipheredS = "";
            for (int i = 1; i <= 26; i++)
            {

                decipheredS = Encipher(s, i);
                  String pattern = @"\s-\s?|\s+?|[\\\?!/,:\""]\s?"; 
                 array =  System.Text.RegularExpressions.Regex.Split(decipheredS, pattern);


                


                bool allWords = true;
                 foreach (string str in array)
                {
                     string trimmedStr = str.Trim('?', ',', '!', ':', '"', '/', '\\', '-','.');
                   
                    
                    int possesiveAposIndx = str.LastIndexOf('\'');

                    if (possesiveAposIndx > 0)
                    {
                        trimmedStr = str.Remove(possesiveAposIndx, 2);
                    }
                     
 
                    if (!trimmedStr.IsIndDic())
                        {
                            allWords = false;
                        }
                   
                }
                if (allWords)

                    return decipheredS;
            }
            Console.WriteLine("i'm here");

            return s;

        }

       

    }

    public static class Extension
    {
        //public static bool IsAWord(this string text)//https://social.msdn.microsoft.com/Forums/vstudio/en-US/72cacbb3-3a93-48f7-99c2-9eaa1c07cac4/check-if-string-is-word?forum=csharpgeneral
        //{
        //    var regex = new Regex(@"\b[\w']+\b"); 
        //    var match = regex.Match(text);
        //    return match.Value.Equals(text);
        //}

    public static bool IsIndDic(this string word) 
        {

            var dictionary = WordList.CreateFromFiles("en_GB.dic");
             


            if (!dictionary.Check(word))
            {
                return false;

            }





            return true; 
        
        }

    }

}