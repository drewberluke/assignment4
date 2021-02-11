using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment4.Models
{
    public class TempStorage
    {
        private static List<Suggestions> SuggestionList = new List<Suggestions>();

        public static IEnumerable<Suggestions> suggestions => SuggestionList;

        public static void AddSuggestion(Suggestions suggestion)
        {
            SuggestionList.Add(suggestion);
        }
    }
}
