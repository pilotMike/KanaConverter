using System;
using KanaConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KanaConverterTests
{
    [TestClass]
    public class KanaConversionTests
    {
        KanaConverter.BaseKanaConverter converter = new KanaConverter.BaseKanaConverter();
        [TestMethod]
        public void converts_from_hir_to_kat()
        {
            string hir = "あいうえおかきくけこさしすせそきゃびゃぎゃ";
            string kat = "アイウエオカキクケコサシスセソキャビャギャ";
            string result = converter.ConvertHiraganaToKatakana(hir);
            Assert.AreEqual(kat, result);
        }

        [TestMethod]
        public void converts_from_kat_to_hir()
        {
            string hir = "あいうえおかきくけこさしすせそきゃびゃぎゃ";
            string kat = "アイウエオカキクケコサシスセソキャビャギャ";
            string result = converter.ConvertKatakanaToHiragana(kat);
            Assert.AreEqual(hir, result);
        }
    }
}
