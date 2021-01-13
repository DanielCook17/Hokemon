using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon");

            // Instantiation of new Hokemon

            Hokemon hoke01 = new Hokemon(); // Instantiate new Hokemon object to as Hoke01 

            hoke01.get_details();

            Enemy_Hokemon hoke02 = new Enemy_Hokemon();

            hoke02.get_details();


        }
    }
}
