namespace xUnit.Samples.Theory.MemberData2
{
    public class Calculator
    {
        public long Add(int a, int b)
        {
            return a + b;
        }

        [Theory]
        [MemberData(nameof(DataGenerator.GetData), MemberType = typeof(DataGenerator))]
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

    public class DataGenerator
    {
        public static IEnumerable<object[]> GetData()
        {
            var allData = new List<object[]>
            {
                new object[] { 1, 2, 3 },
                new object[] { -4, -6, -10 },
                new object[] { -2, 2, 0 },
                new object[] { int.MinValue, -1, int.MaxValue },
            };

            return allData;
        }
    }
}