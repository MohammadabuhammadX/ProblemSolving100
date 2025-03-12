namespace Group_Anagrams
{
    internal class Program
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var keyValuePairs = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                int[] counter = new int[26];

                foreach(char c in str)
                {
                    counter[c - 'a']++;
                }

                string key = string.Join(",", counter);

                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key] = new List<string>();
                }
                keyValuePairs[key].Add(str);
            }
            return new List<IList<string>>(keyValuePairs.Values);
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };

            IList<IList<string>> result = program.GroupAnagrams(input);

            foreach (var group in result)
            {
                Console.WriteLine($"[{string.Join(", ", group)}]");
            }
        }
    }
}
