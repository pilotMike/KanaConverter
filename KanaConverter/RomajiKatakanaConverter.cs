using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaConverter
{
    public class RomajiKatakanaConverter : BaseKanaConverter, IKanaConverter
    {
        public string Convert(string text)
        {
            return ConvertRomajiToKatakana(text);
        }
    }
}
