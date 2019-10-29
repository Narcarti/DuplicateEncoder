using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DuplicateEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DuplicateEncode("Success"));
            //Console.WriteLine(DuplicateEncode("(()()()()))"));
            Console.WriteLine(DuplicateEncode("din"));
            Console.WriteLine(DuplicateEncode("done  with() this)) code"));
            Console.WriteLine(DuplicateEncode(")((((((("));
            Console.WriteLine(DuplicateEncode("...It Should encode XXX"));
            //Console.WriteLine(DuplicateEncode("Success"));
            //Console.WriteLine(DuplicateEncode("Success"));
            //Console.WriteLine(DuplicateEncode("Success"));
            Console.ReadKey();

        }

        public static string DuplicateEncode(string word)
        {
            string combine = "";
            char[] chars = word.ToLower().ToArray<char>();
            string newWord = word.ToLower();
            for (int idx = 0; idx < chars.Length; idx++)
            {
                
                int firstLet = 0;
                foreach (char letter in newWord)
                {
                    int count = newWord.Count(f => f == chars[idx]);
                    if (count != newWord.Count() || firstLet == 0)
                    {
                        firstLet++;
                        if (count > 1) {

                            chars[idx] = ')';
                            break;

                        }
                        else {

                            chars[idx] = '(';
                            break;

                        }
                    }

                }
                combine += chars[idx];
                
            }
            return combine.ToString();
        }
    }
}
