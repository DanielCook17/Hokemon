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

            Hokemon hoke02 = new Hokemon();

            hoke02.get_details();

            Hokemon hoke03 = new Hokemon();

            hoke03.get_details();
        }
    }
}
