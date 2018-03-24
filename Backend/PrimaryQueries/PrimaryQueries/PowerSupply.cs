
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
        public void AddToDatabase() {
            PrimaryQueries.Query("INSERT INTO `powersupply` (`part number`, `name`, `price`, `series`, `form`, `efficiency`, `watts`, `modular`) " +
                "VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+form+"', '"+efficiency+"', '"+watts+"', '"+modular+"');");
        }
    }
}
