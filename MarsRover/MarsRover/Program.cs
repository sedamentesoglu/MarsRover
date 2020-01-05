using System;
using System.Collections.Generic;

namespace MarsRover.App
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter upper-right coordinates of the plateau lower left coordinates 0,0. Input example, (5 5) ");
            string[] plateauCoordinates = (Console.ReadLine()).Split(" ");

            Plateau plateau = new Plateau(plateauCoordinates);

            Console.WriteLine("Please enter rover landing coordinates. Input example, (1 2 N) (North:'N', South:'S', East:'E', West:'W') ");
            string[] roverCoordinates = (Console.ReadLine().ToUpper()).Split(" ");

            if ((Convert.ToInt32(roverCoordinates[0]) > plateau.XCoordinate || (Convert.ToInt32(roverCoordinates[0]) < 0)) || ((Convert.ToInt32(roverCoordinates[1])) > plateau.YCoordinate || (Convert.ToInt32(roverCoordinates[1]) < 0)))
            {
                Console.WriteLine("The Rover is out of the specified coordinate.");
            }
            else
            {
                Console.WriteLine("Please enter rover's orientation. Input example, (LMLMLMLMM) ");
                string roverOrientation = Console.ReadLine().ToUpper();

                Rover rover = new Rover(roverCoordinates, roverOrientation, plateau);
                rover.RoverMove();
            }

            Console.ReadKey();
        }
    }
}
