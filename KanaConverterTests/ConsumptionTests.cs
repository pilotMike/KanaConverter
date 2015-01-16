using System;
using KanaConverterLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KanaConverterTests
{
    [TestClass]
    public class ConsumptionTests
    {
        [TestMethod]
        public void gets_auto_converter_and_converts()
        {
            // to simulate how it would be consumed. This is why
            // you start with Test Driven Development, so you don't
            // try 3 ways of doing something.
            string text = "gakkou"; // received from text input
            IKanaConverter converter = KanaConverterLib.KanaConverter.GetConverter(text);
            string result = converter.Convert(text);
            string expected = "がっこう";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void returns_hiragana_katakana_converter()
        {
            string input = "がっこう";
            IKanaConverter result = KanaConverterLib.KanaConverter.GetConverter(input, CharacterType.Katakana);
            Assert.IsTrue(result is KanaKanaConverter);
        }

        [TestMethod]
        public void returns_hiragana_to_romaji_converter()
        {
            string input = "がっこう";
            IKanaConverter result = KanaConverterLib.KanaConverter.GetConverter(input);
            Assert.IsTrue(result is KanaRomajiConverter);
        }

        [TestMethod]
        public void returns_katakana_romaji_converter()
        {
            string input = "ハンバーガー";
            IKanaConverter result = KanaConverterLib.KanaConverter.GetConverter(input);
            Assert.IsTrue(result is KanaRomajiConverter);
        }

        [TestMethod]
        public void returns_romaji_katakana_converter_when_forced()
        {
            string input = "gakkusei";
            IKanaConverter result = KanaConverterLib.KanaConverter.GetConverter(input, CharacterType.Katakana);
            Assert.IsTrue(result is RomajiKatakanaConverter);
        }

        [TestMethod]
        public void returns_kana_kana_converter_when_forced()
        {
            string input = "ハンバーガー";
            IKanaConverter result = KanaConverterLib.KanaConverter.GetConverter(input, CharacterType.Hiragana);
            Assert.IsTrue(result is KanaKanaConverter);
        }
    }
}
