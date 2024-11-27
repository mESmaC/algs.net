namespace algs.net.Utilities {
    using System;
    using System.Diagnostics;

    public static class Metrics {
        /// <summary>
        /// Measures the execution time of a provided action.
        /// </summary>
        /// <param name="algorithmName">The name of the algorithm being measured.</param>
        /// <param name="action">The algorithm to be executed.</param>
        public static void MeasureExecutionTime(string algorithmName, Action action) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            action();

            stopwatch.Stop();
            Console.WriteLine($"{algorithmName} Execution Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
