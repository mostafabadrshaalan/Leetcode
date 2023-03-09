public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        int count = 1;
        List<int> l = arr.ToList();
        ArrayList ar = new ArrayList();
        for (int i = 0; i < l.Count; i++)
        {
            for (int j = i + 1; j < l.Count; j++)
            {
                if (l[i] == l[j])
                {
                    count++;
                    l.RemoveAt(j--);
                }
            }
            if (ar.Contains(count))
                return false;
            ar.Add(count);
            count = 1;
        }
        return true;
    }
}