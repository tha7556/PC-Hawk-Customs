using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    /// <summary>
    /// The Fan of a Computer
    /// </summary>
    public class Fan : Part{
        /// <summary>
        /// The rpm of the fan
        /// </summary>
        public int rpm { get; set; }
        /// <summary>
        /// The noise level of the Fan
        /// </summary>
        public double nl { get; set; }

        /// <summary>
        /// Constructor for Fan Class
        /// </summary>
        /// <param name="partNumber">The part number of the Fan</param>
        /// <param name="name">The name of the Fan</param>
        /// <param name="price">The price of the Fan</param>
        /// <param name="rpm">The rpm of the Fan</param>
        /// <param name="nl">The noise level of the Fan</param>
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
        /// Converts a MySQL result into a Fan
        /// </summary>
        /// <param name="query">The MySQL query result</param>
        /// <returns>The fan created from the query result</returns>
        public static Fan GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Fan(int.Parse(result[0]), result[1], double.Parse(result[2]), int.Parse(result[3]), double.Parse(result[4]));
        }
        
        /// <summary>
        /// Return all fan objects from the relevant table
        /// </summary>
        /// <returns>A Fan[] of all fans in the database</returns>
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
        /// <param name="partNumber">The part number to get</param>
        /// <returns>The Fan from the part number</returns>
        public static Fan Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `fan` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null; 
        }
        /// <summary>
        /// Gets the attributes of the Fan
        /// </summary>
        /// <returns>A string containing the attributes</returns>
        public new string GetAttributes() {
            return "Name: " + name+
                "\nRPM: " + rpm+
                "\nNoise Level: "+nl;
        }
    }
}
