using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsSingleton
{
    public class Singleton
    {
        private static Singleton instance;      // our lonely Singleton object
        
        private string teamName = null;

        // constructor is private
        private Singleton(string newName)
        {
            teamName = newName;
        }

        // allow access to the Singleton when trying to join a team
        public static Singleton getInstance(string newName)
        {
            // ensure only one Singleton object exists (thus instance = null)
            if (instance == null)
            {
                instance = new Singleton(newName);
            }

            // we now have a Singleton
            return instance;
        }

        // get the current team name stored in the Singleton
        public string getTeamName()
        {
            return instance.teamName;
        }

        // delete the Singleton, allowing for a new Singleton to be made
        public void delete()
        {
            instance = null;
        }
    }
}
