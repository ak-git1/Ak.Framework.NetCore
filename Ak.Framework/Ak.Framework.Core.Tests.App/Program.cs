using System;
using Ak.Framework.Core.Extensions;

namespace Ak.Framework.Core.Tests.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = " 12.31%".ExtractDecimal();
        }
    }
}
