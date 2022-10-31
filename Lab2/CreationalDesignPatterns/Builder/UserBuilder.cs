using CreationalDesignPatterns.Builder.Interfaces;

namespace CreationalDesignPatterns.Builder;

public class UserBuilder : IUserBuilder
{
    private User _user;

    public UserBuilder(string name, string surname)
    {
        _user = new User(name, surname);
    }

    public UserBuilder SetAge(int age)
    {
        _user.Age = age;
        return this;
    }

    public UserBuilder SetPhone(string phoneNumber)
    {
        _user.PhoneNumber = phoneNumber;
        return this;
    }

    public UserBuilder SetAddress(string address)
    {
        _user.Address = address;
        return this;
    }

    public User Build()
    {
        return _user;
    }

    public void Reset(string name, string surname)
    {
        _user = new User(name, surname);
    }
}