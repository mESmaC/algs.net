namespace algs.net.Sorting {
    public class MergeSort {
        public static void Sort<T>(T[] array) where T : IComparable<T> {
            SortHelper(array, 0, array.Length - 1);
        }

        private static void SortHelper<T>(T[] array, int l, int r) where T : IComparable<T> {
            if (l < r) {
                int m = l + (r - l) / 2;

                SortHelper(array, l, m);
                SortHelper(array, m + 1, r);

                Merge(array, l, m, r);
            }
        }

        private static void Merge<T>(T[] array, int l, int m, int r) where T : IComparable<T> {
            int n1 = m - l + 1;
            int n2 = r - m;

            T[] L = new T[n1];
            T[] R = new T[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = array[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = array[m + 1 + j];

            i = 0;
            j = 0;
            int k = l;

            while (i < n1 && j < n2) {
                if (L[i].CompareTo(R[j]) <= 0) {
                    array[k] = L[i];
                    i++;
                } else {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1) {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2) {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
