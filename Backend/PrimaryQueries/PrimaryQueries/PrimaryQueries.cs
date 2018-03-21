using System;
using System.IO;
using System.Net;
using System.Text;
//TODO: Connect to frontend
//TODO: Populate all databases
//TODO: Prebuilt computers
namespace PrimaryQueries {
    ///<summary>
    ///Class used to query the MySQL PCHawkCustoms Database
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
        static void Main(string[] args) {
            string[] data = Query("SELECT * FROM employee WHERE `first name` = 'Tyler'");
            foreach (string s in data) {
                Console.WriteLine(s);
            }
            Employee e = Employee.GetEmployee("tha7556@uncw.edu");
            e.GetOrders();
            while (true) {
                continue;
            }
        }
    }
}
