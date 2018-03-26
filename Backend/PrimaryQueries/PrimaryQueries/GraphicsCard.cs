

namespace PrimaryQueries {
    class GraphicsCard : Part {
        private string series, chipSet, memory, coreClock;
        public GraphicsCard(int partNumber, string name, double price, string series, string chipSet, string memory, string coreClock) : base(partNumber,name,price) {
            this.series = series;
            this.chipSet = chipSet;
            this.memory = memory;
            this.coreClock = coreClock;
        }
        public string GetSeries() {
            return series;
        }
        public string GetChipSet() {
            return chipSet;
        }
        public string GetMemory() {
            return memory;
        }
        public string GetCoreClock() {
            return coreClock;
        }
        public new void AddToDatabase() {
            base.AddToDatabase();
            PrimaryQueries.Query("INSERT INTO `graphicscard` (`part number`, `name`, `price`, `series`, `chipset`, `memory`, `core clock`)" +
                " VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+chipSet+"', '"+memory+"', '"+coreClock+"')");
        }
        public static GraphicsCard GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new GraphicsCard(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5],result[6]);
        }
        public static GraphicsCard[] GetAll() {
            string[] result = PrimaryQueries.Query("SELECT * FROM `storage`");
            GraphicsCard[] arr = new GraphicsCard[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
    }
}
