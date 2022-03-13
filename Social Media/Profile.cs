using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Social_Media
{
    public class Profile : IProfileList
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public List<Profile> FriendList { get; set; }

        public Profile(string name, string id, string description = " ")
        {
            Id = id;
            Name = name;
            Description = description;
            FriendList = new List<Profile>() { };
        }

        public void PrintFriends()
        {
            foreach (var friend in FriendList)
            {
                var name = friend.Name;
                var description = friend.Description;
                var id = friend.Id;
                Console.WriteLine("name: " + name + " description: " + description + " id: " + id);
            }
        }

       


        public Profile FindProfileById(string id)
        {
            return FriendList.FirstOrDefault(friend => friend.Id == id);
        }

        public Profile FindProfileByName(string name)
        {
            //return FriendList.Find(name);
            return FriendList.FirstOrDefault(friend => friend.Name == name);

        }

        public void RemoveFriend(string id)
        {
           var friendtoremove = FindProfileById(id);
           FriendList.Remove(friendtoremove);
            // let i listen av alle som er i vennelisten og fjern den som har den ID'en du sendte med
                
        }

        public void AddToProfileList(Profile friend)
        {
            FriendList.Add(friend);
        }
    }
}
