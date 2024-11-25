using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TechnologiesLab2
{
    public class IntegralCalculator
    {

        public double Calculate(double a, double b, long countOfIntervals, Function function, int countThreads, int maxCountThreads)
        {
            SemaphoreSlim semaphore = new SemaphoreSlim(maxCountThreads);
            var listResult = new ConcurrentBag<double>();
            var threads = new List<Thread>();
            for (int threadIndex = 0; threadIndex < countThreads; threadIndex++)
            {
                int currentThread = threadIndex;
                Thread thread = new Thread(() =>
                {
                        semaphore.Wait();
                        listResult.Add(CalculationTrapeziumMethod(a, b, countOfIntervals, function, countThreads, currentThread));                     
                        semaphore.Release();
                });
                threads.Add(thread);
                thread.Start();
            }
            threads.ForEach(t => t.Join());
            return listResult.Sum();
        }

        private double CalculationTrapeziumMethod(double a, double b, long countOfIntervals, Function function, int countThreads, int thread)
        {
            var h = (b - a) / countOfIntervals;
            var start = thread * countOfIntervals / countThreads;
            var end = (thread + 1) * countOfIntervals / countThreads;
            double sum = 0.0;
            for (long i = start; i < end; i++)
                sum += CalculateTrapezoidArea(a, h, i, function);
            return sum;
        }

        private double CalculateTrapezoidArea(double a, double h, long i, Function function) =>
            0.5 * h * (function.Calculate(a + i * h) + function.Calculate(a + (i + 1) * h));
    }
}
