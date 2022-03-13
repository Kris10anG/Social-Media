using System;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace Social_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var profile = new Profile("Kristian", "1", "hei");
            var userdatabase = new UserDatabase();
            
            Console.WriteLine("Welcome to FriendFace\n");

                Console.WriteLine("Liste over folk du kanskje kjenner");
            for (int i = 0; i < userdatabase.Users.Count; i++)
            {
                string users = userdatabase.Users[i].Name;
                string id = userdatabase.Users[i].Id;
                Console.WriteLine("Name: " + users + " ID: " + id);
                //profile.RemoveFriend(id);
            }

            Console.WriteLine("Skriv inn Id på hvem du har lyst til å legge til i vennelista.\n");
            var command = Console.ReadLine();

            Console.WriteLine("Ønsker du å legge til flere i lista?\n");
            var command1 = Console.ReadLine();

            var AddFriend = userdatabase.FindProfileById(command);
            var AddSecondFriend = userdatabase.FindProfileById(command1);
            Console.WriteLine("Venneliste");


            profile.AddToProfileList(AddFriend);
            profile.AddToProfileList(AddSecondFriend);
            userdatabase.AddToProfileList(profile);
            profile.PrintFriends();

            Console.WriteLine("Ønkser du å fjerne noen fra listen?");
            var command2 = Console.ReadLine();
            profile.RemoveFriend(command2);
            profile.PrintFriends();


        }
    }
}

                //for (int i = 0; i < signinInfo.LoggedInList.Count; i++)
                //{
                //    var username = signinInfo.LoggedInList[i].Username;
                //    var psw = signinInfo.LoggedInList[i].Password;
                //    Console.WriteLine("username: " + username);
                //    Console.WriteLine("Please enter you're password!");
                //    var command = Console.ReadLine();
                //    if (command == psw)
                //    {
                //        Console.WriteLine("Welcome back, what do you want to do?");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Wrong password");
                //    }