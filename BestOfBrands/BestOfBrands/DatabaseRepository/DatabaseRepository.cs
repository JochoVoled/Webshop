using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml.Serialization;
using BestOfBrands.Interfaces;

namespace BestOfBrands.DatabaseRepository
{
    public class DatabaseRepository<T> : IDatabaseRepository<T>
    {
        public DatabaseRepository(string fileName)
        {
            Path = Directory.GetCurrentDirectory() + $"\\{fileName}.xml";
        }

        private string Path { get; set; }

        public void Save(T item)
        {
            var list = GetAll();
            list.Add(item);

            var writer = new XmlSerializer(typeof(List<T>));
            var file = File.Create(Path);

            writer.Serialize(file, list);
            file.Close();
        }

        public List<T> GetAll()
        {
            var reader = new XmlSerializer(typeof(List<T>));
            var file = File.Create(Path);

            var list = (List<T>)reader.Deserialize(file);
            file.Close();

            return list;
        }
    }
}