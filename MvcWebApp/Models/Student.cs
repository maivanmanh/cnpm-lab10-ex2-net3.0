namespace MvcWebApp.Models
{
    public class Student
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Student() { }

        public Student(string id, string name, int age, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
