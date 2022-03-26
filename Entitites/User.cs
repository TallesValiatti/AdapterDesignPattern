namespace AdapterDesignPattern.Entitites
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            this.Age = age;
            Name = name;
        }
    }
}