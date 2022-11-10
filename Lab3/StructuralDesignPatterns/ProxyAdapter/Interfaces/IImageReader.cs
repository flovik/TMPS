namespace StructuralDesignPatterns.ProxyAdapter.Interfaces;

public interface IImageReader
{
    public FileStream ReadImage(string path);
}