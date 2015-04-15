/* A ray of light comes in from the upper left corner of an MxN sized window, with 45° angled edges. 
The ray is reflected when it reaches the first or the last line, or the first or last column respectively. 
Display all the positions reached until the ray travels to a window corner. */

using System;
using System.Collections.Generic;

namespace SmallExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m = ReadM();
            int n = ReadN();

            var ex = new RayOfLightExercise()
                .ARayOfLightComesInAWindowOfSize(m, n)
                .FromTheUpperLeftCorner()
                .With45AngledEdges()
                .TravelUntilHasReachedACorner();

            Write(ex.PositionsReached);
            EnterAnyKeyToCloseTheProgram();
        }

        private static int ReadM()
        {
            return ReadIntFromConsole("M=");
        }

        private static int ReadN()
        {
            return ReadIntFromConsole("N=");
        }

        private static int ReadIntFromConsole(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void Write(IReadOnlyList<Position> positions)
        {
            foreach (var p in positions)
                Console.WriteLine(p);
        }

        private static void EnterAnyKeyToCloseTheProgram()
        {
            Console.ReadKey();
        }
    }
}
