
namespace PrimaryQueries {
    /// <summary>
    /// A Case for a Computer
    /// </summary>
    class Case : Part {
        private string type, powerSupply;
        private int externalSize, internalSize;
        /// <summary>
        /// Creates a new Case
        /// </summary>
        /// <param name="partNumber">The identifying number for the part</param>
        /// <param name="name">The name of the case</param>
        /// <param name="price">The price of the part</param>
        /// <param name="type">The type of case</param>
        /// <param name="externalSize">TODO</param>
        /// <param name="internalSize">TODO</param>
        /// <param name="powerSupply">Watts of the built in powerSupply if there is one</param>
        public Case(int partNumber, string name, double price, string type, int externalSize, int internalSize, string powerSupply) : base(partNumber, name, price) {
            this.type = type;
            this.powerSupply = powerSupply;
            this.externalSize = externalSize;
            this.internalSize = internalSize;
        }
        /// <summary>
        /// Gets the type of Case
        /// </summary>
        /// <returns>The type of Case</returns>
        public string GetCaseType() {
            return type;
        }
        /// <summary>
        /// Gets the Watts of the built in powerSupply if there is one
        /// </summary>
        /// <returns>The Watts of the built in powerSupply if there is one</returns>
        public string GetPowerSupply() {
            return powerSupply;
        }
        //TODO: what is this?
        public int GetExternalSize() {
            return externalSize;
        }
        //TODO: what is this?
        public int GetInternalSize() {
            return internalSize;
        }
        /// <summary>
        /// Adds this Part to the pcCase and Part databases
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            PrimaryQueries.Query("INSERT INTO `pc case` (`part number`, `name`, `price`, `type`, `external size`, `internal size`, `power supply`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + type + "', "+externalSize+", "+internalSize+", '"+powerSupply+"')");
        }
        /// <summary>
        /// Converts a MySQL query into a Case object
        /// </summary>
        /// <param name="query">The MySQL query result</param>
        /// <returns>The Case created from the MySQL query</returns>
        public static Case GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Case(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], int.Parse(result[4]), int.Parse(result[5]), result[6]);
        }
        /// <summary>
        /// Gets all Cases from the pcCase database
        /// </summary>
        /// <returns>A Case[] of all Cases in the database</returns>
        public static Case[] GetAll() {
            string[] result = PrimaryQueries.Query("SELECT * FROM `pc case`");
            Case[] arr = new Case[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
    }
}
