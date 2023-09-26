using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HEXConverter.lib
{
    internal class HEX_DCWL
    {
        static byte[] BHEX_;
        public static string SHEX_;
        public static void THEX(string TEXT_)
        {

            BHEX_ = Encoding.UTF8.GetBytes(TEXT_);
            SHEX_ = Convert.ToHexString(BHEX_);
        }
    }
}
