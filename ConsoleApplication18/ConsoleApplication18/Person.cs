namespace ConsoleApplication18
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string AcNumber { get; set; }

        public Person(int id, string name, int age, string acNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            AcNumber = acNumber;
        }
    }
}
