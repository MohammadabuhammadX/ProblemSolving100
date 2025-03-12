namespace Valid_Anagram
{
    internal class Program
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;

            Dictionary<char, int> dicS = new Dictionary<char, int>();
            Dictionary<char, int> dicT = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (dicS.ContainsKey(s[i]))
                {
                    dicS[s[i]]++;
                }
                else
                {
                    dicS[s[i]] = 1;
                }
                if (dicT.ContainsKey(t[i]))
                {
                    dicT[t[i]]++;
                }else
                {
                    dicT[t[i]]=1;
                }
            }
            foreach(var c in dicS)
            {
                if (!dicT.ContainsKey(c.Key) || dicT[c.Key] != c.Value)
                {
                    return false;
                } 
            }
            return true;
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.IsAnagram("anagram", "nagaram")); 
            Console.WriteLine(program.IsAnagram("rat", "car"));         
            Console.WriteLine(program.IsAnagram("", ""));               
            Console.WriteLine(program.IsAnagram("a", "a"));             
            Console.WriteLine(program.IsAnagram("abcd", "dcba"));       
            Console.WriteLine(program.IsAnagram("abcd", "dcbaa"));       
        }
    }
}
