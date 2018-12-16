using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JeopardyScorekeeper
{
    public class Category
    {
        public int id { get; set; }
        public string title { get; set; }
        public int clues_count {get; set;}
        public Object[] clues { get; set; }
        public Question[] cluesQuestions { get; set; }

        public void GenerateQuestions()
        {
            Question[] questions = new Question[5];
            //turn object array into questions
            for(var i = 0; i < 5; i++)
            {
                Question q = JsonConvert.DeserializeObject<Question>(JsonConvert.SerializeObject(clues[i]));
                questions[i] = q;
            }
            cluesQuestions = questions;
        }

    }
}
