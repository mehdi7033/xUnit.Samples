namespace xUnit.Samples.Disposable
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }

    public class CalculatorTests : IDisposable
    {
        private Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShoudReturn3_When_Input_Is_1_And_2()
        {
            //act
            var result = _calculator.Add(1, 2);

            //assert
            Assert.Equal(3, result);
        }

        public void Dispose()
        {
            _calculator = null;
        }
    }
}