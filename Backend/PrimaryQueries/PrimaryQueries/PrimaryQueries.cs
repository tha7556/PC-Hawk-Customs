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
        public static void PopulateTable() {
            string current = "motherboard";
            if (current.Equals("cpu")) {
                string content = System.IO.File.ReadAllText("C://Users//Tyler//Desktop//cpu.html");
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
            else if(current.Equals("fan")) {
                string content = System.IO.File.ReadAllText("C://Users//Tyler//Desktop//fans.html");
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
                string content = System.IO.File.ReadAllText("C://Users//Tyler//Desktop//motherboard.html");
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
                    sub = sub.Substring(sub.IndexOf(";")+3);
                    string slots = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("slots: " + slots);
                    sub = sub.Substring(sub.IndexOf(";") + 3);
                    string maxRam = sub.Substring(0,sub.IndexOf("<"));
                    Console.WriteLine("max ram: " + maxRam);
                    sub = sub.Substring(sub.IndexOf("price") + 8);
                    string price = sub.Substring(0, sub.IndexOf("<"));
                    Console.WriteLine("price: " + price + "\n-----------------");
                    
                }
            }
        } 
        static void Main(string[] args) {
            PopulateTable();
            while (true) {
                continue;
            }
        }
    }
}
