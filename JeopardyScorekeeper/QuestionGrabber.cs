using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace JeopardyScorekeeper
{
    class QuestionGrabber
    {
        private static Random rng = new Random();

        public static Question GetQuestion()
        {
            var url = "http://jservice.io/api/random";
            var json = new WebClient().DownloadString(url);

            Question q = JsonConvert.DeserializeObject<Question>(json.Substring(1, json.Length - 2));
           
            return q;
        }

        public static Category GetCategory()
        {
            int questionIndex = rng.Next(1, 18400);
            string json = null;
            try
            {
                string url = String.Format("http://jservice.io/api/category?id={0}", questionIndex);
                json = new WebClient().DownloadString(url);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Category c = JsonConvert.DeserializeObject<Category>(json);
            return c;
        }
    }
}
