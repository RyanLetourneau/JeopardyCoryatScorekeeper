using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyScorekeeper
{
    public partial class QuestionForm : Form
    {
        private string question;
        private string answer;

        public QuestionForm(Question q)
        {
            InitializeComponent();
            question = q.question;
            answer = q.answer;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            this.textBoxQuestion.Text = question;
            this.textBoxAnswer.Text = answer;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if(this.textBoxAnswer.Visible)
            {
                this.textBoxAnswer.Visible = false;
            }
            else
            {
                this.textBoxAnswer.Visible = true;
            }
        }
    }
}
