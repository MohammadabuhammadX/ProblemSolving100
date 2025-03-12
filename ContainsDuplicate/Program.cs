namespace ContainsDuplicate
{
    internal class Program
    {
        public bool HasDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(int num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                set.Add(num);
            }
            return false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            // Example test cases
            int[] nums1 = { 1, 2, 3, 4, 5 };
            int[] nums2 = { 1, 2, 3, 4, 4 };
            int[] nums3 = { };

            Console.WriteLine("Test Case 1: " + program.HasDuplicate(nums1)); // Output: False
            Console.WriteLine("Test Case 2: " + program.HasDuplicate(nums2)); // Output: True
            Console.WriteLine("Test Case 3: " + program.HasDuplicate(nums3)); // Output: False
        }
    }
}