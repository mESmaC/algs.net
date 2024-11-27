namespace algs.net.Utilities {
    using System;
    using System.Diagnostics;

    public static class Metrics {
        /// <summary>
        /// Measures the execution time and memory usage of a provided action.
        /// </summary>
        /// <param name="algorithmName">The name of the algorithm being measured.</param>
        /// <param name="action">The algorithm to be executed.</param>
        public static void MeasureExecutionTimeAndMemory(string algorithmName, Action action) {
            long memoryBefore = GC.GetTotalMemory(forceFullCollection: true);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            action();

            stopwatch.Stop();

            long memoryAfter = GC.GetTotalMemory(forceFullCollection: true);

            long memoryUsed = memoryAfter - memoryBefore;

            Console.WriteLine($"{algorithmName} Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"{algorithmName} Memory Usage: {memoryUsed / 1024.0:F2} KB");
        }
    }
}
