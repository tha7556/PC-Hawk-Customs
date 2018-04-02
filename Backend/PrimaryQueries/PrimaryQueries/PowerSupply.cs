
namespace PrimaryQueries {
    /// <summary>
    /// A Power Supply for the Computer
    /// </summary>
    public class PowerSupply : Part {
        private string series, form, efficiency, watts, modular;
        /// <summary>
        /// Creates a new Power Supply
        /// </summary>
        /// <param name="partNumber">The identifying Part Number</param>
        /// <param name="name">The Name of the Part</param>
        /// <param name="price">The Price of the Part</param>
        /// <param name="series">The series that the Power Supply belongs to</param>
        /// <param name="form">The form of the Power Supply</param>
        /// <param name="efficiency">The efficiency rating of the Power Supply</param>
        /// <param name="watts">The wattage of the Power Supply</param>
        /// <param name="modular">The degree of modularity of the Power Supply</param>
        public PowerSupply(int partNumber, string name, double price, string series, string form, string efficiency, string watts, string modular) : base(partNumber, name, price) {
            this.series = series;
            this.form = form;
            this.efficiency = efficiency;
            this.watts = watts;
            this.modular = modular;
            table = "powersupply";
        }
        /// <summary>
        /// Gets the series that the Power Supply belongs to
        /// </summary>
        /// <returns>The name of the series of the Power Supply</returns>
        public string GetSeries() {
            return series;
        }
        /// <summary>
        /// Gets the form of the Power Supply
        /// </summary>
        /// <returns>The Form of the Power Supply</returns>
        public string GetForm() {
            return form;
        }
        /// <summary>
        /// Gets the efficiency rating of the Power Supply
        /// </summary>
        /// <returns>The efficiency rating of the Power Supply</returns>
        public string GetEfficiency() {
            return efficiency;
        }
        /// <summary>
        /// Gets the wattage of the Power Supply
        /// </summary>
        /// <returns>The Power Supply wattage</returns>
        public string GetWatts() {
            return watts;
        }
        /// <summary>
        /// Gets the degree of modularity of the Power Supply
        /// </summary>
        /// <returns>The degree of modularity</returns>
        public string GetModular() {
            return modular;
        }
        /// <summary>
        /// Adds this Part to the PowerSupply and Part databases
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `powersupply` (`part number`, `name`, `price`, `series`, `form`, `efficiency`, `watts`, `modular`) " +
                "VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+form+"', '"+efficiency+"', '"+watts+"', '"+modular+"');");
        }
        /// <summary>
        /// Converts a MySQL query result into a PowerSupply
        /// </summary>
        /// <param name="query">The MySQL query result</param>
        /// <returns>The PowerSupply created from the query result</returns>
        public static PowerSupply GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new PowerSupply(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], result[6], result[7]);
        }
        /// <summary>
        /// Gets all PowerSupplies from the database
        /// </summary>
        /// <returns>A PowerSupply[] of all PowerSupplies in the database</returns>
        public static PowerSupply[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `powersupply`");
            PowerSupply[] arr = new PowerSupply[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
        /// <summary>
        /// Gets a PowerSupply object with the given part number
        /// </summary>
        /// <param name="partNumber">The identifying part number</param>
        /// <returns>The PowerSupply object with the part number</returns>
        public static PowerSupply Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `storage` WHERE `powersupply` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }
}
