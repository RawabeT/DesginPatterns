using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Client
    {
        public void Main()
        {
            //1. CritterFactory
            Console.WriteLine("\nClient request: Critter Factory\n");
            ClientReq(new CritterFactory());
            Console.WriteLine("-------------------");

            //2. StuzFactory
            Console.WriteLine("\nClient request: Stuz Factory\n");
            ClientReq(new StuzFactory());
            Console.WriteLine("-------------------");

        }

        public void ClientReq(IFontsAbstractFactory factory)
        {
            //1.Bold Request
            Console.WriteLine(factory.makeBoldFont()
                                     .writeIBoldAlphabatics());

            //2.Ilatic Request 
            Console.WriteLine(factory.makeIlaticFont()
                                     .writeIilaticAlphabatics());
        }
    }
}
