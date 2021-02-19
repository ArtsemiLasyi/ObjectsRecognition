using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsRecognition
{
    public static class Algorithm
    {
        public static void ClearClusters(ref Cluster[] clusters)
        {
            for (int i = 0; i < clusters.Length; i++)
            {
                clusters[i].entities.Clear();
            }
        }

        public static double EvklidDistance(Entity a, Entity b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }

        public static void FillClusters(ref Entity[] entities, ref Cluster[] clusters)
        {
            for (int i = 0; i < entities.Length; i++)
            {
                int index = 0;
                double min = Double.MaxValue;
                for (int j = 0; j < clusters.Length; j++)
                {
                    double distance = Algorithm.EvklidDistance(entities[i], clusters[j].Kernel);
                    if (distance < min)
                    {
                        index = j;
                        min = distance;
                    }
                }
                clusters[index].entities.Add(entities[i]);
            }
        }
    }
}
