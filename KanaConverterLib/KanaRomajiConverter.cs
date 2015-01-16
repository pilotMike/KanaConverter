using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaConverterLib
{
    public class KanaRomajiConverter : KanaConverterLib.KanaConverter, IKanaConverter
    {
        public string Convert(string text)
        {
            return ConvertKanaToRomaji(text);
        }
    }
}
