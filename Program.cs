using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEighth = new Building("512 8th Avenue");

            FiveOneTwoEighth.Stories = 13;
            FiveOneTwoEighth.Width = 100.20;
            FiveOneTwoEighth.Depth = 110.20;
            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Damien Thorne");

            FiveOneTwoEighth.PrintReport();

            Building SixOneEightSecond = new Building("618 2nd Avenue");
            SixOneEightSecond.Stories = 2;
            SixOneEightSecond.Width = 230.20;
            SixOneEightSecond.Depth = 410.20;
            SixOneEightSecond.Construct();
            SixOneEightSecond.Purchase("Garth Brooks");
            SixOneEightSecond.PrintReport();

            Building FourThreeTwoFirst = new Building("432 1st Avenue");
            FourThreeTwoFirst.Stories = 4;
            FourThreeTwoFirst.Width = 330.20;
            FourThreeTwoFirst.Depth = 310.20;
            FourThreeTwoFirst.Construct();
            FourThreeTwoFirst.Purchase("Martha Ingram");
            FourThreeTwoFirst.PrintReport();

            Console.WriteLine("-----------City----------");
            City Megapolis = new City("Megapolis");
            Megapolis.mayor = "Andrew Cuomo";
            Megapolis.AddBuilding(FiveOneTwoEighth);
            Megapolis.AddBuilding(FourThreeTwoFirst);
            Megapolis.ListBuildings();
        }
    }
}