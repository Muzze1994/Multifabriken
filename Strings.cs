using System;
using System.Collections.Generic;

namespace multifabriken_Muzze1994
{
    class Strings
    {
         public Strings()
        {
            strings = new List<string>();
        }
        public string StringColor
        {
            get { return stringColor; }
            set { stringColor = value; }

        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }


        private int length;
        private string stringColor;

        List<string> strings;
    }
}
