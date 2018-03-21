﻿
namespace PrimaryQueries {
    /// <summary>
    /// An abstract Person to represent either an Employee or a Customer
    /// </summary>
    abstract class Person {
        protected string firstName, lastName, email, password;
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
            this.email = newEmail;
        }
        /// <summary>
        /// Gets the Person's Password
        /// </summary>
        /// <returns>The Person's Password</returns>
        public string getPassword() {
            return password;
        }
        /// <summary>
        /// Changes the Person's Password
        /// </summary>
        /// <param name="newPassword">The new Password to change to</param>
        public void changePassword(string newPassword) {
            password = newPassword;
        }
        /// <summary>
        /// Adds the Person to the Database
        /// </summary>
        public abstract void AddToDatabase();
        /// <summary>
        /// Removes the Person from the Database
        /// </summary>
        public abstract void DeleteFromDatabase();
    }
}
