using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    public class UserDatabase : IProfileList
    {
        public List<Profile> Users { get; set; }


        public UserDatabase()
        {
            Users = new List<Profile>()
            {
                new Profile("Kristian", "1", "Koder for Nasa"),
                new Profile("John Espen", "2", "Er på ferie"),
                new Profile("Stian", "3", "Leser historiebøker"),
                new Profile("Kristoffer", "4", "Er skalla"),
                new Profile("Stigh", "5", "Elsker Stavern"),
                new Profile("Marius", "6", "Lever for Elden Ring"),
                new Profile("Geir", "7", "lever for Elden ring også"),
                new Profile("Lillie", "8", "Pro i C# og Unity"),
            };
        }

        public void AddToProfileList(Profile profile)
        {
            Users.Add(profile);
        }

        public Profile FindProfileById(string id)
        {
            return Users.FirstOrDefault(profile => profile.Id == id);

        }

        public Profile FindProfileByName(string name)
        {
            return Users.FirstOrDefault(profile => profile.Name == name);


        }

    }
}
