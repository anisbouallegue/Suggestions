using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suggestions.Core;


namespace Suggestions.Tests
{
    [TestClass]
    public class IAmTheTest
    {
        [TestMethod]
        public void GetSuggestions_ShouldReturnCorrectOrderedSuggestions()
        {
            ISuggestion suggestion = new Suggestion();
            var choices = new List<string>()
            {
                "gros","gras","graisse","aggressif","go","ros","gro"
            };
            var suggestions = suggestion.GetSuggestions("gros", choices, 2);
            Assert.AreEqual(2, suggestions.Count());
            Assert.AreEqual("gros", suggestions.ElementAt(0));
            Assert.AreEqual("gras", suggestions.ElementAt(1));
        }


        [TestMethod]
        public void GetSuggestions_ShouldReturnEmptyListIfNoSuggestionsFound()
        {
            ISuggestion suggestion = new Suggestion();
            var choices = new List<string>()
            {
                "apple","banana","cherry"
            };
            var suggestions = suggestion.GetSuggestions("orange", choices, 2);
            Assert.AreEqual(0, suggestions.Count());
        }
    }
}