namespace xUnit.Samples.Theory.InlineData
{
    public class Calculator
    {
        public long Add(int a, int b)
        {
            return a + b;
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(1_000,1_000,2_000)]
        public void Add_ShouldReturnSum(int a, int b, long sum)
        {
            //arr
            var cal = new Calculator();

            //act
            var result = cal.Add(a, b);

            //assert
            Assert.Equal(sum, result);
        }
    }
}