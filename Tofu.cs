using System;
using System.Collections.Generic;

namespace multifabriken_Muzze1994
{
    class Tofu
    {


        public Tofu()
        {
            tofu = new List<string>();
        }
        public int Volume
        {
            get { return volume; }
            set { volume = value; }

        }

        public string Spice
        {
            get { return spice; }
            set { spice = value; }
        }

       
        private string spice;
        private int volume;
        List<string> tofu;

    }
}
