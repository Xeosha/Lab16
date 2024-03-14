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
using Newtonsoft.Json;

namespace Lab16.Serialization
{
    internal class JSONSerializator<T> : ISerializator<T>
    {
        public string FileType => "json";

        public JsonSerializerSettings settings { get; set; } = new JsonSerializerSettings()
        {
            //для полиморфизма, чтобы могла обращаться к атрибутам дочерних классов
            TypeNameHandling = TypeNameHandling.All,
            //разбивает файл из одной строки, чтобы норм было
            Formatting = Formatting.Indented
        };

        public T? Load(string filePath)
        {
            string json = System.IO.File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<T>(json, settings);
        }

        public void Save(T objNeedToSave, string filePath)
        {
            string json = JsonConvert.SerializeObject(objNeedToSave, settings);
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
