using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;


namespace DictionaryProgram
{
    class LookUpWord
    {
        //path the JSON file
        JObject data = JObject.Parse(File.ReadAllText(@"C:\Users\seanv\source\repos\DictionaryProgram\data.json"));
        public object ReturnDef(string word)
        {
            object term = new object();
            word = word.ToLower();
            if (data.ContainsKey(word))
            {
                var myWord = data[word];
                // loop through the value deleting the [] and extra space to make it look nice
                foreach(var value in myWord)
                {
                    //Console.WriteLine(item.Key);
                    term = value;
                    
                }
            }
            else
            {
                Console.WriteLine( "Could not find word.");
            }
            return term;
        }
    }
}
