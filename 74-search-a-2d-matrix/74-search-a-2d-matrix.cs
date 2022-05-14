public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var cols = matrix[0].Length;
        for (var i = 0; i < matrix.Length; i++)
        {
            var lastCell = matrix[i][cols - 1];
            if (target == lastCell)
                return true;

            if (target < lastCell)
                return BinarySearch(matrix[i], target) != -1;
        }

        return false;
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
}