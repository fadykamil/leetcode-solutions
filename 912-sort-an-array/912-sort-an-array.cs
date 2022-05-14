public class Solution {
    public int[] SortArray(int[] nums) 
   {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    public void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            MergeSortedArrays(arr, left, mid, right);
        }
    }

    public void MergeSortedArrays(int[] arr, int left, int mid, int right)
    {
        var leftArrLength = mid - left + 1;
        var rightArrLength = right - mid;

        var leftArr = new int[leftArrLength];
        var rightArr = new int[rightArrLength];
        int i;
        int j;
        for (i = 0; i < leftArrLength; i++)
            leftArr[i] = arr[i + left];

        for (j = 0; j < rightArrLength; j++)
            rightArr[j] = arr[j + mid + 1];

        i = 0;
        j = 0;
        var k = left;
        while (i < leftArrLength && j < rightArrLength)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k] = leftArr[i];
                i++;
            }
            else
            {
                arr[k] = rightArr[j];
                j++;
            }

            k++;
        }

        while (i < leftArrLength)
        {
            arr[k] = leftArr[i];
            k++;
            i++;
        }

        while (j < rightArrLength)
        {
            arr[k] = rightArr[j];
            k++;
            j++;
        }
        //return arr;
    }
}