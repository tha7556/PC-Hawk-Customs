//TODO: Password encryption
//TODO: Have Change email modify database
//TODO: Verification for passwords
//TODO: Ensure that People can't be made with emails already in database
namespace PrimaryQueries {
    /// <summary>
    /// An abstract Person to represent either an Employee or a Customer
    /// </summary>
    public abstract class Person {
        /// <summary>
        /// The Name of the Person
        /// </summary>
        protected string firstName, lastName;
        /// <summary>
        /// The Person's email address
        /// </summary>
        protected string email;
        /// <summary>
        /// The Person's login password
        /// </summary>
        protected string password;
        /// <summary>
        /// The table in the database to find this Person
        /// </summary>
        protected string table;
        /// <summary>
        /// Creates a new Person
        /// </summary>
        /// <param name="firstName">The Person's first name</param>
        /// <param name="lastName">The Person's last name</param>
        /// <param name="email">The Person's email address</param>
        /// <param name="password">The Person's password</param>
        public Person(string firstName, string lastName, string email, string password) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }
        /// <summary>
        /// Gets the Person's first name
        /// </summary>
        /// <returns>The Person's first name</returns>
        public string GetFirstName() {
            return firstName;
        }
        /// <summary>
        /// Gets the Person's last name
        /// </summary>
        /// <returns>The Person's last name</returns>
        public string GetLastName() {
            return lastName;
        }
        /// <summary>
        /// Gets the Person's email address
        /// </summary>
        /// <returns>The Person's email address</returns>
        public string GetEmail() {
            return email;
        }
        /// <summary>
        /// Changes the Person's email address
        /// </summary>
        /// <param name="newEmail">The new email address</param>
        public void ChangeEmail(string newEmail) {
            email = newEmail;
        }
        /// <summary>
        /// Gets the Person's Password
        /// </summary>
        /// <returns>The Person's Password</returns>
        public string GetPassword() {
            return password;
        }
        /// <summary>
        /// Changes the Person's Password
        /// </summary>
        /// <param name="newPassword">The new Password to change to</param>
        public void ChangePassword(string newPassword) {
            password = newPassword;
            Queries.Query("UPDATE `" + table + "` SET `password` = '" + password + "' WHERE `" + table + "`.`email` = " + email + ";");
        }
        /// <summary>
        /// Gets all orders from the Person it is called from. Can only be called for either Employee or Customer 
        /// </summary>
        /// <returns></returns>
        public Order[] GetOrders() {
            string[] result = { };
            if (this is Employee) {
                result = Queries.Query("CALL getOrdersFromEmployee(" + email + ")");
            }
            else if(this is Customer) {
                result = Queries.Query("CALL getOrdersFromCustomer(" + email + ")");
            }
            else {
                System.Console.WriteLine("Can only call GetOrders() on a Customer or Employee object");
            }
            Order[] orders = new Order[result.Length];
            for (int i = 0; i < result.Length; i++) {
                orders[i] = Order.GetOrderFromQuery(result[i]);
            }
            return orders;
        }
        /// <summary>
        /// Checks to see if the Person with the given email is a Customer
        /// </summary>
        /// <param name="email">The Email to check</param>
        /// <returns>True if the email matches a Customer</returns>
        public static bool IsCustomer(string email) {
            return !(Customer.Get(email) == null);
        }
        /// <summary>
        /// Checks to see if the Person with the given email is an Employee
        /// </summary>
        /// <param name="email">The Email to check</param>
        /// <returns>True if the email matches an Employee</returns>
        public static bool IsEmployee(string email) {
            return !(Employee.Get(email) == null);
        }
        /// <summary>
        /// Encrypts the Person's password
        /// </summary>
        /// <param name="password">The password to encrypt</param>
        public static void EncryptPassword(string password) {
            Queries.Query("SELECT encryptPassword("+password+")");
        }
        /// <summary>
        /// Adds the Person to the Database
        /// </summary>
        public abstract void AddToDatabase();
        /// <summary>
        /// Removes the Person from the Database
        /// </summary>
        public abstract void DeleteFromDatabase();
        /// <summary>
        /// Returns a string representation in the form: 
        /// {Employee/Customer}: {first name} {last name}, {email}
        /// </summary>
        /// <returns>{Employee/Customer}: {first name} {last name}, {email}</returns>
        public override string ToString() {
            return GetType() + ": " + firstName + " " + lastName + ", " + email;
        }
    }
}
