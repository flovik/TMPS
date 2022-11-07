using System.Collections.Concurrent;
using StructuralDesignPatterns.Proxy.Context;
using StructuralDesignPatterns.Proxy.Interfaces;
using StructuralDesignPatterns.Proxy.Models;

namespace StructuralDesignPatterns.Proxy.Repositories;

public class UserRepository : IUserRepository
{
    private IDictionary<Guid, FileStream> PhotosCache;
    private DesignPatternsContext _context;

    public UserRepository(DesignPatternsContext context)
    {
        PhotosCache = new ConcurrentDictionary<Guid, FileStream>();
        _context = context;
    }

    public void CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public byte[] GetUserPhoto(Guid id)
    {
        var photo = _context.Users.FirstOrDefault(x => x.UserId == id).Photo;
        return photo;
    }
}