﻿


namespace spotify1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<<<<<<<<<<creating database for user interaction>>>>>>>>>>>>>//
            //creating songs
            nummer allesiskut = new("alles is kut", "jemoeder", "drama", 1, 2.44);
            nummer allesisvegina = new(" allesisvegina", "jevader", "insulting", 2, 1.50);
            nummer omaenmij = new("omeenmij", "insestboys", "disturbing", 3, 5.3);
            nummer binchilling = new("bingchilling", "bingchingelingdongdongboys", "chilling", 4, 5.3);

            //Console.WriteLine(allesiskut.SongName);
            //Console.WriteLine(allesisvegina.SongName);
            //Console.WriteLine(omaenmij.SongName);


            //creating users

            User keyUser = new(1, "keyUser");
            User Robin = new(2, "Robin");
            User Niels = new(3, "Niels");
            User Robberto = new(4, "Roberto");


            //Console.WriteLine(keyUser.Name);
            //Console.WriteLine(Robin.Name);
            //Console.WriteLine(Niels.Name);
            //Console.WriteLine(Robberto.Name);


            //creating artists

            artist stellar = new (1,"stellar");
            artist nf = new(2,"NF");
            artist DPC = new(3,"DPC");

            //Console.WriteLine(stellar.Name);
            //Console.WriteLine(nf.Name);
            //Console.WriteLine(DPC.Name);

            //creating playlists

            playlist keyuser = new ("keyuserplaylist", 2, 1, 25, 45.3);

            //<<<<<<<<<<<<<<<<<<<ending create databse>>>>>>>>>>>>>>>>>>


            string CurrentUser;
            while (true) 
            {
                
                 while (true)
                {
                    Console.WriteLine("pick a user (case sensetive):");
                    Console.WriteLine("-" + keyUser.Name);
                    Console.WriteLine("-" + Robin.Name);
                    Console.WriteLine("-" + Niels.Name);
                    Console.WriteLine("-" + Robberto.Name);
                    string pickUser = Console.ReadLine();
                    if (pickUser == "keyUser")
                    {
                        CurrentUser = "keyUser";
                        break;
                    }
                    else if (pickUser == "Robin")
                    {
                        CurrentUser = "Robin";
                        break;
                    }
                    else if (pickUser == "Niels")
                    {
                        CurrentUser = "Niels";
                        break;
                    }
                    else if (pickUser == "Robberto")
                    {
                        CurrentUser = "Robberto";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong user try again");
                    }
                }


                while (true)
                {
                    Console.WriteLine("Pick a song(case sensetive):");
                    Console.WriteLine("-" + allesiskut.SongName);
                    Console.WriteLine("-" + allesisvegina.SongName);
                    Console.WriteLine("-" + omaenmij.SongName);
                    Console.WriteLine("-" + binchilling.SongName);
                    string PickSong = Console.ReadLine();
                    if (PickSong == "alles is kut")
                    {
                        Console.WriteLine("*Playing alles is kut*");
                        break;
                    }else if(PickSong == "allesisvegina")
                    {
                        Console.WriteLine("*Playing allesisvegina*");
                        break;
                    }else if(PickSong == "omaenmij")
                    {
                        Console.WriteLine("*Playing omaenmij*");
                        break;
                    }
                    else if (PickSong == "bingchilling")
                    {
                        Console.WriteLine("*Playing bingchilling*");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("did not reconige song, please try again");
                    }
                }


                Console.WriteLine("do you want to make a playlist? yes or no:");
                string vraagmakenplaylist = Console.ReadLine();
                if (vraagmakenplaylist == "yes")
                {
                    while (true)
                    {
                        Console.WriteLine("name your playlist");
                        string naamie = Console.ReadLine();

                        CreatePlaylist test = new CreatePlaylist(naamie);
                        //Console.WriteLine(test.PlaylistName);
                        Console.WriteLine("do you want to make another playlist? yes or no:");
                        string makeanotherplaylistquestion = Console.ReadLine();
                        if (makeanotherplaylistquestion == "no")
                        {
                            break;
                        }
                    }
                }



                break;
            }




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