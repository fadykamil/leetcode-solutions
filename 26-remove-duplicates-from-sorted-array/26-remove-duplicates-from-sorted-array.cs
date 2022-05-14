public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var k = 1;
        var j = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                nums[j] = nums[i];
                continue;
            }

            if (nums[i] != nums[j])
            {
                j++;
                nums[j] = nums[i];
                k++;
            }
        }

        for (var i = j+1; i < nums.Length; i++)
            nums[i] = 0;
        
        return k;
    }
}