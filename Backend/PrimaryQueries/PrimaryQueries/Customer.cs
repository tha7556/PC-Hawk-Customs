
namespace PrimaryQueries {
    /// <summary>
    /// A customer of PCHawkCustoms
    /// </summary>
    class Customer : Person {
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
        public Customer(string firstName, string lastName, string email, string streetAddress, string city, string state, int zipcode) : base(firstName,lastName,email) {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
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
            PrimaryQueries.Query("INSERT INTO `customer` (`email`, `first name`, `last name`, `street addess`, `city`, `state`, `zipcode`) " +
                "VALUES ('"+email+"', '"+firstName+"', '"+lastName+"', '"+streetAddress+"', '"+city+"', '"+state+"', "+zipcode+");");
        }
        /// <summary>
        /// Deletes a Customer from the Database
        /// </summary>
        override
        public void DeleteFromDatabase() {
            PrimaryQueries.Query("DELETE FROM `customer` WHERE `customer`.`email` = '" + email + "'");
        }
        /// <summary>
        /// Deletes a specific Customer from the Database
        /// </summary>
        /// <param name="email">The email of the Customer to delete</param>
        public static void DeleteFromDatabase(string email) {
            PrimaryQueries.Query("DELETE FROM `customer` WHERE `customer`.`email` = '" + email + "'");
        }
    }
}
