using System;
using System.Collections.Generic;
using System.Text.Json;

class Salesman
{
    static int NextId = 1;
    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Sales { get; private set; }
    public Salesman Supervisor { get; private set; }
    public List<Salesman> Subordinates { get; private set; }

    public Salesman(string surname, string name, int sales, int id = 0)
    {
        Name = name;
        Surname = surname;
        Sales = sales;
        Subordinates = new List<Salesman>();

        if (id != 0)
        {
            ID = id;
            if (id > NextId)
                NextId = id + 1;
        }
        else
        {
            ID = NextId++;
        }
    }

    public void AddSubordinate(Salesman subordinate)
    {
        subordinate.Supervisor = this;
        Subordinates.Add(subordinate);
    }

    public void DisplayDetails(int selectedIndex)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Obchodník: {Name} {Surname}");
        Console.WriteLine($"Prodeje: {Sales} $");
        Console.WriteLine("Nadøízený: " + (Supervisor != null ? Supervisor.Name + " " + Supervisor.Surname : "Žádný"));
        Console.WriteLine("Podøízení:");

        if (selectedIndex == -1)
        {
            Console.WriteLine("> [Obchodník] " + Name + " " + Surname);
        }
        else
        {
            Console.WriteLine("  [Obchodník] " + Name + " " + Surname);
        }

        if (Subordinates.Count == 0)
        {
            Console.WriteLine(" - Žádní");
        }
        else
        {
            for (int i = 0; i < Subordinates.Count; i++)
            {
                if (i == selectedIndex)
                {
                    Console.WriteLine($"> {Subordinates[i].Name} {Subordinates[i].Surname}");
                }
                else
                {
                    Console.WriteLine($"  {Subordinates[i].Name} {Subordinates[i].Surname}");
                }
            }
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Q - Konec");
    }

    public static Salesman DeserializeTree(string jsonString)
    {
        try
        {
            List<SalesmanData> deserializedData = JsonSerializer.Deserialize<List<SalesmanData>>(jsonString);
            Dictionary<int, Salesman> treeData = new Dictionary<int, Salesman>();
            Salesman root = null;

            foreach (var item in deserializedData)
            {
                Salesman salesman = item.ToSalesman();
                treeData[salesman.ID] = salesman;
            }

            foreach (var item in deserializedData)
            {
                if (item.ParentId != 0)
                {
                    treeData[item.ParentId].AddSubordinate(treeData[item.ID]);
                }
                else
                {
                    root = treeData[item.ID];
                }
            }

            return root;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba pøi naèítání JSON: {ex.Message}");
            return null;
        }
    }

    private class SalesmanData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Sales { get; set; }
        public int ParentId { get; set; }


      
        public Salesman ToSalesman() => new Salesman(Surname, Name, Sales, ID);
    }
}
