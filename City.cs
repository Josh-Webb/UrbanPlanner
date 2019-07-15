using System;
using System.Collections.Generic;

namespace Planner{

    class City
    {
        private string _name;

        // public string Name { get; set; }

        private string _mayor;

        // public string Mayor { get; set; }

        private int _yearEstablished;


        public string Name {
            get
            {
                return _name;
            }
        }

        public string Mayor {
            get
            {
                return _mayor;
            }
        }

        public int YearEstablished {
            get
            {
                return _yearEstablished;
            }
        }

        public City(string name){
            _name = name;
            _yearEstablished = DateTime.Now.Year;
        }

        public void Elect(string mayor){
            _mayor = mayor;
        }



        public List<Building> Buildings = new List<Building>(); 

        List<string> city = new List<string>();

    }
}