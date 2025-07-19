public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        IList<IList<int>> result = [];
        Backtrack(result, [], candidates, 0, target);
        return result;
    }

    private void Backtrack(IList<IList<int>> result, IList<int> tempList, int[] candidates, int start, int remain)
    {
        if (remain < 0) return; // Exit if the remaining sum is negative
        else if (remain == 0) result.Add(tempList); // Add the current combination to the result if the remaining sum is zero
        else
        {
            for (int i = start; i < candidates.Length; i++)
            {
                tempList.Add(candidates[i]); // Include candidates[i] in the combination
                Backtrack(result, tempList, candidates, i, remain - candidates[i]); // Recurse with updated remaining sum and current index
                tempList.RemoveAt(tempList.Count - 1); // Remove the last element to backtrack
            }
        }
    }
}
