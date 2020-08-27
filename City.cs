using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _name;
        public string mayor;
        private int _established;
        private Dictionary<string, Building> buildingCollection { get; set; }

        public City(string name)
        {
            buildingCollection = new Dictionary<string, Building>();
            _established = DateTime.Now.Year;
            _name = name;
        }

        public void AddBuilding(Building aBuilding)
        {
            buildingCollection.Add(aBuilding.Name, aBuilding);
        }

        public void ListBuildings()
        {
            Console.WriteLine($"{_name} established {_established}");
            Console.WriteLine($"Mayor: ${mayor}");
            foreach (KeyValuePair<string, Building> aBuilding in buildingCollection)
            {
                Console.WriteLine(aBuilding.Value.Name);
            }
        }
    }
}