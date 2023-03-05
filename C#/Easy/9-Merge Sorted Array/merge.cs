public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int counter = 0;
        for (int i = m; i < n + m; i++)
        {
            nums1[i] = nums2[counter];
            counter++;
        }
        int temp = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = i + 1; j < nums1.Length; j++)
            {
                if (nums1[i] > nums1[j])
                {
                    temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                }

            }
        }
    }
}