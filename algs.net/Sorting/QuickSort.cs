namespace algs.net.Sorting {
    public class QuickSort {

        // This method serves as the entry point and takes in an array of comparable indecies
        public static void Sort<T>(T[] array) where T : IComparable<T> {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort<T>(T[] array, int low, int high) where T : IComparable<T> {
            if (low < high) {
                int pivotIndex = Partition(array, low, high);
                Sort(array, low, pivotIndex - 1);
                Sort(array, pivotIndex + 1, high);
            }
        }

        private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T> {
            T pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++) {
                if (array[j].CompareTo(pivot) < 0) {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }

        private static void Swap<T>(T[] array, int i, int j) {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }
}
