using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dag1Kyh
{
    internal class Application
    {
        public void Run()
        {

            int year; // 0 , 33321321,-234432423
            year = 2022;

            float betygSnitt;
            betygSnitt = 3.64f;


            string title;
            title = "Mr"; // char

            string namnet;
            namnet = "Stefan"; // char

            string efternamnet;
            efternamnet = "Holmberg"; // char

            string fullName = title + " " + namnet + " " + efternamnet;
            Console.WriteLine(fullName);


            int summa = (year + 12 + 99)/12;


            bool isCool;  // true false
            isCool = false;

            string s = "2022";
            int t = 2022;

            int age;
            Console.WriteLine("Hur gammal är du?");
            
            string inmatning = Console.ReadLine();
            int talet = Convert.ToInt32(inmatning);

            age = Convert.ToInt32(Console.ReadLine());
            age = age + 1;
            age++;

            age = age + 5;
            //age += 5;
            // age += 5; SAMMA SOM OVAN
            //age *= 5;

            age = age + 1;
            // age += 1; SAMMA SOM OVAN
            // age++;  SAMMA SOM OVAN MEST VANLIGT
            // age--;


            Console.WriteLine("Om 5 år är du:" );
            Console.WriteLine(age);




            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hejsan " + namn);


            Console.WriteLine("2022-11-24");
            Console.WriteLine(2022-11-24);
            Console.WriteLine("Hello");
            Console.WriteLine("Hej då " + namn);
        }
    }
}
