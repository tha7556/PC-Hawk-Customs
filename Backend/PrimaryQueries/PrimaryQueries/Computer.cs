
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
        public double price { get; set; }

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
            price = CalcPrice();
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
