namespace algs.net.Sorting {
    public class BubbleSort {
        public static void Sort<T>(T[] array) where T : IComparable<T> {
            int len = array.Length;
            bool swap;

            for (int i = 0; i < len - 1; i++) {
                swap = false;
                for (int j = 0; j < len - i - 1; j++) {
                    if (array[j].CompareTo(array[j + 1]) > 0) {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap) {
                    break;
                }
            }
        }
    }
}