public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }
            if (count >= ((nums.Length + 1) / 2))
            {
                return nums[i];
            }
            count = 0;
        }
        return 0;
    }
}
