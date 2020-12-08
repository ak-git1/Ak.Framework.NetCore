using System;
using Ak.Framework.Core.Converters;
using Ak.Framework.Core.Extensions;
using Ak.Framework.Core.Helpers;

namespace Ak.Framework.Core.Tests.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var v = " 12.31%".ExtractDecimal();
            //var v = DateTimeHelper.GetMonthStartDatesInRange("2020.01.01".ToDateTime(), "2020.03.30".ToDateTime());
            //string v = (12.31).ConvertToSqlParameter(true);

            string n1 = Base32Converter.Encode(532);
            long n2 = Base32Converter.Decode("777");
        }
    }
}
