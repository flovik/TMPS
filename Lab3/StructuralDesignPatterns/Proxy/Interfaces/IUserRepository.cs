using StructuralDesignPatterns.Proxy.Models;

namespace StructuralDesignPatterns.Proxy.Interfaces;

public interface IUserRepository
{
    void CreateUser(User user);
    byte[] GetUserPhoto(Guid id);
}