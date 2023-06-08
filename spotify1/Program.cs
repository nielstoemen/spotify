
namespace spotify1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person();


            Console.WriteLine("Enter username:");
            user.Username = Console.ReadLine();
            Console.WriteLine("Username is: " + user.Username);
            user.accountcode = 12345;

          

          

        }
    }
}