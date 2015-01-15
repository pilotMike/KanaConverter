using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaConverter
{
    public class KanaKanaConverter : BaseKanaConverter, IKanaConverter
    {
        public string Convert(string text)
        {
            return ContainsHiraganaCharacters(text) ? 
                ConvertHiraganaToKatakana(text) : 
                ConvertKatakanaToHiragana(text);
        }
    }
}
