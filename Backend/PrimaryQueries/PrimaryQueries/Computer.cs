
namespace PrimaryQueries {
    public class Computer { 
        public Case pcCase { get; set; }
        public CPU cpu { get; set; }
        public Fan fan { get; set; }
        public GraphicsCard gCard { get; set; }
        public Memory memory { get; set; }
        public MOBO mBoard { get; set; }
        public PowerSupply power { get; set; }
        public Storage storage { get; set; }
        public int serialNumber { get; set; }
        public string name { get; set; }

        /// <summary>
        /// Computer constructor requiring all parts
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="name"></param>
        /// <param name="pcCase"></param>
        /// <param name="cpu"></param>
        /// <param name="fan"></param>
        /// <param name="gCard"></param>
        /// <param name="memory"></param>
        /// <param name="mBoard"></param>
        /// <param name="power"></param>
        /// <param name="storage"></param>
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
        }
        /// <summary>
        /// Secondary Constructor for database incrementation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pcCase"></param>
        /// <param name="cpu"></param>
        /// <param name="fan"></param>
        /// <param name="gCard"></param>
        /// <param name="memory"></param>
        /// <param name="mBoard"></param>
        /// <param name="power"></param>
        /// <param name="storage"></param>
        public Computer(string name, Case pcCase, CPU cpu, Fan fan, GraphicsCard gCard, Memory memory, MOBO mBoard, PowerSupply power, Storage storage) :this(-1, name, pcCase, cpu, fan, gCard, memory, mBoard, power, storage) {
        }
        /// <summary>
        /// Empty Constructor for prebuild sequential additions
        /// </summary>
        public Computer() {

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
        public static Computer Get(int serialNumber) {
            return GetFromQuery(Queries.Query("SELECT * FROM `computers` WHERE `serialNumber` = " + serialNumber)[0]);
        }
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
