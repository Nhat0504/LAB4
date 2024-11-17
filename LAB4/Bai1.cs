using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bai1
{
    internal class Bai1
    {
        [TestCaseSource(nameof(TestData))]
        public void TimSoChiaHetCho2_Test(int number)
        {
            Assert.That(number % 2, Is.EqualTo(0), $"Số {number} không chia hết cho 2");
        }

        private static IEnumerable<int> TestData => new List<int> { 0, 4, 5, 6, 18, 10, 9, 21, 25, 40 };
    }
}