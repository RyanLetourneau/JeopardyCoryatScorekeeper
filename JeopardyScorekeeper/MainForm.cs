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
    
    public partial class MainForm : Form
    {
        //string filepath = @"C:/Users/Public/JeopardyScores/JeopardyScores.txt";
        string filepath = Properties.Settings.Default.filename;

        Category[] categories;

        public List<Button> scoreButtons = new List<Button>();
        double roundOneScore = 0;
        bool doubleJeopardy = false;
        List<Question> questions = new List<Question>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddButtonsToScoreButtons();
            InitializeCategories();
            
        }

        public void InitializeCategories()
        {
            categories = GetCategories();
        }

        public Category[] GetCategories()
        {
            Category[] categories = new Category[6];
            for(var i = 0; i < 6; i++)
            {
                Category c = QuestionGrabber.GetCategory();
                c.GenerateQuestions(); //initialize questions in object for easy access
                categories[i] = c;
            }
            SetCategoryText(categories);
            LoadQuestionsArray(categories);
            Console.WriteLine(questions.ToString());
            return categories;
        }

        public void LoadQuestionsArray(Category[] arr)
        {
            foreach(Category c in arr) {
                //add the first 5 questions to the array
                for(var i = 0; i < 5; i++)
                {
                    questions.Add(c.cluesQuestions[i]);
                }
            }
        }

        public void SetCategoryText(Category[] c)
        {
            btnCategory1.Text = c[0].title;
            btnCategory2.Text = c[1].title;
            btnCategory3.Text = c[2].title;
            btnCategory4.Text = c[3].title;
            btnCategory5.Text = c[4].title;
            btnCategory6.Text = c[5].title;
        }

        public void AddButtonsToScoreButtons()
        {
            scoreButtons.Add(this.btnCol1Row1);
            scoreButtons.Add(this.btnCol1Row2);
            scoreButtons.Add(this.btnCol1Row3);
            scoreButtons.Add(this.btnCol1Row4);
            scoreButtons.Add(this.btnCol1Row5);
            scoreButtons.Add(this.btnCol2Row1);
            scoreButtons.Add(this.btnCol2Row2);
            scoreButtons.Add(this.btnCol2Row3);
            scoreButtons.Add(this.btnCol2Row4);
            scoreButtons.Add(this.btnCol2Row5);
            scoreButtons.Add(this.btnCol3Row1);
            scoreButtons.Add(this.btnCol3Row2);
            scoreButtons.Add(this.btnCol3Row3);
            scoreButtons.Add(this.btnCol3Row4);
            scoreButtons.Add(this.btnCol3Row5);
            scoreButtons.Add(this.btnCol4Row1);
            scoreButtons.Add(this.btnCol4Row2);
            scoreButtons.Add(this.btnCol4Row3);
            scoreButtons.Add(this.btnCol4Row4);
            scoreButtons.Add(this.btnCol4Row5);
            scoreButtons.Add(this.btnCol5Row1);
            scoreButtons.Add(this.btnCol5Row2);
            scoreButtons.Add(this.btnCol5Row3);
            scoreButtons.Add(this.btnCol5Row4);
            scoreButtons.Add(this.btnCol5Row5);
            scoreButtons.Add(this.btnCol6Row1);
            scoreButtons.Add(this.btnCol6Row2);
            scoreButtons.Add(this.btnCol6Row3);
            scoreButtons.Add(this.btnCol6Row4);
            scoreButtons.Add(this.btnCol6Row5);
        }

        #region hardcoded button click handlers 
        private void btn1Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(1, (Button)sender);
        }

        private void btn2Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(2, (Button)sender);
        }

        private void btn3Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(3, (Button)sender);
        }

        private void btn4Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(4, (Button)sender);
        }

        private void btn5Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(5, (Button)sender);
        }

        private void btn6Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(6, (Button)sender);
        }

        private void btn7Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(7, (Button)sender);
        }

        private void btn8Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(8, (Button)sender);
        }

        private void btn9Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(9, (Button)sender);
        }

        private void btn10Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(10, (Button)sender);
        }

        private void btn11Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(11, (Button)sender);
        }

        private void btn12Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(12, (Button)sender);
        }
        private void btn13Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(13, (Button)sender);
        }
        private void btn14Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(14, (Button)sender);
        }
        private void btn15Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(15, (Button)sender);
        }
        private void btn16Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(16, (Button)sender);
        }
        private void btn17Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(17, (Button)sender);
        }
        private void btn18Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(18, (Button)sender);
        }
        private void btn19Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(19, (Button)sender);
        }
        private void btn20Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(20, (Button)sender);
        }
        private void btn21Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(21, (Button)sender);
        }
        private void btn22Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(22, (Button)sender);
        }
        private void btn23Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(23, (Button)sender);
        }
        private void btn24Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(24, (Button)sender);
        }
        private void btn25Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(25, (Button)sender);
        }
        private void btn26Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(26, (Button)sender);
        }
        private void btn27Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(27, (Button)sender);
        }
        private void btn28Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(28, (Button)sender);
        }
        private void btn29Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(29, (Button)sender);
        }
        private void btn30Clicked(object sender, EventArgs e)
        {
            generateQuestionForm(30, (Button)sender);
        }
        #endregion

        private void btnClicked(object sender, EventArgs e)
        {
            generateQuestionForm();
            
            /*
            Button btnSender = (Button)sender; //get reference to make method reusable
            if(btnSender.BackColor == Color.Blue)
            {
                btnSender.BackColor = Color.Green;
            }
            else
            {
                if(btnSender.BackColor == Color.Green)
                {
                    btnSender.BackColor = Color.Red;
                }
                else
                {
                    btnSender.BackColor = Color.Blue;
                }
            }
            SetScoreText(CalculateScore(scoreButtons));  
            */
            
        }

        private void generateQuestionForm()
        {
            
            QuestionForm qf = new QuestionForm(QuestionGrabber.GetQuestion());
            qf.FormClosed += new FormClosedEventHandler(questionFormClosed);
            qf.Show();
            
            
        }

        private void questionFormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("closing form");
            SetScoreText(CalculateScore(scoreButtons));
        }

        private void generateQuestionForm(int index, Button parentButton)
        {
            QuestionForm qf = new QuestionForm(questions.ElementAt(index - 1), parentButton, this);
            qf.Show();
        }

        public double CalculateScore(List<Button> buttons)
        {
            double result = 0.00;
            foreach(Button b in buttons)
            {
                if(b.BackColor == Color.Green)
                {
                    result += (Double.Parse(b.Text.Remove(0,1)));
                }
                else if(b.BackColor == Color.Red)
                {
                    result -= (Double.Parse(b.Text.Remove(0,1)));
                }
            }
            return result;
        }
        
        public void SetScoreText(double score)
        {
            this.labelScore.Text = string.Format("${0}", roundOneScore + score);
        }

        public static void SetScoreTextStatic(double score)
        {
            
        }

        private void btnResetBoard_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset the board?", "Confirm Reset", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                ResetGameToStart();
            }
        }

        private void ResetGameToStart()
        { 
            ResetBoard(scoreButtons);
            roundOneScore = 0;
            SetScoreText(CalculateScore(scoreButtons));
        }

        private void btnDoubleJeopardy_Click(object sender, EventArgs e)
        {
            roundOneScore = CalculateScore(scoreButtons);
            ResetBoard(scoreButtons);
            DoubleScoreValues(scoreButtons);
            doubleJeopardy = true;
        }

        private void ResetBoard(List<Button> buttons)
        {
            //reset the board without resetting round one score
            questions = new List<Question>();
            InitializeCategories();
            foreach (Button b in scoreButtons)
            {
                b.BackColor = Color.Blue;
                b.Enabled = true;
            }

            if(doubleJeopardy) //reset board to single jeopardy values
            {
                HalveScoreValues(scoreButtons);
            }
        }

        private void DoubleScoreValues(List<Button> buttons)
        {
            if(!doubleJeopardy)
            {
                foreach (Button b in scoreButtons)
                {
                    double currentScore = Double.Parse(b.Text.Remove(0, 1));
                    currentScore *= 2;
                    b.Text = string.Format("${0}", currentScore);
                }
                doubleJeopardy = true;
            }
            else
            {
                MessageBox.Show("You are already in Double Jeopardy");
            }
            
            
        }

        private void HalveScoreValues(List<Button> buttons)
        {
            if(doubleJeopardy)
            {
                foreach (Button b in scoreButtons)
                {
                    double currentScore = Double.Parse(b.Text.Remove(0, 1));
                    currentScore /= 2;
                    b.Text = String.Format("${0}", currentScore);
                }
                doubleJeopardy = false;
            }
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you wish to end this game?", "End game", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                DateTime today = DateTime.Now;
                string[] lines = { today.Month + "/" + today.Day + "/" + today.Year + " " + labelScore.Text.Remove(0, 1) };
                if(filepath != null && filepath != "null")
                {
                    System.IO.File.AppendAllLines(filepath, lines);
                }
                else
                {
                    OpenFileDialog filepathDialog = new OpenFileDialog();
                    if(filepathDialog.ShowDialog() == DialogResult.OK)
                    {
                        filepath = filepathDialog.FileName;
                        Properties.Settings.Default.filename = filepath;
                        Properties.Settings.Default.Save();
                        System.IO.File.AppendAllLines(filepath, lines);
                    }
                }
                

                ResetGameToStart();
            }
        }
    }

   
}
