using System;

namespace GalacticGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Location home = new Location(18.037986, 28.870097, Planet.Earth);
                Location melmak = new Location(89.999333, 39.323222, Planet.Mars);

                Console.WriteLine(home);
                Console.WriteLine(melmak);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid data.");
            }
        }
    }
}
