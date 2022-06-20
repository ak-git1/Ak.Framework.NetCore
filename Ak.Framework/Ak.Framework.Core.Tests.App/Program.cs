using System;
using System.Globalization;
using System.IO;
using Ak.Framework.Core.Converters;
using Ak.Framework.Core.Extensions;
using Ak.Framework.Core.Helpers;

namespace Ak.Framework.Core.Tests.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dates = DateTimeHelper.SplitDateRange("2022-01-01".ToDateTime(), "2022-01-31".ToDateTime(), 7, true);
            //foreach (var date in dates)
            //    Console.WriteLine($"{date.Item1} - {date.Item2}");

            var s = MimeTypesHelper.GetMimeType("atre.docx");

            Console.ReadKey();
        }
    }
}
