using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public static class Extensions
    {
        public static string ToPrettyString(this decimal number) =>
            string.Format("{0:#,##0.##}", number);
    }
}
