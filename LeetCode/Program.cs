using LeetCode;

//int[] arr = [2, 5, 7];
//int[] arr2 = [1, 8, 12, 5, 4];

//int target = 9;
//int target2 = 6;


//int[] result = TwoSum.TwoSumSolution(arr, target);

//Console.WriteLine(string.Join(",", result));

//int[] result2 = TwoSum.TwoSumSolution(arr2, target2);

//Console.WriteLine(string.Join(",", result2));

//bool result = ValidParentheses.IsValidSolution("()[]{]");

//Console.WriteLine(result);

string[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };

IList<IList<string>> anagrams = GroupAnagram.GroupAnagrams(strings);

foreach (var group in anagrams)
{
    Console.WriteLine("[ " + string.Join(", ", group) + " ]");
}
