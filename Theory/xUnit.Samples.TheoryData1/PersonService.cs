namespace xUnit.Samples.Theory.TheoryData1
{
    public class PersonService
    {
        public bool IsAboveFourteen(Person person)
        {
            return person.Age > 14;
        }


        [Theory]
        [MemberData(nameof(GetPersonData))]
        public void IsAboveFourteen_Test(Person person)
        {
            Assert.True(IsAboveFourteen(person));
        }

        public static TheoryData<Person> GetPersonData()
        {
            return new TheoryData<Person>
            {
                new Person {Name = "Tribbiani", Age = 56},
                new Person {Name = "Gotti", Age = 16}
            };
        }
    }
}