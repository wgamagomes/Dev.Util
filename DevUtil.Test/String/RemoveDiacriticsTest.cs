using DevUtil.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevUtil.Test.String
{
    [TestClass]
    public class RemoveDiacritics
    {
        [TestMethod]
        public void WhenTheSourceStringContainsBalticDiacriticCharactersThenNonDiacritcStringShouldBeReturned()
        {
            string input = "ā, ē, ī, ū, č, ģ ķ, ļ, ņ, š, ž";
            Assert.AreEqual(input.RemoveDiacriticsMarks(), "a, e, i, u, c, g k, l, n, s, z");
        }

        [TestMethod]
        public void WhenTheSourceStringContainsCelticDiacriticCharactersThenNonDiacritcStringShouldBeReturned()
        {
            string input = "â, ê, î, ô, û, ŵ, ŷ, ä, ë, ï, ö, ü, ẅ, ÿ, à, è, ì, ò, ù, ẁ, ỳ, á, é, í, ó, ú, ẃ, ý";
            Assert.AreEqual(input.RemoveDiacriticsMarks(), "a, e, i, o, u, w, y, a, e, i, o, u, w, y, a, e, i, o, u, w, y, a, e, i, o, u, w, y");
        }

        [TestMethod]
        public void WhenTheSourceStringContainsSlavicDiacriticCharactersThenNonDiacritcStringShouldBeReturned()
        {
            string bosnianDiacritic = "č, ć, š, ž";           
            Assert.AreEqual(bosnianDiacritic.RemoveDiacriticsMarks(), "c, c, s, z");

            string polishDiacritic = "ą, ć, ę, ń, ó, ś, ź, ż";             
            Assert.AreEqual(polishDiacritic.RemoveDiacriticsMarks(), "a, c, e, n, o, s, z, z");

            string slovakDiacritic = "á, é, í, ó, ú, ý, ĺ, ŕ, č, ď, ľ, ň, š, ť, ž, ä";             
            Assert.AreEqual(slovakDiacritic.RemoveDiacriticsMarks(), "a, e, i, o, u, y, l, r, c, d, l, n, s, t, z, a");
        }


        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.RemoveDiacriticsMarks());
        }
    }
}
