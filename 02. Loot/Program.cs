using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Loot
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> items = Console.ReadLine().Split('|').ToList();
         

            string[] comand = Console.ReadLine().Split(" ").ToArray();

            while (comand[0] != "Yohoho!")
            {

                if (comand[0] == "Loot")
                {
                    for (int i = 1; i < comand.Length; i++)
                    {
                        if (!items.Contains(comand[i]))
                        {
                            items.Insert(0, comand[i]);
                        }

                    }
                }
                else if (comand[0] == "Drop")
                {
                    int index = int.Parse(comand[1]);

                    if (index < items.Count && index >= 0)
                    {
                        items.Insert(items.Count, items[index]);
                        items.RemoveAt(index);
                    }
                }
                else if (comand[0] == "Steal")
                {
                    List<string> stealedItems = new List<string>();

                    int count = int.Parse(comand[1]);

                    int allItems = items.Count;

                    if (count > items.Count)
                    {
                        count = items.Count;
                    }

                    int currentItem = items.Count - count;

                    for (int i = items.Count - count; i < allItems; i++)
                    {

                        stealedItems.Add(items[currentItem]);
                        items.RemoveAt(currentItem);

                    }
                    Console.WriteLine(string.Join(", ", stealedItems));
                }

                comand = Console.ReadLine().Split(" ").ToArray();
            }
            if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double credits = 0;

                foreach (var item in items)
                {
                    credits += item.Length;
                }
                credits = credits / items.Count;
                
                Console.WriteLine($"Average treasure gain: {credits:f2} pirate credits.");
            }
        }
    }
}
