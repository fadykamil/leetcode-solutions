public class Solution {
    public bool Search(int[] nums, int target) 
    {
        switch (nums.Length)
        {
            case 0:
                return false;
            case 1 when nums[0] == target:
                return true;
            default:
                nums = SortRotatedArr(nums);
                return BinarySearch(nums, target) != -1;
        }
    }
    public int BinarySearch(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;
        while (low <= high)
        {
            var middle = (low + high) / 2;
            var guess = nums[middle];
            if (guess < target) low = middle + 1;
            else if (guess > target) high = middle - 1;
            else return middle;
        }
        return -1;
    }
    public int[] SortRotatedArr(int[] arr)
    {
        var pivot = GetPivotForSortedRotated(arr);
        if (pivot == 0) return arr;

        var result = new int[arr.Length];
        // before pivot
        int i;
        for(  i = 0; i < result.Length - pivot; i++)
            result[i] = arr[pivot + i];
        
        // after pivot
        var j = 0;
        while (i < arr.Length)
            result[i++] = arr[j++];

        return result;
    }

    public int GetPivotForSortedRotated(int[] arr)
    {
        var i = 0;
        var pivot = 0;
        while (i < arr.Length - 1)
        {
            if (arr[i] > arr[i + 1])
                pivot = i + 1;
            i++;
        }
        return pivot;
    }
}