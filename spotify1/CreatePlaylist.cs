


namespace spotify1;

public class CreatePlaylist
{
    public string PlaylistName { get; set; }
    List<int> Playlist = new List<int>();

    public CreatePlaylist( string naampje)
    {
        Playlist = new List<int>();
        PlaylistName = naampje;
        Console.WriteLine("name a song you want in here (case sensetive):");
        string songinput = Console.ReadLine();
        if (songinput == "alles is kut")
        {
            Playlist.Add(1);
            Console.WriteLine("song added");

        }
        else if (songinput == "allesisvegina")
        {
            Playlist.Add(2);
            Console.WriteLine("song added");

        }
        else if (songinput == "omaenmij")
        {
            Playlist.Add(3);
            Console.WriteLine("song added");

        }
        else if (songinput == "bingchilling")
        {
            Playlist.Add(4);
            Console.WriteLine("song added");

        }
        else
        {
            Console.WriteLine("did not reconige song, please try again");
        }

        Console.WriteLine("Would you like to add another song? yes or no:");
        string antwoord = Console.ReadLine();
        if (antwoord == "yes")
        {
            while (true)
            {
                Console.WriteLine("pick a song");
                string songje = Console.ReadLine();
                if (songje == "alles is kut")
                {
                    Playlist.Add(1);
                    Console.WriteLine("song added");

                }
                else if (songje == "allesisvegina")
                {
                    Playlist.Add(2);
                    Console.WriteLine("song added");

                }
                else if (songje == "omaenmij")
                {
                    Playlist.Add(3);
                    Console.WriteLine("song added");

                }
                else if (songje == "bingchilling")
                {
                    Playlist.Add(4);
                    Console.WriteLine("song added");

                }
                else
                {
                    Console.WriteLine("did not reconige song, please try again");
                }
                Console.WriteLine("another song? yes or no:");
                string nogeenantwoord = Console.ReadLine();
                if(nogeenantwoord == "no")
                {
                    break;
                }
            }


        }










    }


}
