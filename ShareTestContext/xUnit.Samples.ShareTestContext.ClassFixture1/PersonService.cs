namespace xUnit.Samples.ShareTestContext.ClassFixture1
{
    public class PersonService : IClassFixture<InMemoryDbContextFixture>
    {
        private InMemoryDbContextFixture _fixture;
        public PersonService(InMemoryDbContextFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            _fixture.Counter++;
            Console.WriteLine(_fixture.Counter);
        }

        [Fact]
        public void Test2()
        {

            _fixture.Counter++;
            Console.WriteLine(_fixture.Counter);
        }

        [Fact]
        public void Test3()
        {
            _fixture.Counter++;
            Console.WriteLine(_fixture.Counter);
        }
    }

    public class InMemoryDbContextFixture
    {
        public int Counter { get; set; }
    }
}