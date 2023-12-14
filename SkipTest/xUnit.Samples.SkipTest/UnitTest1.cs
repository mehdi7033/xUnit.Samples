namespace xUnit.Samples.SkipTest
{
    public class UnitTest1
    {
        [Fact(Skip ="temp")]
        public void Test1()
        {

        }


        [Fact]
        public void Test2()
        {

        }
    }
}