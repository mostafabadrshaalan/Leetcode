public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || target < nums[i])
            {
                return i;
            }
            if (i == nums.Length - 1 && target > nums[nums.Length - 1])
            {
                return i + 1;
            }

        }
        return 0;
    }
}