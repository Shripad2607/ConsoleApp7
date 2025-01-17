using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class CollectionDictionary
    {
        static void Main()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 1,"Apple"},
                { 2,"Banana"},
                { 3,"Cherry"},
                { 4,"Date"},
                { 5,"Elderberry"},
                { 6,"Fig"},
                { 7,"Grape"},
                { 8,"Honeybees"},
                { 9,"Indian fig"},
                { 10,"Jackfruit"}
            };
            //Display elements
            Console.WriteLine("dictionary Elemets");
            foreach(var items in dictionary)
            {
                Console.WriteLine($"Key:{items.Key},value:{items.Value}");
            }
            //Modify an elements
            dictionary[2] = "Blueberry";
            Console.WriteLine("\n Modified value for key 2 :" + dictionary[2]);

            //Remove a specific elements
            dictionary.Remove(4);
            Console.WriteLine("\n After removing key 4:");
            foreach(var items in dictionary)
            {
                Console.WriteLine($"Key:{items.Key},value:{items.Value}");
            }
            //filter elements using containkey
            int keyToCheck = 5;
            if(dictionary.ContainsKey(keyToCheck))
            {
                Console.WriteLine($"\nkey {keyToCheck} exist with value:{dictionary[keyToCheck]}");
            }
            else
            {
                Console.WriteLine($"\nkey {keyToCheck} does not exist");
            }

            //clear the dictionary
            dictionary.Clear();
            Console.WriteLine("\nDictionary cleared. Count :" + dictionary.Count);
        }
    }
}
