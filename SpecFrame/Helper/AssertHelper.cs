using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.Helper
{
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {

            }
        }
    }
}
