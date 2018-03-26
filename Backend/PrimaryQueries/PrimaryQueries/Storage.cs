
namespace PrimaryQueries {
    class Storage : Part {
        private string series, form, type, capacity, cache;
        public Storage(int partNumber, string name, double price, string series, string form, string type, string capacity, string cache) : base(partNumber,name,price) {
            this.series = series;
            this.form = form;
            this.type = type;
            this.capacity = capacity;
            this.cache = cache;
        }
        public string GetSeries() {
            return series;
        }
        public string GetForm() {
            return form;
        }
        public string GetStorageType() {
            return type;
        }
        public string GetCapacity() {
            return capacity;
        }
        public string GetCache() {
            return cache;
        }
        public new void AddToDatabase() {
            base.AddToDatabase();
            PrimaryQueries.Query("INSERT INTO `storage` (`part number`, `name`, `price`, `series`, `form`, `type`, `capacity`, `cache`) " +
                "VALUES ("+partNumber+", '"+name+"', "+price+", '"+series+"', '"+form+"', '"+type+"', '"+capacity+"', '"+cache+"');");
        }
        public static Storage GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new Storage(int.Parse(result[0]), result[1], double.Parse(result[2]), result[3], result[4], result[5], result[6], result[7]);
        }
        public static Storage[] GetAll() {
            string[] result = PrimaryQueries.Query("SELECT * FROM `storage`");
            Storage[] arr = new Storage[result.Length];
            for(int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
    }
}
