
using System.Xml.Serialization;


namespace Lab16.Serialization
{
    internal class XMLSerializator<T> : ISerializator<T>
    {
        public string FileType { get => "xml"; }
        public T? Load(string filePath)
        {
            XmlSerializer serializer = new (typeof(T));
            using FileStream fileStream = new (filePath, FileMode.Open);
            return (T?)serializer.Deserialize(fileStream);
        }

        public void Save(T objNeedToSave, string filePath)
        {
            using FileStream fileStream = new (filePath, FileMode.Create);
            XmlSerializer serializer = new (objNeedToSave.GetType());
            serializer.Serialize(fileStream, objNeedToSave);
        }
    }

}
