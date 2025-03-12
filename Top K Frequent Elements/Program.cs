namespace Top_K_Frequent_Elements
{
    internal class Program
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if(keyValues.ContainsKey(i)) keyValues[i]++;
                else keyValues[i] = 1;
            }
            List<int[]> arr = keyValues.Select(entry => new int[] { entry.Value, entry.Key }).ToList();

            arr.Sort((a,b)=>b[0].CompareTo(a[0]));

            int[]res = new int[k];
            
            for (int i = 0; i < k; i++)
            {
                res[i] = arr[i][1];
            }
            return res;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            int[] result = program.TopKFrequent(nums, k); 
            Console.WriteLine(string.Join(", ", result)); 
        }
    }
}
