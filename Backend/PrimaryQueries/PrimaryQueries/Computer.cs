
namespace PrimaryQueries {
    /// <summary>
    /// A Computer object
    /// </summary>
    public class Computer { 
        /// <summary>
        /// The PC case of the Computer
        /// </summary>
        public Case pcCase { get; set; }
        /// <summary>
        /// The CPU of the Computer
        /// </summary>
        public CPU cpu { get; set; }
        /// <summary>
        /// The Fan of the Computer
        /// </summary>
        public Fan fan { get; set; }
        /// <summary>
        /// The Graphics Card of the Computer
        /// </summary>
        public GraphicsCard gCard { get; set; }
        /// <summary>
        /// The Memory of the Computer
        /// </summary>
        public Memory memory { get; set; }
        /// <summary>
        /// The Motherboard of the Computer
        /// </summary>
        public MOBO mBoard { get; set; }
        /// <summary>
        /// The Power Supply of the Computer
        /// </summary>
        public PowerSupply power { get; set; }
        /// <summary>
        /// The Storage of the Computer
        /// </summary>
        public Storage storage { get; set; }
        /// <summary>
        /// The serial number of the Computer
        /// </summary>
        public int serialNumber { get; set; }
        /// <summary>
        /// The name of the Computer
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The price of the Computer
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// Computer constructor requiring all parts
        /// </summary>
        /// <param name="serialNumber">The serial number of the Computer</param>
        /// <param name="name">The name of the Computer</param>
        /// <param name="pcCase">The pc case of the Computer</param>
        /// <param name="cpu">The cpu of the Computer</param>
        /// <param name="fan">The fan of the Computer</param>
        /// <param name="gCard">The Graphics Card of the Computer</param>
        /// <param name="memory">The Memory of the Computer</param>
        /// <param name="mBoard">The Motherboard of the Computer</param>
        /// <param name="power">The power supply of the Computer</param>
        /// <param name="storage">The storage of the computer</param>
        public Computer(int serialNumber, string name, Case pcCase, CPU cpu, Fan fan, GraphicsCard gCard, Memory memory, MOBO mBoard, PowerSupply power, Storage storage) {
            this.pcCase = pcCase;
            this.cpu = cpu;
            this.fan = fan;
            this.gCard = gCard;
            this.memory = memory;
            this.mBoard = mBoard;
            this.power = power;
            this.storage = storage;
            this.serialNumber = serialNumber;
            this.name = name;
            price = CalcPrice();
        }
        /// <summary>
        /// Secondary Constructor for database incrementation
        /// </summary>
        /// <param name="name">The Name of the Computer</param>
        /// <param name="pcCase">The pc case of the Computer</param>
        /// <param name="cpu">The CPU of the Computer</param>
        /// <param name="fan">The Fan of the Computer</param>
        /// <param name="gCard">The Graphics Card of the Computer</param>
        /// <param name="memory">The Memory of the Computer</param>
        /// <param name="mBoard">The Motherboard of the Computer</param>
        /// <param name="power">The Power Supply of the Computer</param>
        /// <param name="storage">The Storage of the Computer</param>
        public Computer(string name, Case pcCase, CPU cpu, Fan fan, GraphicsCard gCard, Memory memory, MOBO mBoard, PowerSupply power, Storage storage) :this(-1, name, pcCase, cpu, fan, gCard, memory, mBoard, power, storage) {
        }
        /// <summary>
        /// Empty Constructor for freebuild sequential additions
        /// </summary>
        public Computer() {

        }
        /// <summary>
        /// Calculates the Price of the Computer
        /// </summary>
        /// <returns></returns>
        public double CalcPrice() {
            price = 0.0;
            Part[] parts = { pcCase, cpu, fan, gCard, memory, mBoard, power, storage };
            foreach (Part p in parts) {
                if (p != null)
                    price += p.price;
            }
            return price;
        }

        /// <summary>
        /// Inserts the selected Computer object into the relevant table
        /// </summary>
        public void AddToDatabase() {
            string num = serialNumber.ToString();
            if (serialNumber == -1)
                num = "NULL";
            string query = string.Format("INSERT INTO `computers` (`serialNumber`, `name`, `cpu`, `fan`, `graphicsCard`, `memory`, `motherboard`, `pcCase`, `powerSupply`, `storage`) " +
                "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8},{9});", 
                num, name, cpu.partNumber, fan.partNumber, gCard.partNumber, memory.partNumber, mBoard.partNumber, pcCase.partNumber,power.partNumber,storage.partNumber);
            Queries.Query(query);
        }
        /// <summary>
        /// Adds a Part to the Computer
        /// </summary>
        /// <param name="p">The Part to add</param>
        public void AddPart(Part p) {
            string type = p.GetType().Name;
            switch(type) {
                case "Case":
                    pcCase = (Case)p;
                    break;
                case "CPU":
                    cpu = (CPU)p;
                    break;
                case "Fan":
                    fan = (Fan)p;
                    break;
                case "GraphicsCard":
                    gCard = (GraphicsCard)p;
                    break;
                case "Memory":
                    memory = (Memory)p;
                    break;
                case "MOBO":
                    mBoard = (MOBO)p;
                    break;
                case "PowerSupply":
                    power = (PowerSupply)p;
                    break;
                case "Storage":
                    storage = (Storage)p;
                    break;
            }
            CalcPrice();
        }
        /// <summary>
        /// Gets the attributes of the Computer
        /// </summary>
        /// <returns>A string[] containing the attributes</returns>
        public string[] GetAttributes() {
            string[] result = new string[8];
            if (pcCase == null)
                result[0]= "Case: None Selected";
            else
                result[0] = "Case: " + pcCase.name + " $" + pcCase.price;
            if (cpu == null)
                result[1] = "CPU: None Selected";
            else
                result[1] = "CPU: " + cpu.name + " $" + cpu.price;
            if (fan == null)
                result[2] = "Fan: None Selected";
            else
                result[2] = "Fan: " + fan.name + " $" + fan.price;
            if (gCard == null)
                result[3] = "Graphics Card: None Selected";
            else
                result[3] = "Graphics Card: " + gCard.name + " $" + gCard.price;
            if (memory == null)
                result[4] = "Memory: None Selected";
            else
                result[4] = "Memory: " + memory.name + " $" + memory.price;
            if (mBoard == null)
                result[5] = "Motherboard: None Selected";
            else {
                result[5] = "Motherboard: " + mBoard.name + " $" + mBoard.price;
            }
            if (power == null)
                result[6] = "Power Supply: None Selected";
            else
                result[6] = "Power Supply: " + power.name + " $" + power.price;
            if (storage == null)
                result[7] = "Storage: None Selected";
            else
                result[7] = "Storage: " + storage.name + " $" + storage.price;

            return result;
        }
        /// <summary>
        /// Gets a Computer based on a serial number
        /// </summary>
        /// <param name="serialNumber">The serial number to look up</param>
        /// <returns>The Computer from the serial number</returns>
        public static Computer Get(int serialNumber) {
            return GetFromQuery(Queries.Query("SELECT * FROM `computers` WHERE `serialNumber` = " + serialNumber)[0]);
        }
        /// <summary>
        /// Gets all computers in the database
        /// </summary>
        /// <returns>A Computer[] of all Computers in the database</returns>
        public static Computer[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `computers");
            Computer[] comps = new Computer[result.Length];
            for(int i = 0; i < result.Length; i++) {
                comps[i] = GetFromQuery(result[i]);
            }
            return comps;
        }
        /// <summary>
        /// Converts a MySQL query result into a Computer
        /// </summary>
        /// <param name="result">The MySQL query result</param>
        /// <returns>The Computer found from the query</returns>
        public static Computer GetFromQuery(string result) {
            string[] arr = result.Split('\0');
            CPU cpu = CPU.Get(int.Parse(arr[2]));
            Fan fan = Fan.Get(int.Parse(arr[3]));
            GraphicsCard gCard = GraphicsCard.Get(int.Parse(arr[4]));
            Memory memory = Memory.Get(int.Parse(arr[5]));
            MOBO mBoard = MOBO.Get(int.Parse(arr[6]));
            Case c = Case.Get(int.Parse(arr[7]));
            PowerSupply power = PowerSupply.Get(int.Parse(arr[8]));
            Storage storage = Storage.Get(int.Parse(arr[9]));

            return new Computer(int.Parse(arr[0]), arr[1],c, cpu, fan, gCard, memory, mBoard, power, storage);
        }

    }
}
