using System;
using System.IO;
using System.Net;
using System.Text;

namespace BackendConsoleTest {
    class Program {
        Program() {
        }
        //sends data to php
        public static string SendData(string url, string postData) {
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
            catch(Exception e) {
                Console.WriteLine(e.StackTrace);
            }
            return webpageContent;
        }
        static void Main(string[] args) {
            string data = SendData("http://satoshi.cis.uncw.edu/~tha7556/test.php","query=SELECT * FROM employee");
            Console.WriteLine(data);
            while(true) {
                continue;
            }
        }
    }
}
