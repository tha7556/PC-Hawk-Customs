//TODO: A cart for customers
//TODO: Check that zipcode is in the state?
//TODO: Check that the state exists
//TODO: Check that the City exists?
using System.Net;

namespace PrimaryQueries {
    /// <summary>
    /// A customer of PCHawkCustoms
    /// </summary>
    public class Customer : Person {
        private string streetAddress, city, state;
        private int zipcode;
        /// <summary>
        /// Creates a new Customer
        /// </summary>
        /// <param name="firstName">The Customer's first name</param>
        /// <param name="lastName">The Customer's last name</param>
        /// <param name="email">The Customer's email address</param>
        /// <param name="streetAddress">The Customer's street address</param>
        /// <param name="city">The Customer's city</param>
        /// <param name="state">The Customer's state</param>
        /// <param name="zipcode">The Customer's zipcode</param>
        /// <param name="password">The Customer's password</param>
        public Customer(string firstName, string lastName, string email, string streetAddress, string city, string state, int zipcode, string password) : base(firstName,lastName,email,password) {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            Queries.Log(Queries.LogLevel.DEBUG, "Customer(" + firstName + "," + lastName + "," + email + "," + streetAddress + "," + city + "," + state + "," + zipcode + "," + password + ");");
        }
        /// <summary>
        /// Gets the Street Address of the Customer
        /// </summary>
        /// <returns>The Street Address of the Customer</returns>
        public string GetStreetAddress() {
            return streetAddress;
        }
        /// <summary>
        /// Gets the City of the Customer
        /// </summary>
        /// <returns>The City of the Customer</returns>
        public string GetCity() {
            return city;
        }
        /// <summary>
        /// Gets the State of the Customer
        /// </summary>
        /// <returns>The State the Customer lives in</returns>
        public string GetState() {
            return state;
        }
        /// <summary>
        /// Gets the Zipcode of the Customer
        /// </summary>
        /// <returns>The Zipcode of the Customer</returns>
        public int GetZipcode() {
            return zipcode;
        }
        /// <summary>
        /// Changes the Customer's Address
        /// </summary>
        /// <param name="newStreetAddress">The new Street Address of the Customer</param>
        /// <param name="newCity">The new City of the Customer</param>
        /// <param name="newState">The new State of the Customer</param>
        /// <param name="newZipcode">The new Zipcode of the Customer</param>
        public void ChangeAddress(string newStreetAddress, string newCity, string newState, int newZipcode) {
            streetAddress = newStreetAddress;
            city = newCity;
            state = newState;
            zipcode = newZipcode;
        }
        /// <summary>
        /// Adds the Customer to the Database
        /// </summary>
        override
        public void AddToDatabase() {
            Queries.Query("INSERT INTO `customer` (`email`, `first name`, `last name`, `street addess`, `city`, `state`, `zipcode`, `password`) " +
                "VALUES ('"+email+"', '"+firstName+"', '"+lastName+"', '"+streetAddress+"', '"+city+"', '"+state+"', "+zipcode+",'"+password+"');");
        }
        /// <summary>
        /// Deletes a Customer from the Database
        /// </summary>
        override
        public void DeleteFromDatabase() {
            Queries.Query("DELETE FROM `customer` WHERE `customer`.`email` = '" + email + "'");
        }
        /// <summary>
        /// Deletes a specific Customer from the Database
        /// </summary>
        /// <param name="email">The email of the Customer to delete</param>
        public static void DeleteFromDatabase(string email) {
            Queries.Query("DELETE FROM `customer` WHERE `customer`.`email` = '" + email + "'");
        }
        /// <summary>
        /// Converts a MySQL query result into a Customer object
        /// </summary>
        /// <param name="result">The MySQL query result</param>
        /// <returns>A Customer from the query</returns>
        public static Customer GetFromQuery(string result) {
            string[] line = result.Split('\0');
            return new Customer(line[1], line[2], line[0], line[3], line[4],line[5].ToUpper(),int.Parse(line[6]),line[7]);
        }
        /// <summary>
        /// Gets a Customer based on their email from the database
        /// </summary>
        /// <param name="email">The Customer's email</param>
        /// <returns>The Customer with the given email</returns>
        public static Customer Get(string email) {
            string[] result = Queries.Query("SELECT * FROM `customer` WHERE `email`=" + email);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            return null;
        }
        /// <summary>
        /// Gets all Customers in the Database
        /// </summary>
        /// <returns>A Customer[] containing all customers from the database</returns>
        public static Customer[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `customer`;");
            Customer[] arr = new Customer[result.Length];
            for(int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }
        /// <summary>
        /// Checks to see if a zipcode is valid by checking if it is 5 digits, and then checking online (can be slow)
        /// </summary>
        /// <param name="zipcode">The zipcode to check</param>
        /// <returns>True if it is a valid zipcode</returns>
        public static bool IsZipcode(int zipcode) {
            if (zipcode.ToString().Length == 5) {
                WebClient client = new WebClient();
                //string content = client.DownloadString("https://www.melissadata.com/lookups/ZipCityPhone.asp?InData=" + zipcode);
                string content = client.DownloadString("http://www.zip-info.com/cgi-local/zipsrch.exe?zip="+zipcode+"&Go=Go");
                if (content != null && !content.Contains("not currently assigned"))
                    return true;
            }
            return false;
        }
    }
}
