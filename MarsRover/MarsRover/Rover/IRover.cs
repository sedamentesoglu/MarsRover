using MarsRover.Plateau;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App
{
    public interface IRover
    {
        int XPosition { get; set; }
        int YPosition { get; set; }
        string headingPositon { get; set; }
        string Process { get; set; }
        int heading { get; set; }
        string[] position { get; set; }
        IPlateau Plateau { get; }
    }
}
