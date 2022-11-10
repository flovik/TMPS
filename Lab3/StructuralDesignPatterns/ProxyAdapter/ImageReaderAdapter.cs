using StructuralDesignPatterns.ProxyAdapter.Interfaces;

namespace StructuralDesignPatterns.ProxyAdapter;

public class ImageReaderAdapter : ITargetInterface
{

    private IImageReader _imageReader;

    public ImageReaderAdapter(IImageReader imageReader)
    {
        _imageReader = imageReader;
    }

    public byte[] ReadImage(string path)
    {
        using var fs = _imageReader.ReadImage(path);
        using var ms = new MemoryStream();
        fs.CopyTo(ms);
        var a = ms.ToArray();
        return a;
    }
}