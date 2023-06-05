
namespace spotify1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User keyUser = new(1, "niels");
            artist artist = new("kuthond");
            //debug lines
            Console.WriteLine(keyUser.Name + " " + keyUser.UserID + " " + artist.Name);
        }
    }
}