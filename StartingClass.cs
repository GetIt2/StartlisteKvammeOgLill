using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startliste
{
    class StartingClass
    {
        public List<Registration> ParticipantList;
        public string Class;

        public StartingClass(string startingClass)
        {
            Class = startingClass;
            ParticipantList = new List<Registration>();
        }

        public void AddParticipant(Registration participant)
        {
            ParticipantList.Add(participant);
        }
    }
}
