public class Solution
{
    public static int PickingNumbers(int[] a)
    {
        SortedDictionary<int, int> numberCountMap = new();
        foreach (int n in a)
        {
            if (numberCountMap.ContainsKey(n))
            {
                numberCountMap[n]++;
            }
            else
            {
                numberCountMap.Add(n, 1);
            }
        }
        int maxQty = 0;
        foreach (int n in numberCountMap.Keys)
        {
            int qty = numberCountMap[n];
            if (numberCountMap.ContainsKey(n + 1))
            {
                qty += numberCountMap[n + 1];
            }
            if (qty > maxQty) maxQty = qty;
        }
        return maxQty;
    }
}