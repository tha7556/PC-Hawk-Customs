
namespace PrimaryQueries {
    /// <summary>
    /// The hard drive of the Computer
    /// </summary>
    public class Storage : Part {
        private string series, form, type, capacity, cache;
        /// <summary>
        /// Creates a new Storage Part
        /// </summary>
        /// <param name="partNumber">The identifying Part number</param>
        /// <param name="name">The name of the Part</param>
        /// <param name="price">The price of the Part</param>
        /// <param name="series">The series the hard drive belongs to</param>
        /// <param name="form">The form of the hard drive</param>
        /// <param name="type">The type of storage used</param>
        /// <param name="capacity">The amount of data it can hold</param>
        /// <param name="cache">The size of the cache</param>
        public Storage(int partNumber, string name, double price, string series, string form, string type, string capacity, string cache) : base(partNumber,name,price) {
            this.series = series;
            this.form = form;
            this.type = type;
            this.capacity = capacity;
            this.cache = cache;
            table = "storage";
            //Queries.Log(Queries.LogLevel.DEBUG, "Storage(" + partNumber + "," + name + "," + series + "," + form + "," + type + "," + capacity + "," + cache + ");");
        }
        /// <summary>
        /// Gets the series of the hard drive
        /// </summary>
        /// <returns>The series name of the hard drive</returns>
        public string GetSeries() {
            return series;
        }
        /// <summary>
        /// Gets the form of the hard drive
        /// </summary>
        /// <returns>The form of the hard drive</returns>
        public string GetForm() {
            return form;
        }
        /// <summary>
        /// Gets the type of storage used
        /// </summary>
        /// <returns>The type of storage used</returns>
        public string GetStorageType() {
            return type;
        }
        /// <summary>
        /// Gets the amount of data the hard drive can hold
        /// </summary>
        /// <returns>The amount of data the hard drive can hold</returns>
        public string GetCapacity() {
            return capacity;
        }
        /// <summary>
        /// Gets the size of the cache
        /// </summary>
        /// <returns>The size of the cache</returns>
        public string GetCache() {
            return cache;
        }
        /// <summary>
        /// Adds this Part to the Storage, and Part databases
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `storage` (`part number`, `name`, `price`, `series`, `form`, `type`, `capacity`, `cache`) " +
                "VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+form+"', '"+type+"', '"+capacity+"', '"+cache+"');");
        }
        /// <summary>
        /// Converts a MySQL query result into a Storage object
        /// </summary>
        /// <param name="query">The result of the query</param>
        /// <returns>The Storage object created from the result</returns>
        public static Storage GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Storage(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], result[6], result[7]);
        }
        /// <summary>
        /// Gets all Storage objects in the Storage database
        /// </summary>
        /// <returns>A Storage[] containing all Parts in the Storage database</returns>
        public static Storage[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `storage`");
            Storage[] arr = new Storage[result.Length];
            for(int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
        /// <summary>
        /// Gets a Storage object with the given part number
        /// </summary>
        /// <param name="partNumber">The identifying part number</param>
        /// <returns>The Storage object with the part number</returns>
        public static Storage Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `storage` WHERE `part number` = " + partNumber);
            if(result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }
}
