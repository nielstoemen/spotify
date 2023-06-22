

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
                        Console.WriteLine("Commands: *skip*, *pause*");
                        string nummerCommand = Console.ReadLine();
                        if (nummerCommand == "skip")
                        {
                            Console.WriteLine("*playing next song*");
                            break;
                        }else if(nummerCommand == "pause")
                        {
                            Console.WriteLine("*song paused* type play to continue");
                            string nogeennummercommand = Console.ReadLine();
                            if (nogeennummercommand == "play")
                            {
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








        }
    }
}