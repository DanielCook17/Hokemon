using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon // Inheriting from hokemon base class
    {
        public string team = "Halor";
        public string colour = "Red";

        public void definition()
        {
            Console.WriteLine("I am {0}, I am part of the ferocious Halor tribe!\n", Name);
        }
    }

}
