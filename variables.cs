using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int cherryPies = 3;
            int applePies = 5;
            float cherryPiePrice = 8.90F;
            double applePiePrice = 7.56D;
            int totalPies = applePies + cherryPies;
            string myName = "Bryce";
            string bakeryName = "The Flying Pigs";
            char messageType = 'a';
            char formType = 'b';
            bool isBakery = true;
            bool customerIsHuman = true;
            
            if (isBakery)
            {
                Console.WriteLine("This is message type: " + messageType + formType);
                Console.WriteLine("This bakery is called " + bakeryName);
                Console.WriteLine("Welcome, " + myName+"!");
                Console.WriteLine("There are "+cherryPies+" cherry pies, and "+applePies+" apple pies.");
                Console.WriteLine("The cherry pies cost $" + cherryPiePrice + " each");
                Console.WriteLine("Apple pies cost $"+applePiePrice+" each")
                Console.WriteLine("There is a total of "+totalPies+" pies");
                Console.WriteLine(isBakery);
                if (customerIsHuman)
                {
                    Console.WriteLine("You are a human");
                    Console.WriteLine(customerIsHuman);
                }
                else
                {
                    Console.WriteLine("you are not a human");
                    Console.WriteLine(customerIsHuman);
                }

            }
        }
    }
}
