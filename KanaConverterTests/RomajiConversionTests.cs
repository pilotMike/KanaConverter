using System;
using KanaConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KanaConverterTests
{
    [TestClass]
    public class RomajiConversionTests
    {
        private KanaConverter.BaseKanaConverter converter = new KanaConverter.BaseKanaConverter();
        
        [TestMethod]
        public void can_convert_the_hiragana_table()
        {
            string input = "aiueokakikukekosashisuseso";
            string expected = "あいうえおかきくけこさしすせそ";
            string result = converter.ConvertRomajiToHiragana(input);
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void can_convert_the_katakana_table()
        {
            string input = "aiueokakikukekosashisuseso";
            string expected = "アイウエオカキクケコサシスセソ";
            string result = converter.ConvertRomajiToKatakana(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void can_convert_hiragana_vocalized_syllables()
        {
            string input = "gagigugego";
            string expected = "がぎぐげご";
            string result = converter.ConvertRomajiToHiragana(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void can_convert_diphthongs()
        {
            string input = "daijoubu";
            string expected = "だいじょうぶ";
            string result = converter.ConvertRomajiToHiragana(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void converts_jyo()
        {
            string input = "daijyoubu";
            string expected = "だいじょうぶ";
            string result = converter.ConvertRomajiToHiragana(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void doesnt_convert_non_kana_characters()
        {
            string input = "watashinonamaehamaikudesu.douzoyoroshiku.Ne,onigirihaoishiine!";
            string expected = "わたしのなまえはまいくです.どうぞよろしく.ね,おにぎりはおいしいね!";
            string result = converter.ConvertRomajiToHiragana(input);
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void correctly_applies_small_tsu()
        {
            string input = "ippun,nippon,teppan,itta,yatteimasu";
            string expected = "いっぷん,にっぽん,てっぱん,いった,やっています";
            string result = converter.ConvertRomajiToHiragana(input);
            Assert.AreEqual(expected, result);
        }
    }
}
