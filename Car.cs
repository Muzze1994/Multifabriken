using System;
using System.Collections.Generic;

namespace multifabriken_Muzze1994
{
    class Car
    {
        public Car()
        {
            car = new List<string>();
        }
        public string Regnr
        {
            get { return regnr; }
            set { regnr = value; }

        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string regnr;
        private string color;
        private string brand;

        List<string> car;
    }
}
