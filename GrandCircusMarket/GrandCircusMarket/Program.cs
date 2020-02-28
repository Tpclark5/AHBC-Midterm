using System;

namespace GrandCircusMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Market");
            var menu = new FileIO();
            menu.CreateDoc();
            var tryOrderLogic = new MenuRepo();
            tryOrderLogic.selectMenuItem();


        }
    }
}
