
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
    }
}
