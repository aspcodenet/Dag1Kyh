using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dag1Kyh
{
    internal class Application
    {
        public void Run()
        {
            //a.Skapa en variabel string name med ditt namn
            //b.Skapa en int age med din ålder.
            //c.Skriv sedan ut Jag heter Kalle(innehållet i name) och är 27(innehållet i age) år.
            string name; //skapas lådas
            name = "Stefan"; //tilldelning

            //string name = "Stefan";
            //var name = "Stefan"; MEST C#-iga 

            int ageInYears = 50;
            //Console.WriteLine("Jag heter Kalle och är 27 år");

            //Console.Write("Jag heter ");
            //Console.Write(name);
            //Console.Write(" och är ");
            //Console.Write(ageInYears);
            //Console.Write(" år");

            Console.WriteLine("Jag heter " + name + " och är " + ageInYears + " år");

            //Den C-sharpigaste lösningen 2022
            Console.WriteLine($"Jag heter {name} och är {ageInYears} år");



            /*
            a. Skriv ut Skriv in ditt förnamn: . Ta emot värdet i en variabel
            b. Låt markören vänta på din inmatning på samma rad.
            c. Gör på samma sätt med efternamnet.
            d. Skriv sedan ut namnen i omvänd ordning.
            e. Se till att resultatet ser ut så här.
             */
            Console.Write("Skriv in ditt förnamn:");
            string firstName = Console.ReadLine();
            Console.Write("Skriv in ditt efternamn:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Du heter {lastName}, {firstName}");







            //sdas
            //    asddsa

            // int year; // 0 , 33321321,-234432423
            //year = 2022;

            // float betygSnitt;
            // betygSnitt = 3.64f;


            // string title;
            // title = "Mr"; // char

            // string namnet;
            // namnet = "Stefan"; // char

            // string efternamnet;
            // efternamnet = "Holmberg"; // char

            // string fullName = title + " " + namnet + " " + efternamnet;
            // Console.WriteLine(fullName);


            // int summa = (year + 12 + 99)/12;


            // bool isCool;  // true false
            // isCool = false;

            // string s = "2022";
            // int t = 2022;

            // int age;
            // Console.WriteLine("Hur gammal är du?");

            // string inmatning = Console.ReadLine();
            // int talet = Convert.ToInt32(inmatning);

            // age = Convert.ToInt32(Console.ReadLine());
            // age = age + 1;
            // age++;

            // age = age + 5;
            // //age += 5;
            // // age += 5; SAMMA SOM OVAN
            // //age *= 5;

            // age = age + 1;
            // // age += 1; SAMMA SOM OVAN
            // // age++;  SAMMA SOM OVAN MEST VANLIGT
            // // age--;


            // Console.WriteLine("Om 5 år är du:" );
            // Console.WriteLine(age);




            // Console.WriteLine("Vad heter du?");
            // string namn = Console.ReadLine();
            // Console.WriteLine("Hejsan " + namn);


            // Console.WriteLine("2022-11-24");
            // Console.WriteLine(2022-11-24);
            // Console.WriteLine("Hello");
            // Console.WriteLine("Hej då " + namn);
        }
    }
}
