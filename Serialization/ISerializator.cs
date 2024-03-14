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
    public interface ISerializator<T>
    {
        public string FileType { get; }

        public T? Load(string filePath);

        public void Save(T objNeedToSave, string filePath);
    }

}
