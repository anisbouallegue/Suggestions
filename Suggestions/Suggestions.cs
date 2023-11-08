namespace Suggestions
{
    public class Suggestions
    {
        public IEnumerable<string> GetSuggestions(string term, IEnumerable<string> choices, int numbersofSuggestions)
        {
            var suggestions = new List<string>();
            foreach (var choice in choices)
            {
                if (choice.Contains(term))
                {
                    suggestions.Add(choice);
                }
                else if (GetDifferenceScore(choice, term) <= term.Length)
                {
                    suggestions.Add(choice);
                }
            }
            suggestions.Sort((x, y) =>
            {
                return GetDifferenceScore(x, y);
            });
            return suggestions.Take(numbersofSuggestions);
        }

        private int GetDifferenceScore(string dest, string src)
        {
            int score = 0;
            if(dest.Length == src.Length)
            {
                for (int i = 0; i < dest.Length; i++)
                {
                    if (dest[i] != src[i])
                    {
                        score++;
                    }
                }
            }
            else if (dest.Length > src.Length)
            {
                for (int i = 0; i < src.Length; i++)
                {
                    if (dest[i] != src[i])
                    {
                        score++;
                    }
                }
            }
            else if (dest.Length < src.Length)
            {
                for (int i = 0; i < dest.Length; i++)
                {
                    if (dest[i] != src[i])
                    {
                        score++;
                    }
                }
            }

            return score == dest.Length? src.Length + 1 : score;
        }
    }
}