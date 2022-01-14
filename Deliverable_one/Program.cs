using System;

namespace Deliverable_one 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                // input
                Console.WriteLine("How many people are we making PB & J sandwhiches for? ");
                int eaters = int.Parse(Console.ReadLine());

                // bread calculations 
                double SlicesNeeded = eaters * 2;
                double slicesPerLoaf = 28;
                int LoavesNeeded = (int)Math.Ceiling(SlicesNeeded / slicesPerLoaf);

                Console.WriteLine("You need:");
                Console.WriteLine(SlicesNeeded + " slices of bread");

                // PBJ calculations
                double pbjTbspNeeded = eaters * 2;
                double tbspPerPbj = 32;
                int JarsOfPbj = (int)Math.Ceiling(pbjTbspNeeded / tbspPerPbj);

                Console.WriteLine(tbspPerPbj + " tablespoons of peanut butter");

                // jelly calculations
                double jellytspNeeded = eaters * 4;
                double tspPerJelly = 48;
                int JarsOfJelly = (int)Math.Ceiling(jellytspNeeded / tspPerJelly);

                Console.WriteLine(tspPerJelly + " teaspoons of jelly");

                // output information
                Console.WriteLine("");
                Console.WriteLine("which is...");
                Console.WriteLine("");
                Console.WriteLine(LoavesNeeded + " loaves of bread.");
                Console.WriteLine(JarsOfPbj + " jars of PBJ.");
                Console.WriteLine(JarsOfJelly + " jars of jelly.");

                // run it again?
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                response = Console.ReadLine();
            } while (response == "y" || response == "yes");

        }
    }
}