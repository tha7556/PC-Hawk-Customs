﻿

namespace PrimaryQueries {
    /// <summary>
    /// The Graphics Card of the Computer
    /// </summary>
    public class GraphicsCard : Part {
        /// <summary>
        /// The series the Graphics Card belongs to
        /// </summary>
        public string series { get; set; }
        /// <summary>
        /// The chipset used int the Graphics Card
        /// </summary>
        public string chipSet { get; set; }
        /// <summary>
        /// The amount of memory the Graphics Card has
        /// </summary>
        public string memory { get; set; }
        /// <summary>
        /// The speed of the clock on the Graphics Card
        /// </summary>
        public string coreClock { get; set; }
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
        /// Adds this Part to the GraphicsCard and Part databases
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `graphicscard` (`part number`, `name`, `price`, `series`, `chipset`, `memory`, `core clock`)" +
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
            string[] result = Queries.Query("SELECT * FROM `graphicscard`");
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
            string[] result = Queries.Query("SELECT * FROM `graphicscard` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
        /// <summary>
        /// Gets the attributes of the Graphics Card
        /// </summary>
        /// <returns>A string containing the attributes</returns>
        public new string GetAttributes() {
            return "Name: "+name+
                "\nSeries: "+series+
                "\nChipset: "+chipSet+
                "\nMemory: "+memory+
                "\nCore Clock: "+coreClock;
        }
    }
}
