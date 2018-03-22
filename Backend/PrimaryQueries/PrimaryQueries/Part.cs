//TODO: Extend Part into Subparts
//TODO: Part description
//TODO: Part images?
//TODO: Add Part to database
//TODO: Change setPrice to modify database
//TODO: Part ratings
namespace PrimaryQueries {
    /// <summary>
    /// An individual Part of a computer
    /// </summary>
    class Part {
        private int partNumber;
        private string name;
        private double price;
        /// <summary>
        /// Creates a new Part object
        /// </summary>
        /// <param name="partNumber">The identifying Part number</param>
        /// <param name="name">The name of the Part</param>
        /// <param name="price">The price of the Part</param>
        public Part(int partNumber, string name, double price) {
            this.partNumber = partNumber;
            this.name = name;
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
        public Part[] GetCompatableParts() {
            string[] result = PrimaryQueries.Query("Call getCompatability(" + partNumber + ")");
            Part[] parts = new Part[result.Length];
            for(int i = 0; i < result.Length; i++) {
                parts[i] = GetPartFromQuery(result[i]);
            }
            return parts;
        }
        /// <summary>
        /// Sets this Part to be compatable with another
        /// </summary>
        /// <param name="other">The other Part to be compatable with</param>
        public void SetCompatableWith(Part other) {
            SetCompatableWith(other.GetPartNumber());
        }
        /// <summary>
        /// Sets this Part to be compatable with another based on the Part's ID
        /// </summary>
        /// <param name="otherPartId">The other Part number to be compatable with</param>
        public void SetCompatableWith(int otherPartId) {
            PrimaryQueries.Query("CALL setCompatable(" + partNumber + "," + otherPartId + ")");
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
            return new Part(int.Parse(line[0]), line[1], double.Parse(line[2]));
        }
    }
}
