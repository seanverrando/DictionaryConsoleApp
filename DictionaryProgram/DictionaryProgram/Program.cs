using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;




namespace DictionaryProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your dictionary");
            LookUpWord dictionary = new LookUpWord();
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("");
            object x = dictionary.ReturnDef(word);
            Console.WriteLine(x);
        }
    }
}
    

    

   