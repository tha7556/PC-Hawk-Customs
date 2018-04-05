using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    public class MOBO : Part {
        private string socket {get; set;}
        private string form {get; set;}
        private string mRAM{get; set;}
        private int rAMSlots { get; set; }

        /// <summary>
        /// Motherboard Object constructor
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="socket"></param>
        /// <param name="form"></param>
        /// <param name="mRAM"></param>
        /// <param name="rAMSlots"></param>
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
        /// <param name="query"></param>
        /// <returns></returns>
        public static MOBO GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new MOBO(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[6], int.Parse(result[5]));
        }

        /// <summary>
        /// Returns all elements from the database motherboard table as an array of MOBO objects
        /// </summary>
        /// <returns></returns>
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
        /// <param name="partNumber"></param>
        /// <returns></returns>
        public static MOBO Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `storage` WHERE `motherboard` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }
}
