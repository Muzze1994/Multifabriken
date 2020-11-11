using System;
namespace multifabriken_Muzze1994
{
    class Car
    {

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
    }
}
