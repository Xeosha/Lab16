using EventBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lab_10lib;
using System.Text.Json;

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
