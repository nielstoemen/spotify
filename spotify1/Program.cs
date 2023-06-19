
using System.Xml.Linq;

namespace spotify1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<<<<<<<<<<creating database for user interaction>>>>>>>>>>>>>//
            //creating songs
            nummer allesiskut = new("alles is kut", "jemoeder", "drama", 34, 2.44);
            nummer allesisvegina = new("allesisvegina", "jevader", "insulting", 33, 1.50);
            nummer omaenmij = new("omeenmij", "insestboys", "disturbing", 1, 5.3);
            nummer binchilling = new("bingchilling", "bingchingelingdongdongboys", "chilling", 1, 5.3);

            //Console.WriteLine(allesiskut.SongName);
            //Console.WriteLine(allesisvegina.SongName);
            //Console.WriteLine(omaenmij.SongName);


            //creating users

            User keyUser = new(1, "keyUser");
            User Robin = new(2, "robin");
            User Niels = new(3, "niels");
            User Robberto = new(4, "roberto");


            //Console.WriteLine(keyUser.Name);
            //Console.WriteLine(Robin.Name);
            //Console.WriteLine(Niels.Name);
            //Console.WriteLine(Robberto.Name);


            //creating artists

            artist stellar = new ("stellar");
            artist nf = new("NF");
            artist DPC = new("DPC");

            //Console.WriteLine(stellar.Name);
            //Console.WriteLine(nf.Name);
            //Console.WriteLine(DPC.Name);

            //creating playlists

            playlist keyuser = new ("keyuserplaylist", 2, 1, 25, 45.3);

            //<<<<<<<<<<<<<<<<<<<ending create databse>>>>>>>>>>>>>>>>>>






            List<User> users = new List<User>();

            while (true)
            {
                Console.WriteLine("Enter a name (or 'done' to finish):");
                string inputFriendName = Console.ReadLine();

                if (inputFriendName.ToLower() == "done")
                {
                    break;
                }


                    

                User newUser = new User(users.Count + 1, inputFriendName);
                users.Add(newUser);

                Console.WriteLine("Enter the names of friends for {0} (separated by commas):", inputFriendName);
                string friendsInput = Console.ReadLine();
               
                if (string.IsNullOrEmpty(friendsInput) || string.IsNullOrWhiteSpace(friendsInput))
                {
                    Console.WriteLine("Sorry, your name is empty. Please enter again.");
                 continue;
                }
                string[] friendNames = friendsInput.Split(',');

                foreach (string friendName in friendNames)
                {
                    User friend = users.Find(u => u.Name == friendName.Trim());

                    if (friend != null)
                    {
                        newUser.FriendList.Add(friend);
                        friend.FriendList.Add(newUser);
                    }
                    else
                    {
                        Console.WriteLine("User '{0}' does not exist. Skipping.", friendName.Trim());
                    }
                }
            }





           



        }
    }
}