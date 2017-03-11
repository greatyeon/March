using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatyeon.March.Tests.Common.tests
{
    [TestClass]
    public class CommonTests
    {
        [TestMethod]
        public void ListTest()
        {
            IList<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);

            Assert.IsTrue(numbers.Count() > 0);

        }
    }
}
