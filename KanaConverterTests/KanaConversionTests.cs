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
    }
}
