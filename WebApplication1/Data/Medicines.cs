using System.Text;

namespace WebApplication1.Data
{
    public class Medicines
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
        public int Count { get; set; }
        public byte[] Photo { get; set; }

        public Medicines(int ID, string Name, string Storage, int Count, byte[] Photo)
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
            Photo = Convert.FromBase64String(data[4]);
        }
    }
}
