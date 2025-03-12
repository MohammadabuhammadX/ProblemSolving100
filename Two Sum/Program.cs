namespace Two_Sum
{
    internal class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (result.ContainsKey(diff))
                {
                    return new int[] { result[diff], i };
                }
                result[nums[i]] = i;
            }
            return null;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            // Example test cases
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = program.TwoSum(nums1, target1);
            Console.WriteLine($"Input: [{string.Join(", ", nums1)}], Target: {target1} => Output: [{FormatOutput(result1)}]");

            int[] nums2 = { 3, 2, 3 };
            int target2 = 6;
            int[] result2 = program.TwoSum(nums2, target2);
            Console.WriteLine($"Input: [{string.Join(", ", nums2)}], Target: {target2} => Output: [{FormatOutput(result2)}]");

            int[] nums3 = { 3, 3 };
            int target3 = 6;
            int[] result3 = program.TwoSum(nums3, target3);
            Console.WriteLine($"Input: [{string.Join(", ", nums3)}], Target: {target3} => Output: [{FormatOutput(result3)}]");
        }

        // Helper method to format output
        static string FormatOutput(int[] result)
        {
            if (result == null)
                return "No solution found";
            return string.Join(", ", result);
        }
    }
}
