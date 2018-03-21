
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
        /// <summary>
        /// Adds the Employee to the Database
        /// </summary>
        override
        public void AddToDatabase() {
            PrimaryQueries.Query("INSERT INTO `employee` (`email`, `first name`, " +
                "`last name`) VALUES ('"+email+"', '"+firstName+"', '"+lastName+"');");
        }
        /// <summary>
        /// Deletes the Employee from the Database
        /// </summary>
        override
        public void DeleteFromDatabase() {
            PrimaryQueries.Query("DELETE FROM `employee` WHERE `employee`.`email` = '"+email+"'");
        }
        /// <summary>
        /// Deletes a specific Employee from the Database
        /// </summary>
        /// <param name="email">The email of the Employee to delete</param>
        public static void DeleteFromDatabase(string email) {
            PrimaryQueries.Query("DELETE FROM `employee` WHERE `employee`.`email` = '" + email + "'");
        }
    }
}
