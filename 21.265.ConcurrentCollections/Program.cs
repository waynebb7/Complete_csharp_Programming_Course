﻿using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace _21._265.ConcurrentCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 100; i++)
            {
                var numberToAdd = i;
                tasks.Add(Task.Run(() => bag.Add(numberToAdd)));
            }

            Task.WaitAll(tasks.ToArray());

            List<Task> runningTasks = new List<Task>();
            int numberOfItems = 0;
            while (!bag.IsEmpty)
            {
                runningTasks.Add(Task.Run (() =>
                {
                    int item;
                    if (bag.TryTake(out item))
                    {
                        System.Diagnostics.Debug.WriteLine(item);
                        numberOfItems++;
                    }
                }));
            }

            Task.WaitAll(runningTasks.ToArray());

            System.Diagnostics.Debug.WriteLine($"There were {numberOfItems} items in the bag");
        }
    }
}