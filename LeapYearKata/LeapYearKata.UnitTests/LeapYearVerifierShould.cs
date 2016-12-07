namespace LeapYearKata.UnitTests
{

    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class LeapYearVerifierShould
    {
        [Test]
        public void ReturnTrue_WhenVerifying_GivenInputIs4()
        {
            var result = LeapYearVerifier.IsLeapYear(4);

            result.Should().BeTrue();
        }

        [Test]
        public void ReturnFalse_WhenVerifying_Given1()
        {
            var result = LeapYearVerifier.IsLeapYear(1);

            result.Should().BeFalse();
        }

        [Test]
        public void ReturnTrue_WhenVerifying_GivenInputIs8()
        {
            var result = LeapYearVerifier.IsLeapYear(8);

            result.Should().BeTrue();
        }

        [Test]
        public void ReturnTrue_WhenVerifying_GivenInputIs16()
        {
            var result = LeapYearVerifier.IsLeapYear(16);

            result.Should().BeTrue();
        }
    }
}
