using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsRecognition
{
    public static class Kmeans
    {
        private static double CountDistance(Entity entity, List<Entity> entities)
        {
            double distance = 0;
            foreach (var ent in entities)
            {
                distance += Math.Pow(Algorithm.EvklidDistance(entity, ent), 2);
            }
            return distance;
        }

        public static bool UpdateKernels(ref Cluster[] clusters)
        {
            bool flag = false;
            Task<Entity>[] tasks = new Task<Entity>[clusters.Length];
            for (int i = 0; i < clusters.Length; i++)
            {
                Entity kernel = clusters[i].Kernel;
                List<Entity> entities = clusters[i].entities;
                tasks[i] = new Task<Entity>(() => UpdateKernel(kernel, entities));
                tasks[i].Start();
            }
            for (int i = 0; i < clusters.Length; i++)
            {
                if (clusters[i].Kernel.X != tasks[i].Result.X || clusters[i].Kernel.Y != tasks[i].Result.Y)
                {
                    clusters[i].Kernel = tasks[i].Result;
                    flag = true;
                }
            }
            return flag;
        }

        public static Entity UpdateKernel(Entity kernel, List<Entity> entities)
        {
            double distance;
            Entity newKernel = new Entity(kernel.X, kernel.Y);
            Task<double> kernelDistanceTask = new Task<double>(() => CountDistance(kernel, entities));
            kernelDistanceTask.Start();
            foreach (var entity in entities)
            {
                double newDistance = CountDistance(entity, entities);
                distance = kernelDistanceTask.Result;
                if (newDistance < distance)
                {
                    distance = newDistance;
                    newKernel = entity;
                }
            }
            return newKernel;
        }
    }
}
