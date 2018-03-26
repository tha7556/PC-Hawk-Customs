
namespace PrimaryQueries {
    class PowerSupply : Part {
        private string series, form, efficiency, watts, modular;
        public PowerSupply(int partNumber, string name, double price, string series, string form, string efficiency, string watts, string modular) : base(partNumber, name, price) {
            this.series = series;
            this.form = form;
            this.efficiency = efficiency;
            this.watts = watts;
            this.modular = modular;
        }
        public string GetSeries() {
            return series;
        }
        public string GetForm() {
            return form;
        }
        public string GetEfficiency() {
            return efficiency;
        }
        public string GetWatts() {
            return watts;
        }
        public string GetModular() {
            return modular;
        }
        public new void AddToDatabase() {
            base.AddToDatabase();
            PrimaryQueries.Query("INSERT INTO `powersupply` (`part number`, `name`, `price`, `series`, `form`, `efficiency`, `watts`, `modular`) " +
                "VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+form+"', '"+efficiency+"', '"+watts+"', '"+modular+"');");
        }
        public static PowerSupply GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new PowerSupply(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], result[6], result[7]);
        }
        public static PowerSupply[] GetAll() {
            string[] result = PrimaryQueries.Query("SELECT * FROM `powersupply`");
            PowerSupply[] arr = new PowerSupply[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
    }
}
