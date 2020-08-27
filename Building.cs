using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "David Bruce";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public string Name { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth;
            }
        }

        public Building(string address)
        {
            _address = address;
            Name = _address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void PrintReport()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }
    }
}