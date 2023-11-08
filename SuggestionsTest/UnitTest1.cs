using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SuggestionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSuggestions_ShouldReturnCorrectOrderedSuggestions()
        {
            var assistant = new Suggestions.Suggestions();
            var choices = new List<string>()
            {
                "gros","gras","graisse","aggressif","go","ros","gro"
            };
            var suggestions = assistant.GetSuggestions("gros", choices, 2);
            Assert.AreEqual(2, suggestions.Count());
            Assert.AreEqual("gros", suggestions.ElementAt(0));
            Assert.AreEqual("gras", suggestions.ElementAt(1));
        }


        [TestMethod]
        public void GetSuggestions_ShouldReturnEmptyListIfNoSuggestionsFound()
        {
            var assistant = new Suggestions.Suggestions();
            var choices = new List<string>()
            {
                "apple","banana","cherry"
            };
            var suggestions = assistant.GetSuggestions("orange", choices, 2);
            Assert.AreEqual(0, suggestions.Count());
        }
    }
}