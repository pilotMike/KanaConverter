using System;
using KanaConverterLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KanaConverterTests
{
    [TestClass]
    public class KanaConversionTests
    {
        IKanaConverter converter;
        [TestMethod]
        public void converts_from_hir_to_kat()
        {
            converter = new KanaKanaConverter();
            string hir = "あいうえおかきくけこさしすせそきゃびゃぎゃ";
            string kat = "アイウエオカキクケコサシスセソキャビャギャ";
            string result = converter.Convert(hir);
            Assert.AreEqual(kat, result);
        }

        [TestMethod]
        public void converts_from_kat_to_hir()
        {
            converter = new KanaKanaConverter();
            string hir = "あいうえおかきくけこさしすせそきゃびゃぎゃ";
            string kat = "アイウエオカキクケコサシスセソキャビャギャ";
            string result = converter.Convert(kat);
            Assert.AreEqual(hir, result);
        }

        [TestMethod]
        public void removes_small_tsu_from_hiragana()
        {
            string input = "にっぽん、てっぱんやき";
            converter = KanaConverter.GetConverter(input);
            string result = converter.Convert(input);
            string expected = "nippon、teppanyaki";
            Assert.AreEqual(expected, result);
        }
    }
}
