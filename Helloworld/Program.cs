using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izsaucam sevis izveidotu funkciju
            SayHello();
            //Izsaucam otro izveidoto funkciju
            SayHelloToUser();
        }

        static void SayHelloToUser()
        {
            //paludzam lietotajam ievadit savu vardu
            //uzrakstot lugumu ekrana
            Console.WriteLine("Please enter your name");
            //izveidojam mainigo, kur glabāt lietotaja ievadito vertibu
            string usersName;
            //paprasam konsolei ievadit tekstu, saglabajam rezultatu mainigo
            usersName = Console.ReadLine();
            Console.WriteLine("Labdien," +usersName + "!");//reinis "Labdien Reinis!"
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
            Console.ReadLine();
        }
    }
}
