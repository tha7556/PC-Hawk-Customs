
namespace PrimaryQueries {
    /// <summary>
    /// An abstract Person to represent either an Employee or a Customer
    /// </summary>
    public abstract class Person {
        /// <summary>
        /// The first name of the Person
        /// </summary>
        public string firstName { get; set; }
        /// <summary>
        /// The last name of the Person
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// The Person's email address
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// The Person's login password
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// The table in the database to find this Person
        /// </summary>
        public string table { get; set; }
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
        /// Changes the Person's email address
        /// </summary>
        /// <param name="newEmail">The new email address</param>
        public void ChangeEmail(string newEmail) {
            Queries.Query("UPDATE `" + table + "` SET `email` = '" + newEmail + "' WHERE `" + table + "`.`email` = '" + email + "';");
            email = newEmail;
        }
        /// <summary>
        /// Changes the Person's first and last names
        /// </summary>
        /// <param name="firstName">The new first name</param>
        /// <param name="lastName">The new last name</param>
        public void ChangeName(string firstName, string lastName) {
            Queries.Query(string.Format("UPDATE `{0}` SET `first name` = '{1}' WHERE `{0}`.`email` = '{2}';", table, firstName, email));
            Queries.Query(string.Format("UPDATE `{0}` SET `last name` = '{1}' WHERE `{0}`.`email` = '{2}';", table, lastName, email));
            this.firstName = firstName;
            this.lastName = lastName;
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
            password = EncryptPassword(newPassword);
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
        public static string EncryptPassword(string password) {
            string[] result = Queries.Query("SELECT encryptPassword(\""+password+"\");");
            return result[0].Substring(0,result[0].Length-1); //The query adds a question mark at the end for some reason
        }
        /// <summary>
        /// Checks to see if the password matches the one stored in the database
        /// </summary>
        /// <param name="pass">The plaintext password (is encrypted during this method)</param>
        /// <returns></returns>
        public bool CheckPassword(string pass) {
            string encrypted = EncryptPassword(pass);
            if(password.Equals(encrypted)) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Validates login information for both Customers and Employees. Returns true if login is valid for either
        /// </summary>
        /// <param name="email">The email to check</param>
        /// <param name="password">The password to check</param>
        /// <returns></returns>
        public bool CheckCredentials(string email, string password) {
            bool isPassword = CheckPassword(password);
            bool isEmployee = IsEmployee(email);
            bool isCustomer = IsCustomer(email);
            return isPassword && (isEmployee || isCustomer);
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
