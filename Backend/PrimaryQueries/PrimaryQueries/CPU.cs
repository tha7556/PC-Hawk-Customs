﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryQueries {
    /// <summary>
    /// The Central Processing Unit comprised of (outside of Part):
    /// Speed, Cores, and TDP
    /// </summary>
    public class CPU : Part {
        /// <summary>
        /// The speed of the CPU
        /// </summary>
        public double speed { get; set; }
        /// <summary>
        /// The number of cores the CPU has
        /// </summary>
        public int cores { get; set; }
        /// <summary>
        /// The TDP of the CPU
        /// </summary>
        public int tdp { get; set; }

        /// <summary>
        /// CPU Object constructor
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="speed"></param>
        /// <param name="cores"></param>
        /// <param name="tdp"></param>
        public CPU(int partNumber, string name, double price, double speed, int cores, int tdp) : base(partNumber, name, price) {
            this.speed = speed;
            this.cores = cores;
            this.tdp = tdp;
        }

        /// <summary>
        /// Inserts the CPU object into the relevant table
        /// </summary>
        public new void AddToDatabase() {
            base.AddToDatabase();
            Queries.Query("INSERT INTO `cpu` (`part number`, `name`, `price`, `speed`, `cores`, `tdp`)" +
                " VALUES (" + partNumber + ", '" + name + "', " + price + ", " + speed + ", " + cores + ", " + tdp + ")");
        }

        /// <summary>
        /// Returns a cpu object parsed from the string parameter
        /// </summary>
        /// <param name="query">The MySQL query result</param>
        /// <returns>The CPU from the query result</returns>
        public static CPU GetFromQuery(string query) {
            string[] result = query.Split('\0');
            return new CPU(int.Parse(result[0]), result[1], double.Parse(result[2]), double.Parse(result[3]), int.Parse(result[4]), int.Parse(result[5]));
        }

        /// <summary>
        /// Returns all CPU elements in an array Queried from the database table
        /// </summary>
        /// <returns></returns>
        public static CPU[] GetAll() {
            string[] result = Queries.Query("SELECT * FROM `cpu`");
            CPU[] arr = new CPU[result.Length];
            for (int i = 0; i < result.Length; i++) {
                arr[i] = GetFromQuery(result[i]);
            }
            return arr;
        }

        /// <summary>
        /// Returns the relevant part from the database table queried on partNumber
        /// </summary>
        /// <param name="partNumber">The part number</param>
        /// <returns>The CPU from the part number</returns>
        public static CPU Get(int partNumber) {
            string[] result = Queries.Query("SELECT * FROM `cpu` WHERE `part number` = " + partNumber);
            if (result.Length > 0) {
                return GetFromQuery(result[0]);
            }
            Queries.Log(Queries.LogLevel.ERROR, "CPU with part number: " + partNumber + " could not be found");
            return null;
        }
        /// <summary>
        /// Gets the attributes of the CPU
        /// </summary>
        /// <returns>A string containing the attributes</returns>
        public new string GetAttributes() {
            return "Name: "+name+
                "\nSpeed: "+speed+
                "\nCores: "+cores+
                "\nTDP: " + tdp;
        }
    }
}
