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
           






            Console.WriteLine(Encipher("xyza", 1));
            Console.WriteLine(Encipher("Z A", 1));
            Console.WriteLine(Encipher("Caesar cipher? I prefer Caesar salad.", 25));

              Console.WriteLine(Decipher("Bzdrzq bhogdq? H oqdedq Bzdrzq rzkzc."));
              Console.WriteLine(Decipher("Hu lkbjhapvu pz doha ylthpuz hmaly dl mvynla clyfaopun dl ohcl slhyulk."));
 
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
            int numberOfWordsNotFoundInDic = array.Length;
            string BestChoice = "";
            for (int i = 1; i <= 26; i++)
            {

                decipheredS = Encipher(s, i);
                  String pattern = @"\s-\s?|\s+?|[\\\?!/,:\""]\s?"; 
                 array =  System.Text.RegularExpressions.Regex.Split(decipheredS, pattern);
               int wordsInScentence = array.Length;
                int notWords = 0;



                 
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
                        
                        notWords++;
                        }
                   
                }
                if (wordsInScentence - notWords > (wordsInScentence - numberOfWordsNotFoundInDic)) { 
                    numberOfWordsNotFoundInDic = notWords;
                 BestChoice = decipheredS;
                 
                }
            }
            

            return BestChoice;

        }

       

    }

    public static class Extension
    {
      
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