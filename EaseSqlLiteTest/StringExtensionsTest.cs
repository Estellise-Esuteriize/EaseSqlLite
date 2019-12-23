using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using SnowPlatform_EaseSqlLite;
using SnowPlatform_EaseSqlLite.Constant;
using SnowPlatform_EaseSqlLite.Exceptions;
using SnowPlatform_EaseSqlLite.Strings;

namespace EaseSqlLiteTest
{
    [TestFixture]
    public class StringExtensionsTest
    {
        public void ReplaceSymbolTestNull()
        {
            
        }

        [TestCase("original", "appends", "another")]
        [TestCase("original", "appends", null)]
        [TestCase("original")]
        [TestCase("")]
        public void AppendString(string original, params string[] appends)
        {
            try
            {
                var expected = appends.Aggregate(original, (current, append) => current + $" {append}");
                var result = original.Append(appends);
                
                Console.WriteLine("ORIGINAL " + original);
                Console.WriteLine("EXPECTED " + expected);
                Console.WriteLine("APPENDS LENGTH " + appends.Length);
                
                Assert.AreEqual(expected, result);
            }
            catch (EaseSqlLiteNullArgumentException ex)
            {
                Console.WriteLine("EXCEPTION " + ex);
                Assert.AreEqual(ex.GetType(), typeof(EaseSqlLiteNullArgumentException));
            }
        }
    }
}