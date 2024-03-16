﻿
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab16.Serialization
{
    #pragma warning disable SYSLIB0011
    internal class BinSerializator<T> : ISerializator<T>
    {
        public string FileType { get => "dat"; }
        private readonly BinaryFormatter _binFormatter = new();

        public T? Load(string filePath)
        {
            using FileStream fileStream = new (filePath, FileMode.Open);
            return (T?)_binFormatter.Deserialize(fileStream);
        }

        public void Save(T objNeedToSave, string filePath)
        {
            using FileStream fileStream = new (filePath, FileMode.Create);
            _binFormatter.Serialize(fileStream, objNeedToSave);
        }
    #pragma warning restore SYSLIB0011
    }

}
