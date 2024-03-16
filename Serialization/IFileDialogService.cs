

namespace Lab16.Serialization
{
    public interface IFileDialogService<T>
    {
        string FilePath { get; set; }
        bool OpenFileDialog(ISerializator<T> serializator);
        bool SaveFileDialog(ISerializator<T> serializator);
    }
}
