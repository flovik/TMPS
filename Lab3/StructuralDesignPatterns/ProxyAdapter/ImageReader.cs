using StructuralDesignPatterns.ProxyAdapter.Interfaces;

namespace StructuralDesignPatterns.ProxyAdapter;

public class ImageReader : IImageReader
{
    public FileStream ReadImage(string path)
    {
        var fs = new FileStream(
            path,
            FileMode.OpenOrCreate);
        return fs;
    }
}