namespace Katas.Parseltongue
{
    public class Parseltongue
    {
        public static bool IsParseltongue(string sentence)
        {
            char charToCheck = 's';
            sentence = sentence.ToLower();
            bool previousWasCharToCheck = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];
                bool nextWillBeCharToCheck = i + 1 < sentence.Length && sentence[i + 1].Equals(charToCheck);

                if (currentChar.Equals(charToCheck))
                {
                    if (previousWasCharToCheck || nextWillBeCharToCheck)
                    {
                        previousWasCharToCheck = true;
                        continue;
                    }

                    return false;
                }

                previousWasCharToCheck = false;
            }

            return true;
        }
    }
}
