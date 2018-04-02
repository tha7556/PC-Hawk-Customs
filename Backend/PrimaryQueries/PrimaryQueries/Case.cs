
namespace PrimaryQueries {
    /// <summary>
    /// A Case for a Computer
    /// </summary>
    class Case : Part {
        private string type, powerSupply;
        private int externalSize, internalSize;
        /// <summary>
        /// Creates a new Case
        /// </summary>
        /// <param name="partNumber">The identifying number for the part</param>
        /// <param name="name">The name of the case</param>
        /// <param name="price">The price of the part</param>
        /// <param name="type">The type of case</param>
        /// <param name="externalSize">TODO</param>
        /// <param name="internalSize">TODO</param>
        /// <param name="powerSupply">Watts of the built in powerSupply if there is one</param>
        public Case(int partNumber, string name, double price, string type, int externalSize, int internalSize, string powerSupply) : base(partNumber, name, price) {
            this.type = type;
            this.powerSupply = powerSupply;
            this.externalSize = externalSize;
            this.internalSize = internalSize;
        }
        /// <summary>
        /// Gets the type of Case
        /// </summary>
        /// <returns>The type of Case</returns>
        public string GetCaseType() {
            return type;
        }
        /// <summary>
        /// Gets the Watts of the built in powerSupply if there is one
        /// </summary>
        /// <returns>The Watts of the built in powerSupply if there is one</returns>
        public string GetPowerSupply() {
            return powerSupply;
        }
        //TODO: what is this?
        public int GetExternalSize() {
            return externalSize;
        }
        //TODO: what is this?
        public int GetInternalSize() {
            return internalSize;
        }
    }
}
