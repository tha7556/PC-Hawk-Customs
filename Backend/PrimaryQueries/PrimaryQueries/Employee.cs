//TODO: What can employees do while online? Admin priveleges?
namespace PrimaryQueries {
    /// <summary>
    /// An Employee at PCHawkCustoms. Extends the Person class
    /// </summary>
    public class Employee : Person {
        /// <summary>
        /// Creates an Employee
        /// </summary>
        /// <param name="firstName">The Employee's first name</param>
        /// <param name="lastName">The Employee's last name</param>
        /// <param name="email">The Employee's email address</param>
        /// <param name="password">The Employee's password</param>
        public Employee(string firstName, string lastName, string email, string password) : base(firstName, lastName, email,password) {
            table = "employee";
            Queries.Log(Queries.LogLevel.DEBUG, "Employee(" + firstName + "," + lastName + "," + email + "," + EncryptPassword(password)+");");
        }
        /// <summary>
        /// Adds the Employee to the Database
        /// </summary>
        override
        public void AddToDatabase() {
            Queries.Query("INSERT INTO `employee` (`email`, `first name`, " +
                "`last name`, `password`) VALUES ('"+email+"', '"+firstName+"', '"+lastName+"', '"+password+"');");
        }
        /// <summary>
        /// Deletes the Employee from the Database
        /// </summary>
        override
        public void DeleteFromDatabase() {
            Queries.Query("DELETE FROM `employee` WHERE `employee`.`email` = '"+email+"'");
        }
        /// <summary>
        /// Deletes a specific Employee from the Database
        /// </summary>
        /// <param name="email">The email of the Employee to delete</param>
        public static void DeleteFromDatabase(string email) {
            Queries.Query("DELETE FROM `employee` WHERE `employee`.`email` = '" + email + "'");
        }
        /// <summary>
        /// Converts a MySQL query result into an Employee object
        /// </summary>
        /// <param name="result">The MySQL query result</param>
        /// <returns>An Employee from the query</returns>
        public static Employee GetFromQuery(string result) {
            string[] line = result.Split('\0');
            return new Employee(line[1], line[2], line[0],line[3]);
        }
        /// <summary>
        /// Gets an Employee based on their email from the database
        /// </summary>
        /// <param name="email">The Employee's email</param>
        /// <returns>The Employee with the given email</returns>
        public static Employee Get(string email) {
            string[] result = Queries.Query("SELECT * FROM `employee` WHERE `email` = '" + email+"'");
            if(result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
        /// <summary>
        /// Gets all Employees in the Database
        /// </summary>
        /// <returns>A Employee[] containing all employees from the database</returns>
        public static Employee[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `employee`;");
            Employee[] arr = new Employee[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
    }
}
