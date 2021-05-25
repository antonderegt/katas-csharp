namespace Katas.CompleteWord
{
    public class CompleteWord
    {
        public static bool CanComplete(string input, string word)
        {
            if (input.Equals(word)) return true;
            if (input.Length > word.Length) return false;

            for (int i = 0, j = 0; i < input.Length; i++, j++)
            {
                if (j >= word.Length)
                    return false;

                while (!input[i].Equals(word[j]))
                {
                    j++;
                    if (j >= word.Length)
                        return false;
                }
            }

            return true;
        }
    }
}
