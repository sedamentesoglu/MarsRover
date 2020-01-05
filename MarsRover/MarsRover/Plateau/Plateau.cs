using MarsRover.Plateau;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App
{
    public class Plateau : IPlateau
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Plateau(string[] plateauCoordinates)
        {
            XCoordinate = Convert.ToInt16(plateauCoordinates[0]);
            YCoordinate = Convert.ToInt16(plateauCoordinates[1]);
        }
    }
}
