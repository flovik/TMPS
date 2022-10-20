namespace CreationalDesignPatterns.Builder.Interfaces;

public interface IUserBuilder
{
    public UserBuilder SetAge(int age);
    public UserBuilder SetPhone(string phoneNumber);
    public UserBuilder SetAddress(string address);
}