using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrandCircusMarket
{
    public class FileIO
    {
        public void CreateDoc()
        {
            string menuPath = @"./MenuList.doc";
            using (StreamWriter sw = File.CreateText(menuPath))
            {
                sw.WriteLine("Please take some time to look at our menu of items stocked in the market");
                sw.WriteLine("Items  Stocked . . . . Price");
                sw.WriteLine("[1]Chicken . . . . $3");
                sw.WriteLine("[2]Beef . . . . $6");
                sw.WriteLine("[3]Fish . . . . $5");
                sw.WriteLine("[4]Pork . . . . $4");
                sw.WriteLine("[5]Apple . . . . $2");
                sw.WriteLine("[6]Orange . . . . $2");
                sw.WriteLine("[7]Kale . . . . $5");
                sw.WriteLine("[8]Spinach . . . . $4");
                sw.WriteLine("[9]Water . . . . $1");
                sw.WriteLine("[10]Juice . . . . $3");
                sw.WriteLine("[11]Coffee . . . . $2");
                sw.WriteLine("[12]Beer . . . . $6");
            }



                if (File.Exists(menuPath))
            
            {
                var menu = new List<string>();
                using(StreamReader sr = new StreamReader(menuPath))
                {
                    while (!sr.EndOfStream)
                    {
                        menu.Add(sr.ReadLine());
                    }
                    
                }
                foreach (string buildList in menu)
                {
                    Console.WriteLine(buildList);
                }
            }
        }
        
        
    }
}
