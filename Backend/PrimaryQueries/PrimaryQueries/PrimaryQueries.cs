﻿using System;
using System.IO;
using System.Net;
using System.Text;
//TODO: Connect to frontend
//TODO: Populate all databases
//TODO: Prebuilt computers
namespace PrimaryQueries {
    ///<summary>
    ///Class used to query the MySQL PCHawkCustoms Database.
    ///</summary>
    class PrimaryQueries {
        public static string url = "http://satoshi.cis.uncw.edu/~tha7556/Backend.php";
        public static int partNumber = 1000;
        public enum CurrentType {
            storage, graphicsCard, pcCase, powerSupply, cpu, fan, motherboard, memory
        }
        public enum LogLevel {
            DEBUG, WARNING, ERROR, SQLQUERY
        }
        private static string logFile = "..//..//Log data//log1.log";
        private static StreamWriter writer;
        private static DateTime startTime = DateTime.Now;
        /// <summary>
        /// Sends a Query to the Database. Returns a string[] of the result, with \0 seperating each column
        /// </summary>
        /// <param name="query">The MySQL query to perform</param>
        /// <param name="printQuery">True to write the query to console, false otherwise</param>
        /// <returns>A string[] containing each result of the query</returns>
        public static string[] Query(string query, Boolean printQuery) {
            if(query.ToUpper().Contains("DROP TABLE")) {
                Console.WriteLine("Please don't drop any tables from here...please");
                return new string[0];
            }
            Log(LogLevel.SQLQUERY, query);
            string postData = "query=" + query;
            if(printQuery)
                Console.WriteLine(query);
            string webpageContent = string.Empty;
            try {
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;

                using (Stream webpageStream = webRequest.GetRequestStream()) {
                    webpageStream.Write(byteArray, 0, byteArray.Length);
                    webpageStream.Flush();
                }
                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse()) {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream())) {
                        webpageContent = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception e) {
                Log(LogLevel.ERROR, e.StackTrace);
                Console.WriteLine(e.StackTrace);
            }
             
            string[] lines = webpageContent.Split('\n');
            string[] result = { };
            if (!webpageContent.Contains("Error") && !webpageContent.Contains("Warning")) {
                 result = new string[lines.Length - 4];
                Array.Copy(lines, 2, result, 0, lines.Length - 4);
            }
            else {
                if (webpageContent.Contains("Error")) {
                    Log(LogLevel.ERROR, webpageContent.Substring(webpageContent.IndexOf("Error") + 7));
                }
                else if (webpageContent.Contains("Warning"))
                    Log(LogLevel.WARNING, webpageContent.Substring(webpageContent.IndexOf("Warning") + 9));
            }
            return result;
        }
        /// <summary>
        /// Overloaded Query which defaults to printQuery=false. Returns a string[] of the result, with \0 seperating each column
        /// </summary>
        /// <param name="query">The MySQL query to perform</param>
        /// <returns>A string[] containing each result of the query</returns>
        public static string[] Query(string query) {
            return Query(query, false);
        }
        /// <summary>
        /// A function for grabbing part info off of pcpart picker
        /// </summary>
        /// <param name="current">The Current table to populate</param>
        public static void PopulateTable(CurrentType current) {
            string content = File.ReadAllText("..//..//part data//" + current + ".html");
            if (current == CurrentType.cpu) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf(";\"") + 3);
                    string speed = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("speed: " + speed);
                    sub = sub.Substring(sub.IndexOf(";\"") + 3);
                    string cores = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("cores: " + cores);
                    sub = sub.Substring(sub.IndexOf(";\"") + 3);
                    string tdp = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("tdp: " + tdp);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current == CurrentType.fan) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf(";\"") + 3);
                    string speed = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("rpm: " + speed);
                    sub = sub.Substring(sub.IndexOf(";\"") + 3);
                    string cores = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("noise level: " + cores);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current == CurrentType.motherboard) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string socket = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("socket: " + socket);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string form = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("form: " + form);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string slots = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("slots: " + slots);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string maxRam = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("max ram: " + maxRam);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current == CurrentType.memory) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string speed = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("speed: " + speed);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string type = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("type: " + type);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string cas = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("cas: " + cas);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string modules = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("modules: " + modules);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string size = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("size: " + size);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current == CurrentType.storage) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string series = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string form = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string type = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string capacity = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string cache = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Storage storage = new Storage(partNumber, name, double.Parse(price), series, form, type, capacity, cache);
                    storage.AddToDatabase();
                    partNumber++;
                }
            }
            else if (current == CurrentType.graphicsCard) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string series = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string chipset = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string memory = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string coreclock = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    GraphicsCard graphicsCard;
                    try { //Some have no price, ignore those
                        graphicsCard = new GraphicsCard(partNumber, name, double.Parse(price), series, chipset, memory, coreclock);
                    }
                    catch (Exception e) {
                        Log(LogLevel.ERROR, e.StackTrace);
                        continue;
                    }
                    graphicsCard.AddToDatabase();
                    partNumber++;
                }
            }
            else if (current == CurrentType.powerSupply) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string series = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string form = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string efficiency = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string watts = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string modular = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    PowerSupply powerSupply;
                    try { //Some have no price, ignore those
                        powerSupply = new PowerSupply(partNumber, name, double.Parse(price), series, form, efficiency, watts, modular);
                    }
                    catch (Exception e) {
                        Log(LogLevel.ERROR, e.StackTrace);
                        continue;
                    }
                    powerSupply.AddToDatabase();
                    partNumber++;
                }
            }
            else if (current == CurrentType.pcCase) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string type = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string ext514 = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string in312 = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string powersupply = sub.Substring(0, sub.IndexOf("<"));
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Case pcCase;
                    try { //Some have no price, just ignore those
                        pcCase = new Case(partNumber, name, double.Parse(price), type, int.Parse(ext514), int.Parse(in312), powersupply);
                    }
                    catch (Exception e) {
                        Log(LogLevel.ERROR, e.StackTrace);
                        continue;
                    }
                    pcCase.AddToDatabase();
                    partNumber++;
                }
            }
            else
                Console.WriteLine("invalid input: " + current);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        public static void Log(LogLevel level, string message) {
            TimeSpan time = DateTime.Now.Subtract(startTime);
            string log = String.Format( "{0,20}\t" + message, "<" + level + " " + (int)time.TotalMinutes + ":" + time.Seconds + ":" + time.Milliseconds + ">: ");
            Console.WriteLine(log);
            if (writer == null) {
                writer = new StreamWriter(logFile,false);
                writer.WriteLine(log);
                writer.Close();
                writer = new StreamWriter(logFile, true);
            }
            else
                writer.WriteLine(log);
        }
        public static void CloseLog() {
            writer.Close();
        }
        static void Main(string[] args) {
            /*PopulateTable(CurrentType.storage);
            PopulateTable(CurrentType.graphicsCard);
            PopulateTable(CurrentType.pcCase);
            PopulateTable(CurrentType.powerSupply);
            Log(LogLevel.DEBUG, "Populated Table");*/
            Part[] parts = Part.GetAllParts();
            foreach (Part p in parts) {
                //Console.WriteLine(p.GetPartNumber());
            }
            Query("SELECT * FROM `part`");
            Log(LogLevel.DEBUG, "Finished Program");
            CloseLog();
            while (true) {
                continue;
            }
        }
    }
}
