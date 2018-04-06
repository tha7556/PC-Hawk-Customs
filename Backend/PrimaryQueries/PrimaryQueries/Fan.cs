using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    public class Fan : Part{
        public int rpm { get; set; }
        public double nl { get; set; }

        /// <summary>
        /// Constructor for Fan Class
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="rpm"></param>
        /// <param name="nl"></param>
        public Fan(int partNumber, string name, double price, int rpm, double nl) : base(partNumber, name, price) {
            this.rpm = rpm;
            this.nl = nl;
            table = "fan";
        }

        /// <summary>
        /// Inserts Fan object into the appropriate table
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `fan` (`part number`, `name`, `price`, `rpm`, `noise level`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + rpm + "', " + nl + ")");
        }

        /// <summary>
        /// Queries the database for object creation
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static Fan GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Fan(int.Parse(result[0]), result[1], double.Parse(result[2]), int.Parse(result[3]), double.Parse(result[4]));
        }
        
        /// <summary>
        /// Return all fan objects from the relevant table
        /// </summary>
        /// <returns></returns>
        public static Fan[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `fan`");
            Fan[] arr = new Fan[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        /// <summary>
        /// Returns a fan object, queried for by part number
        /// </summary>
        /// <param name="partNumber"></param>
        /// <returns></returns>
        public static Fan Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `fan` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
        public new string GetAttributes() {
            return "Name: " + name+
                "\nRPM: " + rpm+
                "\nNoise Level: "+nl;
        }
    }
}
