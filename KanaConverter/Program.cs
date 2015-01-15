using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = args[0];

            char c = (char)0x3041;

            for (char kana = c; kana < 0x30FF; kana++)
            {
                Debug.Write(kana);
                if (kana == 0x30A0)
                    Debug.WriteLine("");
            }
            Debug.WriteLine("");
            var diff = 'ア' - 'あ';
            Debug.WriteLine(diff);

            Console.WriteLine((int)'a');
            Console.WriteLine((int)'A');
            Console.WriteLine((int)'z');
            Console.WriteLine((int)'Z');


            Console.ReadLine();
        }
    }
}
