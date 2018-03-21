
namespace PrimaryQueries {
    /// <summary>
    /// An Employee at PCHawkCustoms. Extends the Person class
    /// </summary>
    class Employee : Person {  
        /// <summary>
        /// Creates an Employee
        /// </summary>
        /// <param name="firstName">The Employee's first name</param>
        /// <param name="lastName">The Employee's last name</param>
        /// <param name="email">The Employee's email address</param>
        public Employee(string firstName, string lastName, string email) : base(firstName, lastName, email) {
        }
        override
        public void AddToDatabase() {
            PrimaryQueries.Query("INSERT INTO `employee` (`email`, `first name`, " +
                "`last name`) VALUES ('"+email+"', '"+firstName+"', '"+lastName+"');");
        }
    }
}
