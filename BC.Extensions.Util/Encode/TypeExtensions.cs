using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.Extensions.Encode
{
    public static class TypeExtensions
    {
        public static Dictionary<int, string> Base32Code = new Dictionary<int, string>() {
            {   0  ,"0"}, {   1  ,"1"}, {   2  ,"2"}, {   3  ,"3"}, {   4  ,"4"}, {   5  ,"5"}, {   6  ,"6"}, {   7  ,"7"}, {   8  ,"8"}, {   9  ,"9"},
            {   10  ,"A"}, {   11  ,"B"}, {   12  ,"C"}, {   13  ,"D"}, {   14  ,"E"}, {   15  ,"F"}, {   16  ,"G"}, {   17  ,"H"}, {   18  ,"I"}, {   19  ,"J"},
            {   20  ,"K"}, {   21  ,"L"}, {   22  ,"M"}, {   23  ,"N"}, {   24  ,"O"}, {   25  ,"P"}, {   26  ,"Q"}, {   27  ,"R"}, {   28  ,"S"}, {   29  ,"T"},
            {   30  ,"U"}, {   31  ,"V"}
        };
        public static Dictionary<int, string> Base32ReadableCode = new Dictionary<int, string>() {
            {   0  ,"0"}, {   1  ,"1"}, {   2  ,"2"}, {   3  ,"3"}, {   4  ,"4"}, {   5  ,"5"}, {   6  ,"6"}, {   7  ,"7"}, {   8  ,"8"}, {   9  ,"9"},
            {   10  ,"A"}, {   11  ,"B"}, {   12  ,"C"}, {   13  ,"D"}, {   14  ,"E"}, {   15  ,"F"}, {   16  ,"G"}, {   17  ,"H"}, {   18  ,"J"}, {   19  ,"K"},
            {   20  ,"M"}, {   21  ,"N"}, {   22  ,"P"}, {   23  ,"Q"}, {   24  ,"R"}, {   25  ,"S"}, {   26  ,"T"}, {   27  ,"V"}, {   28  ,"W"}, {   29  ,"X"},
            {   30  ,"Y"}, {   31  ,"Z"}
        };
        public static string ToBase32String(this long value, bool isReadable = false)
        {
            string str = "";
            while (value >= 1)
            {
                int index = Convert.ToInt16(value - (value / 32) * 32);
                str = (isReadable ? Base32ReadableCode[index] : Base32Code[index]) + str;
                value = value / 32;
            }
            return str;
        }

        
    }
}
