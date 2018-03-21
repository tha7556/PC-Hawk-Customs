
namespace PrimaryQueries {
    /// <summary>
    /// An abstract Person to represent either an Employee or a Customer
    /// </summary>
    abstract class Person {
        protected string firstName, lastName, email;
        /// <summary>
        /// Creates a new Person
        /// </summary>
        /// <param name="firstName">The Person's first name</param>
        /// <param name="lastName">The Person's last name</param>
        /// <param name="email">The Person's email address</param>
        public Person(string firstName, string lastName, string email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
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
            this.email = newEmail;
        }
        /// <summary>
        /// Adds the Person to the Database
        /// </summary>
        public abstract void AddToDatabase();
        public abstract void DeleteFromDatabase();
    }
}
