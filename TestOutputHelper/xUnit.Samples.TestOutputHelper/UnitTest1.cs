using Xunit.Abstractions;

namespace xUnit.Samples.TestOutputHelper
{
    public class UnitTest1
    {
        private ITestOutputHelper _outputHelper;

        public UnitTest1(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Test1()
        {
            _outputHelper.WriteLine("Salam");
            Assert.Equal(1, 1);
        }
    }
}