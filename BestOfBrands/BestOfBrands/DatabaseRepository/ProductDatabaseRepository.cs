using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using BestOfBrands.Interfaces;

namespace BestOfBrands.DatabaseRepository
{
    public class ProductDatabaseRepository : IDatabaseRepository<IProduct>
    {
        public ProductDatabaseRepository()
        {
            Path = Directory.GetCurrentDirectory() + @"\Products.xml";

            if (Directory.GetFiles(Directory.GetCurrentDirectory()).Contains("Products.xml"))
            {
                LoadFile();
            }
            else
            {
                Products = new List<IProduct>();
                SaveFile();
            }
        }

        private string Path { get; set; }
        private List<IProduct> Products { get; set; }
        private int ProductIDIndex { get; set; } = -1;

        public void Save(IProduct item)
        {
            Products.Add(item);
            SaveFile();
        }

        public List<IProduct> GetAll()
        {
            return Products;
        }

        public int NextItemID()
        {
            return Products[++ProductIDIndex].ProductID;
        }

        private void SaveFile()
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<IProduct>));
            FileStream file = File.Create(Path);

            writer.Serialize(file, Products);
            file.Close();
        }

        private void LoadFile()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<IProduct>));
            FileStream file = File.Create(Path);

            Products = (List<IProduct>)reader.Deserialize(file);
            file.Close();
        }
    }
}