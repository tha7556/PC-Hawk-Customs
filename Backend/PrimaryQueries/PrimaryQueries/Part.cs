//TODO: Extend Part into Subparts
//TODO: Part description?
//TODO: Part images?
//TODO: Add Part to database
//TODO: Part ratings?
namespace PrimaryQueries {
    /// <summary>
    /// An individual Part of a computer
    /// </summary>
    class Part {
        protected int partNumber;
        protected string name, table;
        protected double price;
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
            table = "part";
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
<<<<<<< HEAD
            string[] query = PrimaryQueries.Query("Call setPartPrice(" + partNumber + "," + newPrice + ")");
=======
            double oldPrice = price;
>>>>>>> Tyler-Backend
            price = newPrice;
            PrimaryQueries.Query("UPDATE `"+table+"` SET `price` = '"+price+"' WHERE `"+table+"`.`part number` = "+partNumber+";");
            PrimaryQueries.Log(PrimaryQueries.LogLevel.DEBUG, "Changed Price of Part [" + partNumber + "] from: $"+oldPrice + " to: $" + newPrice);
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
            return GetType() + ": " + name + " " + partNumber + " " + price;
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
        /// <summary>
        /// Gets all Parts in the Part database
        /// </summary>
        /// <returns>A Part[] containing all Parts in the database</returns>
        public static Part[] GetAllParts() {
            Storage[] storages = Storage.GetAll();
            GraphicsCard[] cards = GraphicsCard.GetAll();
            Case[] cases = Case.GetAll();
            PowerSupply[] supplies = PowerSupply.GetAll();
            int length = storages.Length + cards.Length + cases.Length + supplies.Length;
            Part[] parts = new Part[length];
            storages.CopyTo(parts, 0);
            cards.CopyTo(parts, storages.Length);
            cases.CopyTo(parts, cards.Length+storages.Length);
            supplies.CopyTo(parts, cases.Length+ cards.Length + storages.Length);
            return parts;
        }
        /// <summary>
        /// Gets a Part with the given part number
        /// </summary>
        /// <param name="partNumber">The number of the desired Part</param>
        /// <returns>The Part with the given part number</returns>
        public static Part GetPart(int partNumber) {
            string[] result = PrimaryQueries.Query("SELECT * FROM `part` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                string[] p = result[0].Split('\0');
                string type = p[1].ToLower();
                if (type.Equals("graphics card"))
                    type = "graphicscard";
                else if (type.Equals("power supply"))
                    type = "powersupply";
                else if (type.Equals("case"))
                    type = "pc case";
                result = PrimaryQueries.Query("SELECT * FROM `" + type + "` WHERE `part number` = " + partNumber);
                if(result.Length > 0) {
                    switch(type) {
                        case "storage":
                            return Storage.GetFromQuery(result[0]);
                        case "graphicscard":
                            return GraphicsCard.GetFromQuery(result[0]);
                        case "pc case":
                            return Case.GetFromQuery(result[0]);
                        case "powersupply":
                            return PowerSupply.GetFromQuery(result[0]);
                        default:
                            return null;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Adds this Part to the Part database
        /// </summary>
        public void AddToDatabase() {
            string type = "";
            if(this is Storage) {
                type = "Storage";
            }
            else if(this is GraphicsCard) {
                type = "Graphics Card";
            }
            else if(this is Case) {
                type = "Case";
            }
            else if(this is PowerSupply) {
                type = "Power Supply";
            }
            PrimaryQueries.Query("INSERT INTO `part` (`part number`, `component type`) VALUES ("+partNumber+", '"+type+"');"); ;
        }
    }
}
