﻿
namespace PrimaryQueries {
    class Computer { 
        private Case pcCase;
        private CPU cpu;
        private Fan fan;
        private GraphicsCard gCard;
        private Memory memory;
        private MOBO mBoard;
        private PowerSupply power;
        private Storage storage;
        private int serialNumber;

        public Computer(int serialNumber, Case pcCase, CPU cpu, Fan fan, GraphicsCard gCard, Memory memory, MOBO mBoard, PowerSupply power, Storage storage) {
            this.pcCase = pcCase;
            this.cpu = cpu;
            this.fan = fan;
            this.gCard = gCard;
            this.memory = memory;
            this.mBoard = mBoard;
            this.power = power;
            this.storage = storage;
            this.serialNumber = serialNumber;
        }
        public Computer(Case pcCase, CPU cpu, Fan fan, GraphicsCard gCard, Memory memory, MOBO mBoard, PowerSupply power, Storage storage) :this(-1, pcCase, cpu, fan, gCard, memory, mBoard, power, storage) {
        }
        public Computer() {

        }
        public Part[] GetParts() {
            return new Part[] { pcCase, cpu, fan, gCard, memory, mBoard, power, storage };
        }
        public bool CheckParts() {
            Part[] parts = GetParts();
            foreach(Part p in parts) {
                if (p == null)
                    return false;
            }
            return true;
        }
        public Case GetCase() {
            return pcCase;
        }
        public void SetCase(Case newCase) {
            pcCase = newCase;
        }
        public CPU GetCPU() {
            return cpu;
        }
        public void SetCPU(CPU newCPU) {
            cpu = newCPU;
        }
        public Fan GetFan() {
            return fan;
        }
        public void SetFan(Fan newFan) {
            fan = newFan;
        }
        public GraphicsCard GetGraphicsCard() {
            return gCard;
        }
        public void SetGraphicsCard(GraphicsCard newGraphicsCard) {
            gCard = newGraphicsCard;
        }
        public Memory GetMemory() {
            return memory;
        }
        public void SetMemory(Memory newMemory) {
            memory = newMemory;
        }
        public MOBO GetMotherboard() {
            return mBoard;
        }
        public void SetMotherboard(MOBO newMBoard) {
            mBoard = newMBoard;
        }
        public PowerSupply GetPowerSupply() {
            return power;
        }
        public void SetPowerSupply(PowerSupply newPowerSupply) {
            power = newPowerSupply;
        }
        public Storage GetStorage() {
            return storage;
        }
        public void SetStorage(Storage newStorage) {
            storage = newStorage;
        }
        public void AddToDatabase() {
            string num = serialNumber.ToString();
            if (serialNumber == -1)
                num = "NULL";
            string query = string.Format("INSERT INTO `computers` (`serialNumber`, `cpu`, `fan`, `graphicsCard`, `memory`, `motherboard`, `pcCase`, `powerSupply`, `storage`) " +
                "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8});", 
                num, cpu.GetPartNumber(), fan.GetPartNumber(), gCard.GetPartNumber(), memory.GetPartNumber(), mBoard.GetPartNumber(), pcCase.GetPartNumber(),power.GetPartNumber(),storage.GetPartNumber());
            Queries.Query(query);
        }

    }
}