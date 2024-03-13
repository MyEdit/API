namespace WebApplication1.Data
{
    public class Medicines
    {
        public Medicines(int ID, string Name, string Storage, int Count)
        {
            this.ID = ID;
            this.Name = Name;
            this.Storage = Storage;
            this.Count = Count;
        }

        public static List<Medicines> data =
        [
            new Medicines(1, "Парацетамол", "Пушкинский", 789),
            new Medicines(2, "Цитрамон", "Пушкинский", 986),
            new Medicines(3, "Нош-па", "Алексеевский", 874),
            new Medicines(4, "Ибупрофен", "Ивановский", 578)
        ];

        public int ID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
        public int Count { get; set; }
    }
}
