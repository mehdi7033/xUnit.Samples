using System.Collections;

namespace xUnit.Samples.Theory.ClassData
{
    public class CalculatorTestClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { -4, -6, -10 };
        }

        IEnumerator IEnumerable.GetEnumerator()=> GetEnumerator();
    }

    public class Calculator
    {
        public long Add(int a, int b)
        {
            return a + b;
        }

        [Theory]
        [ClassData(typeof(CalculatorTestClassData))]
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