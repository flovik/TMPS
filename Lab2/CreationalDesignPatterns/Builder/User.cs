namespace CreationalDesignPatterns.Builder;

public class User
{
    public string Name { get; }
    public string Surname { get; }
    public int? Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }

    public User(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    //public User(string name, string surname, int? age)
    //{
    //    Name = name;
    //    Surname = surname;
    //    Age = age;
    //}

    //public User(string name, string surname, int? age, string? phoneNumber)
    //{
    //    Name = name;
    //    Surname = surname;
    //    Age = age;
    //    PhoneNumber = phoneNumber;
    //}

    //public User(string name, string surname, int age, string phoneNumber, string address)
    //{
    //    Name = name;
    //    Surname = surname;
    //    Age = age;
    //    PhoneNumber = phoneNumber;
    //    Address = address;
    //}
}