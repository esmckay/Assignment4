using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public static class Storage
    {
        private static List<SuggestionResponse> suggestions = new List<SuggestionResponse>();

        public static IEnumerable<SuggestionResponse> Suggestions => suggestions;

        public static void AddSuggestion(SuggestionResponse sugg)
        {
            suggestions.Add(sugg);
        }
    }
}
