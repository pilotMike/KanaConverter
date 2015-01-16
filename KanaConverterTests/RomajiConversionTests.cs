using System;
using KanaConverterLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KanaConverterTests
{
    [TestClass]
    public class RomajiConversionTests
    {
        private IKanaConverter converter;
        
        [TestMethod]
        public void can_convert_the_hiragana_table()
        {
            converter = new RomajiHiraganaConverter();
            string input = "aiueokakikukekosashisuseso";
            string expected = "あいうえおかきくけこさしすせそ";
            string result = converter.Convert(input);
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void can_convert_the_katakana_table()
        {
            converter = new RomajiKatakanaConverter();
            string input = "aiueokakikukekosashisuseso";
            string expected = "アイウエオカキクケコサシスセソ";
            string result = converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void can_convert_hiragana_vocalized_syllables()
        {
            converter = new RomajiHiraganaConverter();
            string input = "gagigugego";
            string expected = "がぎぐげご";
            string result = converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void can_convert_diphthongs()
        {
            converter = new RomajiHiraganaConverter();
            string input = "daijoubu";
            string expected = "だいじょうぶ";
            string result = converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void converts_jyo()
        {
            converter = new RomajiHiraganaConverter();
            string input = "daijyoubu";
            string expected = "だいじょうぶ";
            string result = converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void doesnt_convert_non_kana_characters()
        {
            converter = new RomajiHiraganaConverter();
            string input = "watashinonamaehamaikudesu.douzoyoroshiku.Ne,onigirihaoishiine!";
            string expected = "わたしのなまえはまいくです.どうぞよろしく.ね,おにぎりはおいしいね!";
            string result = converter.Convert(input);
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void correctly_applies_small_tsu()
        {
            converter = new RomajiHiraganaConverter();
            string input = "ippun,nippon,teppan,itta,yatteimasu";
            string expected = "いっぷん,にっぽん,てっぱん,いった,やっています";
            string result = converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
    }
}
