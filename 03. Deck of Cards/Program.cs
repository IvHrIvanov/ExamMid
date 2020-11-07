using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                StringBuilder messages = new StringBuilder();

                string[] comand = Console.ReadLine().Split(", ").ToArray();

                if (comand[0] == "Add")
                {
                    if (!cards.Contains(comand[1]))
                    {
                        cards.Add(comand[1]);
                        messages.AppendLine("Card successfully bought");
                    }
                    else
                    {
                        messages.AppendLine("Card is already bought");
                    }
                }
                else if (comand[0] == "Remove")
                {
                    if (cards.Contains(comand[1]))
                    {
                        cards.Remove(comand[1]);
                        messages.AppendLine("Card successfully sold");
                    }
                    else
                    {
                        messages.AppendLine("Card not found");
                    }
                }
                else if (comand[0] == "Remove At")
                {
                    int index = int.Parse(comand[1]);
                    if (index < cards.Count && index >= 0)
                    {
                        cards.RemoveAt(index);
                        messages.AppendLine("Card successfully sold");

                    }
                    else
                    {
                        messages.AppendLine("Index out of range");
                    }
                }
                else if (comand[0] == "Insert")
                {
                    int index = int.Parse(comand[1]);
                    if (index < cards.Count && index >= 0 && !cards.Contains(comand[2]))
                    {
                        cards.Insert(index, comand[2]);
                        messages.AppendLine("Card successfully bought");
                    }
                    else if (index < cards.Count && index >= 0 && cards.Contains(comand[2]))
                    {
                        messages.AppendLine("Card is already bought");
                    }
                    else
                    {
                        messages.AppendLine("Index out of range");
                        Console.Write(messages);
                        continue;
                    }

                }

                Console.Write(messages);
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
