using System;
using System.Collections.Generic;

namespace multifabriken_Muzze1994
{
    class Candy
    {
        public Candy()
        {
            candy = new List<string>();
        }
        public string Taste
        {
            get { return taste; }
            set { taste = value; }

        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        private int quantity;
        private string taste;

        List<string> candy;
    }
}
