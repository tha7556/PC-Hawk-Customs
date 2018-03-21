
namespace PrimaryQueries {
    /// <summary>
    /// An individual Part of a computer
    /// </summary>
    class Part {
        private int partNumber;
        private string name, componentType;
        private double price;
        /// <summary>
        /// Creates a new Part object
        /// </summary>
        /// <param name="partNumber">The identifying Part number</param>
        /// <param name="name">The name of the Part</param>
        /// <param name="componentType">The type of Part that it is</param>
        /// <param name="price">The price of the Part</param>
        public Part(int partNumber, string name, string componentType, double price) {
            this.partNumber = partNumber;
            this.name = name;
            this.componentType = componentType;
            this.price = price;
        }
        /// <summary>
        /// Gets the Part's identifying number
        /// </summary>
        /// <returns>The Part's identifying number</returns>
        public int GetPartNumber() {
            return partNumber;
        }
        /// <summary>
        /// Gets the name of the Part
        /// </summary>
        /// <returns>The name of the Part</returns>
        public string GetName() {
            return name;
        }
        /// <summary>
        /// Gets the type of Part it is
        /// </summary>
        /// <returns>The type of Part this is</returns>
        public string GetComponentType() {
            return componentType;
        }
        /// <summary>
        /// Gets the price of the Part
        /// </summary>
        /// <returns>The price of the Part</returns>
        public double GetPrice() {
            return price;
        }
        /// <summary>
        /// Changes the Part's price to a new Price
        /// </summary>
        /// <param name="newPrice">The new Price for the Part</param>
        public void SetPrice(double newPrice) {
            price = newPrice;
        }
        /// <summary>
        /// Gets the Part in the Database with the given partNumber. NOTE: Only returns the first Part found if there are more than one with the same number.
        /// </summary>
        /// <param name="partNumber">The partNumber of the desired Part</param>
        /// <returns>The Part found by the query</returns>
        public static Part GetPart(int partNumber) {
            string[] query = PrimaryQueries.Query("SELECT * FROM part WHERE `part number` = " + partNumber);
            if(query.Length > 0)
                return GetPartFromQuery(query[0]);
            return null;
        }
        /// <summary>
        /// Gets an array of Parts compatable with this one
        /// </summary>
        /// <returns>An array of Parts compatable with this one</returns>
        public Part[] getCompatableParts() {
            string[] result = PrimaryQueries.Query("Call getCompatability(" + partNumber + ")");
            Part[] parts = new Part[result.Length];
            for(int i = 0; i < result.Length; i++) {
                parts[i] = GetPartFromQuery(result[i]);
            }
            return parts;
        }
        /// <summary>
        /// Creates a string representation of the Part
        /// </summary>
        /// <returns>The string representation of the Part</returns>
        public override string ToString() {
            return name;
        }
        /// <summary>
        /// Converts a MySQL query result into a Part object. Query must return the form: partNumber\0name\0price\0componentType
        /// </summary>
        /// <param name="result">The MySQL query result</param>
        /// <returns>The Part object from the query</returns>
        public static Part GetPartFromQuery(string result) {
            string[] line = result.Split('\0');
            return new Part(int.Parse(line[0]), line[1], line[3], double.Parse(line[2]));
        }
    }
}
