namespace LeetCode
{
    public static class TwoSum
    {
      
        public static int[] TwoSumSolution(int[] nums, int target)
        {
            Dictionary<int, int> map = [];

            for (int i = 0; i < nums.Length; i++)
            {
                var value = target - nums[i];
                if (map.ContainsKey(value))
                {
                    return [map[value], i];
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            return [];
        }
    }
}
