using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ObjectsRecognition
{
    public static class Generator
    {
        private const int maxColorValue = 256;
        private static Random rand = new Random();

        public static Entity[] GenerateEntities(int number, int minxvalue, int maxxvalue, int minyvalue, int maxyvalue)
        {
            Entity[] entities = new Entity[number];
            for(int i = 0; i < number; i++)
            {
                entities[i] = Entity.Generate(minxvalue, maxxvalue, minyvalue, maxyvalue);
            }
            return entities;
        }

        public static Cluster[] GenerateClusters(int number, Entity[] entities)
        {
            Cluster[] clusters = new Cluster[number];
            for (int i = 0; i < number; i++)
            {
                clusters[i] = new Cluster();
                clusters[i].EntitiesColor = GenerateColor();
                clusters[i].Kernel = entities[i];
            }
            return clusters;
        }

        public static Cluster GenerateCluster(Entity kernel)
        {
            Cluster cluster = new Cluster();
            cluster.EntitiesColor = GenerateColor();
            cluster.Kernel = kernel;
            return cluster;
        }

        public static Color[] GenerateColors(int number)
        {
            Color[] colors = new Color[number];
            for (int i = 0; i < number; i++)
            {
                Color.FromArgb(rand.Next(maxColorValue), rand.Next(maxColorValue), rand.Next(maxColorValue));
            }
            return colors;
        }

        public static Color GenerateColor()
        {
            return Color.FromArgb(rand.Next(maxColorValue), rand.Next(maxColorValue), rand.Next(maxColorValue));
        }
    }
}
