using System.Text.RegularExpressions;

namespace AllPracs
{
    internal class Linkq
    {
        public static void Main(string[] args)
        {
            string data = "this  data is   the the baller is  huge baller   20 balls data";
            IEnumerable<string> res = Regex.Split(data, @"\s+");
            IEnumerable<string> unique = res.Distinct();

            foreach (string s in unique)
            {
                Console.WriteLine($"Word: {s} - Count: {res.Count(x => x == s)}");
            }

        }
    }
}