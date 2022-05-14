public class Solution {
    public int Search(int[] nums, int target) {
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
}