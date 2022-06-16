using NUnit.Framework;

namespace Summator.Tests
{
    public class Summator_Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            long result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long result = Summator.Sum(new int[] { -7, -9 });

            Assert.That(result == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long result = Summator.Sum(new int[] { 0});

            Assert.That(result == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long expected = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(expected, 6000000000);
        }
    }
}