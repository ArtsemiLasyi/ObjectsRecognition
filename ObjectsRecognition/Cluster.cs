using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ObjectsRecognition
{
    public class Cluster
    {
        public Entity Kernel { get; set; }

        public Color EntitiesColor { get; set; }

        public static Color kernelColor { get { return Color.Black; } }

        public List<Entity> entities;

        public Cluster()
        {
            entities = new List<Entity>();
        }
    }
}
