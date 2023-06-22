


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

                    //let the user pick a user to use in the program
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
                    //letting the user pick a song 
                    Console.WriteLine("Pick a song(case sensetive):");
                    Console.WriteLine("-" + allesiskut.SongName);
                    Console.WriteLine("-" + allesisvegina.SongName);
                    Console.WriteLine("-" + omaenmij.SongName);
                    Console.WriteLine("-" + binchilling.SongName);
                    string PickSong = Console.ReadLine();
                    if (PickSong == "alles is kut")
                    {
                        Console.WriteLine("*Playing alles is kut*");
                        //giving the user the option to pause/skip the song
                        Console.WriteLine("Commands: *skip*, *pause*");
                        string nummerCommand = Console.ReadLine();
                        if (nummerCommand == "skip")
                        {
                            //*next song*
                            Console.WriteLine("*playing next song*");
                            break;
                        }else if(nummerCommand == "pause")
                        {
                            //*paused song*
                            Console.WriteLine("*song paused* type play to continue");
                            string nogeennummercommand = Console.ReadLine();
                            if (nogeennummercommand == "play")
                            {
                                //*continuing song*
                                Console.WriteLine("continuing song");
                                break;
                            }
                        }else
                        {
                            Console.WriteLine("command not reconigned continuing");
                            break;
                        }
                        
                        break;

                    }else if(PickSong == "allesisvegina")
                    {
                        Console.WriteLine("*Playing allesisvegina*");
                        Console.WriteLine("Commands: *skip*, *pause*");
                        string nummerCommand = Console.ReadLine();
                        if (nummerCommand == "skip")
                        {
                            Console.WriteLine("*playing next song*");
                            break;
                        }
                        else if (nummerCommand == "pause")
                        {
                            Console.WriteLine("*song paused* type play to continue");
                            string nogeennummercommand = Console.ReadLine();
                            if (nogeennummercommand == "play")
                            {
                                Console.WriteLine("continuing song");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("command not reconigned continuing");
                            break;
                        }
                        break;
                    }else if(PickSong == "omaenmij")
                    {
                        Console.WriteLine("*Playing omaenmij*");
                        Console.WriteLine("Commands: *skip*, *pause*");
                        string nummerCommand = Console.ReadLine();
                        if (nummerCommand == "skip")
                        {
                            Console.WriteLine("*playing next song*");
                            break;
                        }
                        else if (nummerCommand == "pause")
                        {
                            Console.WriteLine("*song paused* type play to continue");
                            string nogeennummercommand = Console.ReadLine();
                            if (nogeennummercommand == "play")
                            {
                                Console.WriteLine("continuing song");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("command not reconigned continuing");
                            break;
                        }
                        break;
                    }
                    else if (PickSong == "bingchilling")
                    {
                        Console.WriteLine("*Playing bingchilling*");
                        Console.WriteLine("Commands: *skip*, *pause*");
                        string nummerCommand = Console.ReadLine();
                        if (nummerCommand == "skip")
                        {
                            Console.WriteLine("*playing next song*");
                            break;
                        }
                        else if (nummerCommand == "pause")
                        {
                            Console.WriteLine("*song paused* type play to continue");
                            string nogeennummercommand = Console.ReadLine();
                            if (nogeennummercommand == "play")
                            {
                                Console.WriteLine("continuing song");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("command not reconigned continuing");
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("did not reconige song, please try again");
                    }
                }


                //giving the user the option to make a playlist
                Console.WriteLine("do you want to make a playlist? yes or no:");
                string vraagmakenplaylist = Console.ReadLine();
                if (vraagmakenplaylist == "yes")
                {
                    while (true)
                    {
                        //getting input for the playlist
                        Console.WriteLine("name your playlist");
                        string naamie = Console.ReadLine();

                        //check createplaylist class file to see how we add numbers
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

                //letting the user add a song (only works while program is running, after closing the added input will be lost)
                Console.WriteLine("would you like to add a song for you to listen to?");
                string nummeradden = Console.ReadLine();
                if (nummeradden == "yes")
                {
                    while(true)
                    {
                        Console.WriteLine("name of the song?:");
                        string naamnummer = Console.ReadLine();
                        Console.WriteLine("artiestname?:");
                        string artiest = Console.ReadLine(); 
                        Console.WriteLine("nummer ganre?:");
                        string genre = Console.ReadLine();
                        Console.WriteLine("id (weghalen)?:");
                        int nummerd = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" song duration?:");
                        double duur = Convert.ToDouble(Console.ReadLine());

                        nummer testnummer = new(naamnummer, artiest, genre, nummerd, duur);
                        Console.WriteLine(testnummer.SongName);

                        Console.WriteLine("would you like to add another song?:");
                        string nogeennumer = Console.ReadLine();
                        if (nogeennumer == "no")
                        {
                            break;
                        }
                        
                    }
                }

                break;
            }





 

            
            //hier word de list aangeroepen waar de users in staan
            List<User> users = new List<User>();

            //deze whileloop zorgt ervoor dat je vrienden kan toevoegen door zijn naam in te typen
            while (true)
            {
                Console.WriteLine("Enter a name (or 'done' to finish):");
                string inputFriendName = Console.ReadLine();

                //als de gebruiker done in typed dan sluit hij de window om gebruikers toetevoegen
                if (inputFriendName.ToLower() == "done")
                {
                    break;
                }


                
                //hier voegt hij de gebruiker toe aan je vriendenlijst
                User newUser = new User(users.Count + 1, inputFriendName);
                users.Add(newUser);

                Console.WriteLine("Enter the names of friends for {0} (separated by commas):", inputFriendName);
                string friendsInput = Console.ReadLine();
               
                //deze if zorgt ervoor dat je wel iets intyped dus als je niks intyped dan zegt hij dat de inputfield leeg is
                if (string.IsNullOrEmpty(friendsInput) || string.IsNullOrWhiteSpace(friendsInput))
                {
                    Console.WriteLine("Sorry, your name is empty. Please enter again.");
                 continue;
                }
                string[] friendNames = friendsInput.Split(',');

                //hier laat hij de vrienden zien die in de lijst staan
                foreach (string friendName in friendNames)
                {
                    User friend = users.Find(u => u.Name == friendName.Trim());

                    if (friend != null)
                    {
                        newUser.FriendList.Add(friend);
                        friend.FriendList.Add(newUser);
                    }
                    // als de gebruiker nog niet bestaat dan slaat hij die naam over en moet je een nieuwe naam intypen
                    else
                    {
                        Console.WriteLine("User '{0}' does not exist. Skipping.", friendName.Trim());
                    }
                }
            }


            //hier word de functie aangemaakt dat je een vriend laat verwijderen uit je lijst
                    Console.WriteLine("Enter the name of the user from which you want to remove a friend:");
        string inputUserName = Console.ReadLine();

        User userToRemoveFriend = users.Find(u => u.Name == inputUserName.Trim());

            
        if (userToRemoveFriend != null)
        {
            Console.WriteLine("Enter the name of the friend you want to remove:");
            string inputFriendName = Console.ReadLine();
                //hier gaat hij de naam zoeken die je hebt ingetyped zodat hij verwijderd word uit je lijst
            User friendToRemove = userToRemoveFriend.FriendList.Find(f => f.Name == inputFriendName.Trim());

            if (friendToRemove != null)
            {
                userToRemoveFriend.RemoveFriend(friendToRemove);
                friendToRemove.RemoveFriend(userToRemoveFriend);
                Console.WriteLine("Friend '{0}' has been removed from '{1}'s friend list.", inputFriendName, inputUserName);
            }

            else
            {
                Console.WriteLine("Friend '{0}' does not exist in '{1}'s friend list.", inputFriendName, inputUserName);
            }
        }
        //als de naam niet bestaat moet je de naam nog een keer intypen
        else
        {
            Console.WriteLine("User '{0}' does not exist.", inputUserName);
        }

              








        }
    }
}