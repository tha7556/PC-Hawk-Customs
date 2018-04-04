using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    class Fan : Part{
        private int rpm { get; set; }
        private double nl { get; set; }

        public Fan(int partNumber, string name, double price, int rpm, double nl) : base(partNumber, name, price) {
            this.rpm = rpm;
            this.nl = nl;
            table = "fan";
        }

        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `fan` (`part number`, `name`, `price`, `rpm`, `noise level`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + rpm + "', " + nl + ")");
        }

        public static Fan GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Fan(int.Parse(result[0]), result[1], double.Parse(result[2]), int.Parse(result[3]), double.Parse(result[4]));
        }

        public static Fan[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `fan`");
            Fan[] arr = new Fan[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        public static Fan Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `storage` WHERE `fan` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }
}
