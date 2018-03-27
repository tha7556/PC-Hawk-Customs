

namespace PrimaryQueries {
    /// <summary>
    /// The Graphics Card of the Computer
    /// </summary>
    class GraphicsCard : Part {
        private string series, chipSet, memory, coreClock;
        /// <summary>
        /// Creates a Graphics Card
        /// </summary>
        /// <param name="partNumber">The identifying Part Number</param>
        /// <param name="name">The name of the Part</param>
        /// <param name="price">The price of the Part</param>
        /// <param name="series">The series that the Graphics Card belongs to</param>
        /// <param name="chipSet">The chipset used in the Graphics Card</param>
        /// <param name="memory">The amount of memory the Graphics Card has</param>
        /// <param name="coreClock">The speed of the clock on the Graphics Card</param>
        public GraphicsCard(int partNumber, string name, double price, string series, string chipSet, string memory, string coreClock) : base(partNumber,name,price) {
            this.series = series;
            this.chipSet = chipSet;
            this.memory = memory;
            this.coreClock = coreClock;
            table = "graphicscard";
        }
        /// <summary>
        /// Gets the series that the Graphics Card belongs to
        /// </summary>
        /// <returns>The series of the Graphics Card</returns>
        public string GetSeries() {
            return series;
        }
        /// <summary>
        /// Gets the chipset used in the Graphics Card
        /// </summary>
        /// <returns>The chipset of the Graphics Card</returns>
        public string GetChipSet() {
            return chipSet;
        }
        /// <summary>
        /// Gets the amount of memory in the Graphics Card
        /// </summary>
        /// <returns>The amount of memory in the Graphics Card</returns>
        public string GetMemory() {
            return memory;
        }
        /// <summary>
        /// Gets the speed of the clock
        /// </summary>
        /// <returns>The speed of the clock</returns>
        public string GetCoreClock() {
            return coreClock;
        }
        /// <summary>
        /// Adds this Part to the GraphicsCard and Part databases
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            PrimaryQueries.Query("INSERT INTO `graphicscard` (`part number`, `name`, `price`, `series`, `chipset`, `memory`, `core clock`)" +
                " VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+chipSet+"', '"+memory+"', '"+coreClock+"')");
        }
        /// <summary>
        /// Converts a MySQL query result into a GraphicsCard
        /// </summary>
        /// <param name="query">The MySQL query result</param>
        /// <returns>The Graphics Card created from the MySQL query</returns>
        public static GraphicsCard GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new GraphicsCard(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5],result[6]);
        }
        /// <summary>
        /// Gets all Parts in the GraphicsCard database
        /// </summary>
        /// <returns>A GraphicsCard[] of all Graphics Cards in the database</returns>
        public static GraphicsCard[] GetAll() {
            string[] result = PrimaryQueries.Query("SELECT * FROM `graphicscard`");
            GraphicsCard[] arr = new GraphicsCard[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
        /// <summary>
        /// Gets a GraphicsCard object with the given part number
        /// </summary>
        /// <param name="partNumber">The identifying part number</param>
        /// <returns>The GraphicsCard object with the part number</returns>
        public static GraphicsCard Get(int partNumber) {
            string[] result = PrimaryQueries.Query("SELECT * FROM `graphicscard` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }
}
