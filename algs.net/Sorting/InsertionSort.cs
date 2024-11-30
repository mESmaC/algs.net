namespace algs.net.Sorting {
    public class InsertionSort {
        public static void Sort<T>(T[] array) where T : IComparable<T> {
            int n = array.Length;

            for (int i = 1; i < n; ++i) {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0) {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j] = key;
            }
        }
    }
}
