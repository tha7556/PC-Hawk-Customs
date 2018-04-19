using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    /// <summary>
    /// A Motherboard of a Computer
    /// </summary>
    public class MOBO : Part {
        /// <summary>
        /// The socket of the Motherboard
        /// </summary>
        public string socket {get; set;}
        /// <summary>
        /// The form of the Motherboard
        /// </summary>
        public string form {get; set;}
        /// <summary>
        /// The max ram of the Motherboard
        /// </summary>
        public string mRAM{get; set;}
        /// <summary>
        /// The number of Ram slots
        /// </summary>
        public int rAMSlots { get; set; }

        /// <summary>
        /// Motherboard Object constructor
        /// </summary>
        /// <param name="partNumber">The identifying part number</param>
        /// <param name="name">The name of the Part</param>
        /// <param name="price">The price of the Part</param>
        /// <param name="socket">The socket of the Motherboard</param>
        /// <param name="form">The form of the Motherboard</param>
        /// <param name="mRAM">The max ram of the Motherboard</param>
        /// <param name="rAMSlots">The number of ram slots</param>
        public MOBO(int partNumber, string name, double price, string socket, string form, string mRAM, int rAMSlots) : base(partNumber, name, price){
            this.socket = socket;
            this.form = form;
            this.mRAM = mRAM;
            this.rAMSlots = rAMSlots;
            table = "motherboard";
        }

        /// <summary>
        /// Inserts the selected MOBO object into the motherboard table
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `motherboard` (`part number`, `name`, `price`, `socket`, `form factor`, `max ram`, `ram slots`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + socket + "', '" + form + "', '" + mRAM + "', '" + rAMSlots + "')");
        }


        /// <summary>
        /// Converts a MySQL query into a MOBO object
        /// </summary>
        /// <param name="query">The query result</param>
        /// <returns>The MOBO created from the result</returns>
        public static MOBO GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new MOBO(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[6], int.Parse(result[5]));
        }

        /// <summary>
        /// Returns all elements from the database motherboard table as an array of MOBO objects
        /// </summary>
        /// <returns>A MOBO[] of all Motherboards in the database</returns>
        public static MOBO[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `motherboard`");
            MOBO[] arr = new MOBO[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        /// <summary>
        /// Returns the MOBO object queried from database selected by parameter part numebr
        /// </summary>
        /// <param name="partNumber">The part number to get</param>
        /// <returns>The MOBO found from the part number</returns>
        public static MOBO Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `motherboard` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
        /// <summary>
        /// Gets the attributes of the Motherboard
        /// </summary>
        /// <returns>A string containing the attributes</returns>
        public new string GetAttributes() {
            return "Name: "+name+
                "\nSocket: "+socket+
                "\nForm: "+form+
                "\nMax Ram: "+mRAM+
                "\nRam Slots: "+rAMSlots;
        }
    }
}
