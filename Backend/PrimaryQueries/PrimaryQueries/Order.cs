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
        private Computer computer { get; set; }
        private Employee employee { get; set; }
        private Customer customer { get; set; }
        /// <summary>
        /// Creates a new Order for a Part
        /// </summary>
        /// <param name="orderNumber">The number identifying the Order</param>
        /// <param name="computer">The Computer being ordered</param>
        /// <param name="employee">The Employee involved in the Order</param>
        /// <param name="customer">The Customer making the Order</param>
        public Order(int orderNumber, Computer computer, Employee employee, Customer customer) {
            this.orderNumber = orderNumber;
            this.computer = computer;
            this.employee = employee;
            this.customer = customer;
        }
        /// <summary>
        /// Creates a new Order with -1 as Order Number. When added to the database, it automatically sets it to the next number
        /// </summary>
        /// <param name="employee">The Employee involved in the Order</param>
        /// <param name="customer">The Customer making the Order</param>
        /// <param name="computer">The Computer being ordered</param>
        public Order(Computer computer, Employee employee, Customer customer) : this(-1,computer,employee,customer){
            
        }
        
        /// <summary>
        /// Adds this Order to the Database
        /// </summary>
        public void AddToDatabase() {
            string num = orderNumber.ToString();
            if (orderNumber == -1)
                num = "NULL";
            Queries.Query("INSERT INTO `order` (`order number`, `employee email`, `computer number`, `customer email`) VALUES " +
                "("+num+", '"+employee.email+"', "+computer.serialNumber+", '"+customer.email+"');");
        }
        /// <summary>
        /// Converts a MySql query result into an Order
        /// </summary>
        /// <param name="result">The MySql query result</param>
        /// <returns>An Order made from the query</returns>
        public static Order GetOrderFromQuery(string result) {
            string[] line = result.Split('\0');
            return new Order (int.Parse(line[0]),Computer.Get(int.Parse(line[2])),Employee.Get(line[1]),Customer.Get(line[3]));
        }
    }
}
