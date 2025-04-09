using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string jsonFile = "largetree.json";
        if (!File.Exists(jsonFile))
        {
            Console.WriteLine($"Soubor {jsonFile} nebyl nalezen.");
            return;
        }

        Salesman boss = Salesman.DeserializeTree(File.ReadAllText(jsonFile));
        if (boss == null)
        {
            Console.WriteLine("Chyba při načítání dat.");
            return;
        }

        NavigateTree(boss);
    }

    static void NavigateTree(Salesman current)
    {
        int selectedIndex = -1; 
      

        while (true)
        {
            current.DisplayDetails(selectedIndex);

            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.UpArrow)
            {
                if (selectedIndex == -1 && current.Supervisor != null)
                {
                    current = current.Supervisor;
                }
                else if (selectedIndex > -1)
                {
                    selectedIndex--;
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (selectedIndex < current.Subordinates.Count - 1)
                {
                    selectedIndex++;
                }
            }
            else if (key == ConsoleKey.Enter)
            {
                if (selectedIndex == -1 && current.Supervisor != null)
                {
                    current = current.Supervisor;
                }
                else if (selectedIndex >= 0)
                {
                    current = current.Subordinates[selectedIndex];
                    selectedIndex = -1;
                }
            }
            else if (key == ConsoleKey.Backspace && current.Supervisor != null)
            {
                current = current.Supervisor;
                selectedIndex = -1;
            }
            else if (key == ConsoleKey.Q)
            {
                break;
            }
        }
    }
}