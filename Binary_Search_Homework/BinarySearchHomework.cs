using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (end >= start)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;

                if (key == arr[mid1])
                    return mid1;
                if (key == arr[mid2])
                    return mid2;
                if (key < arr[mid1])
                    return TernarySearch(arr, key, start, mid1 - 1);
                if (key > arr[mid2])
                    return TernarySearch(arr, key, mid2 + 1, end);
                else
                    return TernarySearch(arr, key, mid1 + 1, mid2 - 1);
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int start = 0;
            int end = arr.Length - 1;
            int firstOccurrences = -1;
            int lastOccurrences = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == key)
                {
                    firstOccurrences = mid;
                    start = end;
                }
                else if (arr[mid] < key)
                {
                    start = mid + 1;
                }
                else { end = mid - 1; }
                if (firstOccurrences == -1)
                { return -0; }
                start = firstOccurrences;
                end = arr.Length - 1;
                while (start <= end)
                {
                    int mid1 = start + (end - start) / 2;
                    if (arr[mid] == key)
                    {
                        lastOccurrences = mid1;
                        start = mid1 + 1;
                    }
                    else if (arr[mid1] < key)
                    { start = mid1 + 1; }
                    else { end = mid1 - 1; }
                    return lastOccurrences - firstOccurrences + 1;
                }
               
            }
            return -1;
        }
    }
}
