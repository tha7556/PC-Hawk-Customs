using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    /// <summary>
    /// The Memory of the Computer
    /// </summary>
    public class Memory : Part {
        /// <summary>
        /// The speed of The Memory
        /// </summary>
        public string speed { get; set; }
        /// <summary>
        /// The type used
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// The delay time between the moment a memory controller tells the memory module to access a particular memory column on a RAM module
        /// </summary>
        public string cas { get; set; }
        /// <summary>
        /// The modules of the Memory
        /// </summary>
        public string modules { get; set; }
        /// <summary>
        /// The size of the Memory
        /// </summary>
        public string size { get; set; }

        /// <summary>
        /// Memory Object constructor
        /// </summary>
        /// <param name="partNumber">The identifying part number</param>
        /// <param name="name">The name of the part</param>
        /// <param name="price">The price of the part</param>
        /// <param name="speed">The speed of the Memory</param>
        /// <param name="type">The type used</param>
        /// <param name="cas">The delay time between the moment a memory controller tells the memory module to access a particular memory column on a RAM module</param>
        /// <param name="modules">The modules of the Memory</param>
        /// <param name="size">The size of the Memory</param>
        public Memory(int partNumber, string name, double price, string speed, string type, string cas, string modules, string size) : base(partNumber,name,price) {
            this.speed = speed;
            this.type = type;
            this.cas = cas;
            this.modules = modules;
            this.size = size;
            table = "memory";
        }

        /// <summary>
        /// Inserts the selected object into the relevant table in database
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `memory` (`part number`, `name`, `price`, `speed`, `type`, `cas`, `modules`, `size`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + speed + "', '" + type + "', '" + cas + "', '" + modules + "', '" + size + "')");
        }

        /// <summary>
        /// /// Converts a MySQL query into a Memory object
        /// </summary>
        /// <param name="query">The query result</param>
        /// <returns>The Memory resulting from the query</returns>
        public static Memory GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Memory(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], result[6], result[7]);
        }

        /// <summary>
        /// Returns all elements within database memory table as an array of Memory objects
        /// </summary>
        /// <returns>A Memory[] with all Memory in the database</returns>
        public static Memory[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `memory`");
            Memory[] arr = new Memory[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        /// <summary>
        /// Gets a Memory object from the database based on parameter part number
        /// </summary>
        /// <param name="partNumber">The part number of the Memory</param>
        /// <returns>The Memory retrieved from the part number</returns>
        public static Memory Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `memory` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
        /// <summary>
        /// Gets the attributes of the Memory
        /// </summary>
        /// <returns>A string containing the attributes</returns>
        public new string GetAttributes() {
            return "Name: "+name+
                "\nSpeed: "+speed+
                "\nCAS: "+cas+
                "\nModules: "+modules;
        }
    }


}
