using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suggestions.Core
{
    public interface ISuggestion
    {
        IEnumerable<string> GetSuggestions(string term, IEnumerable<string> choices, int numbersofSuggestions);
    }
}
