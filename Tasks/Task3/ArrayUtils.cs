using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal static class ArrayUtils
    {
        public static void ReverseArray<T>(ref T[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size / 2; i++)
            {
                T temp = arr[i];
                arr[i] = arr[size - i - 1];
                arr[size - i - 1] = temp;
            }
        }

        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T mxElement = arr[0];
            foreach (T item in arr)
            {
                if (item.CompareTo(mxElement)>0)
                {
                    mxElement = item;
                }
            }
            return mxElement;
        }

       
    }
}
