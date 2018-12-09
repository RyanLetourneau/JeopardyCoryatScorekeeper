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
        public static Question GetQuestion()
        {
            var url = "http://jservice.io/api/random";
            var json = new WebClient().DownloadString(url);

            Question q = JsonConvert.DeserializeObject<Question>(json.Substring(1, json.Length-2));
            return q;
        }

    }
}
