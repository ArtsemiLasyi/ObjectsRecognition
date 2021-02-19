using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsRecognition
{
    public static class Maximin
    {
        public static void SetFirstKernels(ref Entity[] entities, ref Cluster[] clusters)
        {
            Array.Resize(ref clusters, 1);
            clusters[0].Kernel = new Entity(entities[0].X, entities[0].Y);

            double max = double.MinValue;
            int index = 0;
            for (int i = 0; i < entities.Length; i++)
            {
                double distance = Algorithm.EvklidDistance(entities[i], clusters[0].Kernel);
                if (distance > max)
                {
                    index = i;
                    max = distance;
                }
            }
            Array.Resize(ref clusters, 2);
            clusters[1] = Generator.GenerateCluster(entities[index]);
        }


        public static double CountKernelDistance(ref Cluster[] clusters)
        {
            double distance = 0;
			int z = 0;
            for(int i = 0; i < clusters.Length - 1; i++)
            {
                for(int j = i; j < clusters.Length; j++)
                {
                    distance += Algorithm.EvklidDistance(clusters[i].Kernel, clusters[j].Kernel);
					z++;
                }
            }
            return distance / z;
        }

        public static bool TryCreateNewKernel(ref Entity[] entities, ref Cluster[] clusters)
        {
            double globalMax = double.MinValue;
            Entity global = new Entity(0, 0);
            for (int i = 0; i < clusters.Length; i++)
            {
                double max = double.MinValue;
                Entity local = new Entity(0, 0);
                foreach (var entity in clusters[i].entities)
                {
                    double distance = Algorithm.EvklidDistance(entity, clusters[i].Kernel);
                    if (distance > max)
                    {
                        local = entity;
                        max = distance;
                    }
                }
                if (max > globalMax)
                {
                    global = local;
                    globalMax = max;
                }
            }
            double kernelDistance = CountKernelDistance(ref clusters) / 2;
            if (globalMax > kernelDistance)
            {
                Array.Resize(ref clusters, clusters.Length + 1);
                clusters[clusters.Length - 1] = Generator.GenerateCluster(global);
                return true;
            }
            return false;
        }
    }
}
