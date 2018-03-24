
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
        public void AddToDatabase() {
            PrimaryQueries.Query("INSERT INTO `storage` (`part number`, `name`, `price`, `capacity`, `cache`, `series`) VALUES " +
                "("+partNumber+", '"+name+"', "+price+", '"+capacity+"', '"+cache+"', '"+series+"')");
        }
    }
}
