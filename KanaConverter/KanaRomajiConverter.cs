using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaConverter
{
    public class KanaRomajiConverter : BaseKanaConverter, IKanaConverter
    {
        public string Convert(string text)
        {
            return ConvertKanaToRomaji(text);
        }
    }
}
