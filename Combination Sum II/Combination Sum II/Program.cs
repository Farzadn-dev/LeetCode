public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        IList<IList<int>> result = new List<IList<int>>();
        BackTrack(result, new List<int>(), candidates, 0, target);
        return result;
    }

    private void BackTrack(IList<IList<int>> result, IList<int> temp, int[] candidates, int start, int remain)
    {
        if (remain == 0)
        {
            result.Add(new List<int>(temp));
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1])
                continue; // Skip duplicates

            if (candidates[i] > remain)
                break; // Prune the search space early

            temp.Add(candidates[i]);
            BackTrack(result, temp, candidates, i + 1, remain - candidates[i]);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}