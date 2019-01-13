using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB01._StringBuilder.Substring
{
    public static class Extensions
    {
        public static string Substring(this StringBuilder sb, int startIndex, int length)
        {
            return sb.ToString(startIndex, length);
        }
    }
}
