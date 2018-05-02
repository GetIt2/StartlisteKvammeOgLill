using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var clubList = new List<Club>();
            foreach (var line in File.ReadLines("startlist.csv").Skip(1))
            {
                var participant = new Registration(line);
                var club = FindMatchingClub(participant, clubList) ?? AddNewClubb(participant, clubList);
                club.AddParticipants(participant);
            }
            foreach (var club in clubList)
            {
                club.Print();
            }
        }

        private static Club FindMatchingClub(Registration participant, List<Club> clubList)
        {
            return clubList.FirstOrDefault(t => t.ClubName == participant.Club);
        }

        private static Club AddNewClubb(Registration participant, List<Club> clubList)
        {
            var newClub = new Club(participant.Club);
            clubList.Add(newClub);
            return newClub;
        }
    }
}
