//TODO: Confirmation email upon order completion
//TODO: Multiple Parts in an Order?
//TODO: Execute Order
//TODO: Check (not store) Payment method
namespace PrimaryQueries {
    /// <summary>
    /// An Order for a Part
    /// </summary>
    public class Order {
        private int orderNumber { get; set; }
        private Part part { get; set; }
        private Employee employee { get; set; }
        private Customer customer { get; set; }
        /// <summary>
        /// Creates a new Order for a Part
        /// </summary>
        /// <param name="orderNumber">The number identifying the Order</param>
        /// <param name="part">The Part being ordered</param>
        /// <param name="employee">The Employee involved in the Order</param>
        /// <param name="customer">The Customer making the Order</param>
        public Order(int orderNumber, Part part, Employee employee, Customer customer) {
            this.orderNumber = orderNumber;
            this.part = part;
            this.employee = employee;
            this.customer = customer;
        }
        /// <summary>
        /// Creates a new Order with -1 as Order Number. When added to the database, it automatically sets it to the next number
        /// </summary>
        /// <param name="part">The Part being ordered</param>
        /// <param name="employee">The Employee involved in the Order</param>
        /// <param name="customer">The Customer making the Order</param>
        public Order(Part part, Employee employee, Customer customer) : this(-1,part,employee,customer){
            
        }
        
        /// <summary>
        /// Adds this Order to the Database
        /// </summary>
        public void AddToDatabase() {
            string num = orderNumber.ToString();
            if (orderNumber == -1)
                num = "NULL";
            Queries.Query("INSERT INTO `order` (`order number`, `employee email`, `part number`, `customer email`) VALUES " +
                "("+num+", '"+employee.email+"', "+part.partNumber+", '"+customer.email+"');");
        }
        /// <summary>
        /// Converts a MySql query result into an Order
        /// </summary>
        /// <param name="result">The MySql query result</param>
        /// <returns>An Order made from the query</returns>
        public static Order GetOrderFromQuery(string result) {
            string[] line = result.Split('\0');
            return new Order (int.Parse(line[0]),Part.GetPart(int.Parse(line[1])),Employee.Get(line[2]),Customer.Get(line[3]));
        }
    }
}
