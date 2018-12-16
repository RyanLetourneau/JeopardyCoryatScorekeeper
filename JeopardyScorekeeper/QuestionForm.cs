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
        private string category;
        private Button parentButton;
        private MainForm parentForm;

        public QuestionForm(Question q, Button parentButton = null, MainForm parentForm = null)
        {
            InitializeComponent();
            question = q.question;
            answer = q.answer;
            this.parentButton = parentButton;
            this.parentForm = parentForm;
            this.FormClosing += QuestionForm_FormClosing;
        }

        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            double score = parentForm.CalculateScore(parentForm.scoreButtons);
            parentForm.SetScoreText(score);
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

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            parentButton.BackColor = Color.Green;
            parentButton.Enabled = false;
            this.Close();
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            parentButton.BackColor = Color.Red;
            parentButton.ForeColor = Color.White;
            parentButton.Enabled = false;
            this.Close();
        }

        private void btnNoAnswer_Click(object sender, EventArgs e)
        {
            parentButton.Enabled = false;
            parentButton.ForeColor = Color.White;
            this.Close();
        }
    }
}
