public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        var mergedArr = MergeSortedArrays(nums1,nums2);
        if (mergedArr.Length % 2 != 0)
        {
            return mergedArr[mergedArr.Length / 2];
        }

        return ((double)mergedArr[(mergedArr.Length - 1) / 2] + mergedArr[(mergedArr.Length + 1) / 2]) / 2;
    }

    public int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        var arr3 = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
                arr3[k++] = arr1[i++];
            else
                arr3[k++] = arr2[j++];
        }

        while (i < arr1.Length)
            arr3[k++] = arr1[i++];

        while (j < arr2.Length)
            arr3[k++] = arr2[j++];

        return arr3;
    }
}