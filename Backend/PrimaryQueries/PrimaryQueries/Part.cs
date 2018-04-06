//TODO: Extend Part into Subparts
//TODO: Part description?
//TODO: Part images?
//TODO: Add Part to database
//TODO: Part ratings?
namespace PrimaryQueries {
    /// <summary>
    /// An individual Part of a computer
    /// </summary>
    public class Part {
        /// <summary>
        /// The identifying Part Number
        /// </summary>
        public int partNumber { get; set; }
        /// <summary>
        /// The Name of the part
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The table in the database where this Part is stored
        /// </summary>
        public string table { get; set; }
        /// <summary>
        /// The Price of the Part
        /// </summary>
        public double price { get; set; }
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
        /// Changes the Part's price to a new Price
        /// </summary>
        /// <param name="newPrice">The new Price for the Part</param>
        public void SetPrice(double newPrice) {
            string[] query = Queries.Query("Call setPartPrice(" + partNumber + "," + newPrice + ")");
            double oldPrice = price;
            price = newPrice;
            Queries.Query("UPDATE `"+table+"` SET `price` = '"+price+"' WHERE `"+table+"`.`part number` = "+partNumber+";");
            Queries.Log(Queries.LogLevel.DEBUG, "Changed Price of Part [" + partNumber + "] from: $"+oldPrice + " to: $" + newPrice);
        }

       
        /// <summary>
        /// Gets an array of Parts compatable with this one
        /// </summary>
        /// <returns>An array of Parts compatable with this one</returns>
        public Part[] GetCompatableParts() {
            string[] result = Queries.Query("Call getCompatability(" + partNumber + ")");
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
            SetCompatableWith(other.partNumber);
        }
        /// <summary>
        /// Sets this Part to be compatable with another based on the Part's ID
        /// </summary>
        /// <param name="otherPartId">The other Part number to be compatable with</param>
        public void SetCompatableWith(int otherPartId) {
            Queries.Query("CALL setCompatable(" + partNumber + "," + otherPartId + ")");
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
        /// <summary>
        /// Gets all Parts in the Part database
        /// </summary>
        /// <returns>A Part[] containing all Parts in the database</returns>
        public static Part[] GetAllParts() {
            Storage[] storages = Storage.GetAll();
            Queries.Log(Queries.LogLevel.DEBUG, storages.Length.ToString());
            GraphicsCard[] cards = GraphicsCard.GetAll(); // bad
            Queries.Log(Queries.LogLevel.DEBUG, cards.Length.ToString());
            Case[] cases = Case.GetAll();
            Queries.Log(Queries.LogLevel.DEBUG, cases.Length.ToString());
            PowerSupply[] supplies = PowerSupply.GetAll(); //bad
            Queries.Log(Queries.LogLevel.DEBUG, supplies.Length.ToString());
            CPU[] cpus = CPU.GetAll();
            Queries.Log(Queries.LogLevel.DEBUG, cpus.Length.ToString());
            Fan[] fans = Fan.GetAll();
            Queries.Log(Queries.LogLevel.DEBUG, fans.Length.ToString());
            Memory[] mems = Memory.GetAll();
            Queries.Log(Queries.LogLevel.DEBUG, mems.Length.ToString());
            MOBO[] mobs = MOBO.GetAll();
            Queries.Log(Queries.LogLevel.DEBUG, mobs.Length.ToString());
            int length = storages.Length + cards.Length + cases.Length + supplies.Length + cpus.Length + fans.Length + mems.Length + mobs.Length;
            Part[] parts = new Part[length];
            storages.CopyTo(parts, 0);
            cards.CopyTo(parts, storages.Length);
            cases.CopyTo(parts, cards.Length+storages.Length);
            supplies.CopyTo(parts, cases.Length+ cards.Length + storages.Length);
            cpus.CopyTo(parts, cases.Length + cards.Length + storages.Length + supplies.Length);
            fans.CopyTo(parts, cases.Length + cards.Length + storages.Length + supplies.Length+cpus.Length);
            mems.CopyTo(parts, cases.Length + cards.Length + storages.Length + supplies.Length + cpus.Length+fans.Length);
            mobs.CopyTo(parts, cases.Length + cards.Length + storages.Length + supplies.Length + cpus.Length + fans.Length+mems.Length);
            return parts;
        }
        /// <summary>
        /// Gets a Part with the given part number
        /// </summary>
        /// <param name="partNumber">The number of the desired Part</param>
        /// <returns>The Part with the given part number</returns>
        public static Part GetPart(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `part` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                string[] p = result[0].Split('\0');
                string type = p[1].ToLower();
                if (type.Equals("graphics card"))
                    type = "graphicscard";
                else if (type.Equals("power supply"))
                    type = "powersupply";
                else if (type.Equals("pc case"))
                    type = "pc case";
                result = Queries.Query("SELECT * FROM `" + type + "` WHERE `part number` = " + partNumber);
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
                        case "cpu":
                            return CPU.GetFromQuery(result[0]);
                        case "fan":
                            return Fan.GetFromQuery(result[0]);
                        case "memory":
                            return Memory.GetFromQuery(result[0]);
                        case "motherboard":
                            return MOBO.GetFromQuery(result[0]);
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
            if (this is GraphicsCard) {
                type = "Graphics Card";
            }
            else if (this is Case) {
                type = "PC Case";
            }
            else if (this is PowerSupply) {
                type = "Power Supply";
            }
            else if (this is MOBO)
                type = "Motherboard";
            else
                type = GetType().Name;

            Queries.Query("INSERT INTO `part` (`part number`, `component type`) VALUES ("+partNumber+", '"+type+"');"); ;
        }
        /// <summary>
        /// Gets an array of each attribute of the Part
        /// </summary>
        /// <returns></returns>
        public string GetAttributes() {
            return "Name: "+name + "\nPrice: "+price ;
        }
    }
}
