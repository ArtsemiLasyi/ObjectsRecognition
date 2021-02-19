using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsRecognition
{
    public class Entity
    {
        public static Entity Generate(int xmin, int xmax, int ymin, int ymax)
        {
            var rand = new Random();
            return new Entity(rand.Next(xmin, xmax), rand.Next(ymin, ymax));
        }

        public int X { get; }

        public int Y { get; }

        public Entity(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
