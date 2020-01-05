using MarsRover.Plateau;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App
{
    public class Rover : IRover
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string headingPositon { get; set; }
        public string Process { get; set; }
        public int heading { get; set; }
        public string[] position { get; set; }
        public IPlateau Plateau { get; }

        public Rover(string[] roverCoordinates, string roverOrientation, Plateau plateau)
        {
            Plateau = plateau;
            XPosition = Convert.ToInt32(roverCoordinates[0]);
            YPosition = Convert.ToInt32(roverCoordinates[1]);
            headingPositon = roverCoordinates[2];
            Process = roverOrientation.Trim();
            position = new string[] { "N", "E", "S", "W" };
        }
        public void RoverMove()
        {
            char[] move = Process.Trim().ToCharArray();
            for (int i = 0; i < move.Length; i++)
            {
                if (move[i] == 'L' || move[i] == 'R')
                {
                    Turn(move[i]);
                }
                else if (move[i] == 'M')
                {
                    Move();
                }
            }
            if ((XPosition > Plateau.XCoordinate || XPosition < 0) || (YPosition > Plateau.YCoordinate || YPosition < 0))
            {
                Console.WriteLine("The Rover is out of the specified coordinate. Rover's coordinate:" + XPosition + " " + YPosition + " " + headingPositon + " ");
            }
            else
            {
                Console.WriteLine("Rover's coordinate:" + XPosition + " " + YPosition + " " + headingPositon + " ");
            }
        }
        public void Turn(char move)
        {
            switch (headingPositon)
            {
                case "N":
                    heading = 0;
                    break;

                case "E":
                    heading = 1;
                    break;

                case "S":
                    heading = 2;
                    break;

                case "W":
                    heading = 3;
                    break;
            }
            if (move == 'L')
            {
                headingPositon = position[((heading - 1) + 4) % 4];
            }
            else
            {
                headingPositon = position[((heading + 1)) % 4];
            }

        }
        public void Move()
        {
            if (headingPositon == "N")
            {
                YPosition++;
            }
            else if (headingPositon == "E")
            {
                XPosition++;
            }
            else if (headingPositon == "S")
            {
                YPosition--;
            }
            else if (headingPositon == "W")
            {
                XPosition--;
            }
        }
    }
}

