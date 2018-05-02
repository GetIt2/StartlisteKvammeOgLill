using System;

namespace Startliste
{
    class Registration
    {
        public string StartNumber { get; }
        public string Name { get; }
        public string Club { get; }
        public string Nationality { get; }
        public string Group { get; }
        public string Class { get; }

        public Registration(string line)
        {
            var parts = line.Split(',');
            for (var i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim('"');
            }
            StartNumber = parts[0];
            Name = parts[1];
            Club = parts[2];
            Nationality = parts[3];
            Group = parts[4];
            Class = parts[5];
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine(StartNumber == "" ? "Ikke registrert startnummer." : $"Startnummer: {StartNumber}");
            Console.WriteLine(Name == "" ? "Ikke registrert navn." : $"Navn: {Name}");
            Console.WriteLine(Nationality == "" ? "Ikke registrert nasjonalitet." : $"Nasjonalitet: {Nationality}");
            Console.WriteLine(Group == "" ? "Ikke registrert gruppe." : $"Gruppe: {Group}");
            Console.WriteLine(Class == "" ? "Ikke registrert klasse." : $"Klasse: {Class}");
        }
    }
}
