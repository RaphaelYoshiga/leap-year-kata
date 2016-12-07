namespace LeapYearKata.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class LeapYearVerifierShould
    {
        [Test]
        public void Return_True_When_Input_Is_4()
        {
            var result = LeapYearVerifier.IsLeapYear(4);

            result.Should().BeTrue();
        }
    }
}
