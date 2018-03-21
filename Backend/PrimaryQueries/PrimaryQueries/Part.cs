
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
            this.price = newPrice;
        }
    }
}
