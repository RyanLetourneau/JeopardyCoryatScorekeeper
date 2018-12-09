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

        List<Button> scoreButtons = new List<Button>();
        double roundOneScore = 0;
        bool doubleJeopardy = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddButtonsToScoreButtons();
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

        private void btnClicked(object sender, EventArgs e)
        {
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
            foreach (Button b in scoreButtons)
            {
                b.BackColor = Color.Blue;
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
