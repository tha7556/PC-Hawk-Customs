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

        public MOBO(int partNumber, string name, double price, string socket, string form, string mRAM, int rAMSlots) : base(partNumber, name, price){
            this.socket = socket;
            this.form = form;
            this.mRAM = mRAM;
            this.rAMSlots = rAMSlots;
            table = "motherboard";
        }

        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `motherboard` (`part number`, `name`, `price`, `socket`, `form factor`, `mRAM`, `rAMSlots`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", '" + socket + "', " + form + ", " + mRAM + ", '" + rAMSlots + "')");
        }

        public static MOBO GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new MOBO(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], int.Parse(result[6]));
        }

        public static MOBO[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `motherboard`");
            MOBO[] arr = new MOBO[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        public static MOBO Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `storage` WHERE `motherboard` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
    }
}
