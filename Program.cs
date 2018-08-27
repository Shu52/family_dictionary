using System;
using System.Collections.Generic;

namespace family_dictionary
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("Wife", new Dictionary<string, string>(){
                {"name", "Melissa"},
                {"age", "36"}
            });
            myFamily.Add("Son", new Dictionary<string, string>(){
                {"name", "Kai"},
                {"age", "1"}
            });
            foreach (var item in myFamily)
            {
            Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]} years old");
                
            }
        }
    }
}
