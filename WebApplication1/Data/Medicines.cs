using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WebApplication1.Data
{
    public class Medicines
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
        public int Count { get; set; }
        public string Photo { get; set; }

        [JsonConstructor]
        public Medicines(int ID, string Name, string Storage, int Count, string Photo)
        {
            this.ID = ID;
            this.Name = Name;
            this.Storage = Storage;
            this.Count = Count;
            this.Photo = Photo;
        }

        public Medicines(string[] data)
        {
            ID = Convert.ToInt32(data[0]);
            Name = data[1];
            Storage = data[2];
            Count = Convert.ToInt32(data[3]);
            Photo = data[4];
        }

        public static List<Medicines> getListMedicines(List<string[]> data)
        {
            return data.Select(item => new Medicines(item)).ToList();
        }
    }
}
