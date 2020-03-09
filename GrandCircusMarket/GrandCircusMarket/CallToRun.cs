using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class CallToRun
    {

        public void RunPOSapp()
        {
            Console.WriteLine("Welcome to Grand Circus Market");
            var menu = new FileIO();
            menu.CreateDoc();
            var runMarketApp = new MenuRepo();
            runMarketApp.RedisplayMenu();
            
            
        }
    }
}
