using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    public class Memory : Part {
        private string speed { get; set; }
        private string type { get; set; }
        private string cas { get; set; }
        private string modules { get; set; }
        private string size { get; set; }

    public Memory(int partNumber, string name, double price, string speed, string type, string cas, string modules, string size) : base(partNumber,name,price) {
            this.speed = speed;
            this.type = type;
            this.cas = cas;
            this.modules = modules;
            this.size = size;
            table = "memory";
        }

        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `memory` (`part number`, `name`, `price`, `speed`, `type`, `cas`, `modules`, `size`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + speed + "', '" + type + "', '" + cas + "', '" + modules + "', '" + size + "')");
        }

        public static Memory GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Memory(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], result[6], result[7]);
        }

        public static Memory[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `memory`");
            Memory[] arr = new Memory[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        public static Memory Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `storage` WHERE `memory` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }


}
