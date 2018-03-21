using System;
using System.IO;
using System.Net;
using System.Text;

namespace PrimaryQueries {
    ///<summary>
    ///Class used to query the MySQL PCHawkCustoms Database
    ///</summary>
    class PrimaryQueries {
        /// <summary>
        /// Sends a Query to the Database
        /// </summary>
        /// <param name="query">The MySQL query to perform</param>
        /// <returns>A string[] containing each result of the query</returns>
        public static string[] Query(string query) {
            string url = "http://satoshi.cis.uncw.edu/~tha7556/test.php";
            string postData = "query=" + query;
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
            string[] result = new string[lines.Length - 4];
            Array.Copy(lines, 2, result, 0, lines.Length - 4);
            return result;
        }
        static void Main(string[] args) {
            string[] data = Query("SELECT * FROM customer");
            foreach (string s in data) {
                Console.WriteLine(s);
            }
            Console.WriteLine(data.Length);
            while (true) {
                continue;
            }
        }
    }
}
