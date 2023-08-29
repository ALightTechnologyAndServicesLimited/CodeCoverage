using CodeCoverage.Lib;

namespace CodeCoverage.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetUnixEpochReturnsExpectedValue()
        {
            double expectedValue = 946684800;
            var val = new DateTime(2000, 1, 1, 0, 0, 0);

            var retVal = Helper.GetUnixEpoch(val);
            Assert.AreEqual(expectedValue, retVal);
        }

        [Test]
        public void TestGetDateTimeFromUnixEpochReturnsExpectedValue()
        {
            double val = 946684800;
            var expectedValue = new DateTime(2000, 1, 1, 0, 0, 0);

            var retVal = Helper.GetDateTimeFromUnixEpoch(val);
            Assert.AreEqual(expectedValue, retVal);
        }

        [Test]
        public void TestGetYYYMMDDReturnsExpectedValue()
        {
            long expectedValue = 20000101;
            var val = new DateTime(2000, 1, 1, 0, 0, 0);

            var retVal = Helper.GetYYYMMDD(val);
            Assert.AreEqual(expectedValue, retVal);
        }

        [Test]
        public void TestIsLeapYearThrowsExceptionForNegativeValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Helper.IsLeapYear(-1);
            });
        }

        [Test]
        public void TestIsLeapYearThrowsExceptionForZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Helper.IsLeapYear(0);
            });
        }

        [Test]
        public void TestIsLeapYearReturnsTrueFor2000()
        {
            var retVal = Helper.IsLeapYear(2000);
            Assert.IsTrue(retVal);
        }

        [Test]
        public void TestIsLeapYearReturnsTrueFor2004()
        {
            var retVal = Helper.IsLeapYear(2004);
            Assert.IsTrue(retVal);
        }

        [Test]
        public void TestIsLeapYearReturnsFalseFor1900()
        {
            var retVal = Helper.IsLeapYear(1900);
            Assert.IsFalse(retVal);
        }

        [Test]
        public void TestIsLeapYearReturnsFalseFor2001()
        {
            var retVal = Helper.IsLeapYear(2001);
            Assert.IsFalse(retVal);
        }
    }
}