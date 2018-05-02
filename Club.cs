using System;
using System.Collections.Generic;
using System.Linq;

namespace Startliste
{
    class Club
    {
        public List<Registration> ParticipantList;
        public List<StartingClass> StartingClassList;
        public string ClubName;
        public Club(string clubName)
        {
            ParticipantList = new List<Registration>();
            StartingClassList = new List<StartingClass>();
            ClubName = clubName;
        }

        public void AddParticipants(Registration participant)
        {
            ParticipantList.Add(participant);
            var @class = FindMatchingClass(participant) ?? AddNewClass(participant);
            @class.AddParticipant(participant);
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine(ClubName == "" ? "Ingen klubb" : ClubName);
            Console.WriteLine("Antall påmeldte i klubben: " + ParticipantList.Count);
            foreach (var startingClass in StartingClassList)
            {
                Console.WriteLine($"Det er {startingClass.ParticipantList.Count} i klassen {startingClass.Class}");
            }
        }

        private StartingClass AddNewClass(Registration participant)
        {
            var newClass = new StartingClass(participant.Class);
            StartingClassList.Add(newClass);
            return newClass;
        }

        private StartingClass FindMatchingClass(Registration participant)
        {
            return StartingClassList.FirstOrDefault(t => t.Class == participant.Class);
        }
    }
}
