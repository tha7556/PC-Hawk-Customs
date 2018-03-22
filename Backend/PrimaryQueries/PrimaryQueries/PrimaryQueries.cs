using System;
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
                Console.WriteLine(e.StackTrace);
            }
             
            string[] lines = webpageContent.Split('\n');
            string[] result = { };
            if (!webpageContent.Contains("Error") && !webpageContent.Contains("Warning")) {
                 result = new string[lines.Length - 4];
                Array.Copy(lines, 2, result, 0, lines.Length - 4);
            }
            else {
                if (webpageContent.Contains("Error"))
                    Console.WriteLine(webpageContent);
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
        public static void PopulateTable(string current) {
            string content = File.ReadAllText("..//..//part data//" + current + ".html");
            if (current.Equals("cpu")) {
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
            else if (current.Equals("fan")) {
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
            else if (current.Equals("motherboard")) {
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
            else if (current.Equals("memory")) {
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
            else if (current.Equals("storage")) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string series = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("series: " + series);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string form = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("form: " + form);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string type = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("type: " + type);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string capacity = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("capacity: " + capacity);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string cache = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("cache: " + cache);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current.Equals("graphicsCard")) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string series = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("series: " + series);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string chipset = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("chipset: " + chipset);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string memory = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("memory: " + memory);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string coreclock = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("coreclock: " + coreclock);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current.Equals("power")) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    string series = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("series: " + series);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string form = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("form: " + form);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string efficiency = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("efficiency: " + efficiency);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string watts = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("watts: " + watts);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string modular = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("modular: " + modular);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }
            else if (current.Equals("case")) {
                while (content.IndexOf("<tr>") != -1) {
                    content = content.Substring(content.IndexOf("<tr>") + 2);
                    string sub = content.Substring(0, content.IndexOf("</tr>"));
                    sub = sub.Substring(sub.IndexOf("a href"));
                    sub = sub.Substring(sub.IndexOf(">") + 1);
                    string name = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("name: " + name);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string type = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("type: " + type);
                    sub = sub.Substring(sub.IndexOf("<td>") + 4);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string ext514 = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("ext 5 1/4: " + ext514);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string in312 = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("in 3 1/2: " + in312);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string powersupply = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("power supply: " + powersupply);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                }
            }

        } 
        static void Main(string[] args) {
            PopulateTable("cpu");
            while (true) {
                continue;
            }
        }
    }
}
