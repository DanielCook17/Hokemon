using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hinstinct : Hokemon
    {
        public string team = "Hinstinct";
        public string colour = "Yellow";

        public void definition()
        {
            Console.WriteLine("I am {0}, I am part of the deadly Hinstinct tribe!\n", Name);
        }
    }
}
