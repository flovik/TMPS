using System.Collections.Concurrent;
using StructuralDesignPatterns.Proxy.Interfaces;
using StructuralDesignPatterns.Proxy.Models;

namespace StructuralDesignPatterns.Proxy;

public class UserRepositoryProxy : IUserRepository
{
    private IDictionary<Guid, byte[]> PhotosCache;
    private IUserRepository _userRepository;
    public UserRepositoryProxy(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        PhotosCache = new ConcurrentDictionary<Guid, byte[]>();
    }

    public void CreateUser(User user)
    {
        _userRepository.CreateUser(user);
    }

    public byte[] GetUserPhoto(Guid id)
    {
        if (PhotosCache.ContainsKey(id)) return PhotosCache[id];

        var photo = _userRepository.GetUserPhoto(id);
        PhotosCache.Add(id, photo);

        return photo;
    }
}