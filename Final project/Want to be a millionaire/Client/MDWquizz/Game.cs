using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using MDWquizz.ServiceReference1;
using System.Diagnostics;

namespace MDWquizz
{
    public partial class Game : Form, IGameplayCallback
    {
        private ServiceReference1.GameplayClient proxy;
        private List<Question> qList;
        private int id;
        private int counter;
        int wrong = 0;

        public Game(int id)
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            proxy = new ServiceReference1.GameplayClient(instanceContext);
            counter = 10;
            qList = new List<Question>();
            foreach (Question q in proxy.GetQuestionList())
            {
                qList.Add(q);
            }
            textBoxName.Text = proxy.GetName();
            Shuffle(qList);
        }
        /// <summary>
        /// Shuffle the question list
        /// </summary>
        /// <param name="list"></param>
        public static void Shuffle(List<Question> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Question value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        /// <summary>
        /// Show questions and options on the screen, or finish the game
        /// </summary>
        public void ShowOptions()
        {
            if (counter == 0)
            {
                richTextBoxQuestion.Text = "Please wait for the other player to finish!";
                buttonConfirm.Enabled = false;
                proxy.Finish();
            }
            else
            {
                richTextBoxQuestion.Text = qList[10 - counter].Details;
                buttonA.Text = qList[10 - counter].Options[0].Details;
                buttonB.Text = qList[10 - counter].Options[1].Details;
                buttonC.Text = qList[10 - counter].Options[2].Details;
                buttonD.Text = qList[10 - counter].Options[3].Details;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            radioButtonA.Select();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            radioButtonC.Select();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            radioButtonB.Select();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            radioButtonD.Select();
        }



        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string choice = GetChoice();
            if (proxy.CheckAnswer(qList[10 - counter], choice))
            {
                foreach (Player p in proxy.GetPlayerList())
                {
                    if (p.Name == textBoxName.Text)
                    {
                        proxy.CorrectAnswer(p.Name);
                    }
                }
                listBox1.Items.Add("Correct");
            }
            else 
            { 
                wrong += 1;
                listBox1.Items.Add("Wrong");
            }
            counter -= 1;
            proxy.AnswerQuestion(id);
            UpdateScore();
            proxy.FinishQuesion();
        }

        public void ShowNextQuestion()
        {
            ShowOptions();
        }

        public void GameStart()
        {
            ShowOptions();
        }
        /// <summary>
        /// Get User's choice
        /// </summary>
        /// <returns></returns>
        public string GetChoice()
        {
            string a ="";
            if (radioButtonA.Checked) a = "a";
            else if (radioButtonB.Checked) a = "b";
            else if (radioButtonC.Checked) a = "c";
            else if (radioButtonD.Checked) a = "d";
            return a;
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            
            id = proxy.GetPlayerList().Length + 1;
            proxy.ShowFirstQuestion();
            string name = textBoxName.Text;
            proxy.CreateAPlayer(id, name);
            foreach (Player p in proxy.GetPlayerList())
            {
                listBox1.Items.Add(p.Name);
                listBox1.Items.Add(p.Credit);
            }
            UpdateScore();
            textBoxWrong.Text = wrong.ToString();
            proxy.SubscribeEvent();
            richTextBoxQuestion.Text = qList[10 - counter].Details;
            buttonA.Text = qList[10 - counter].Options[0].Details;
            buttonB.Text = qList[10 - counter].Options[1].Details;
            buttonC.Text = qList[10 - counter].Options[2].Details;
            buttonD.Text = qList[10 - counter].Options[3].Details;
            proxy.WinnerEvent();
            buttonReady.Text = "OK";
            this.buttonReady.Enabled = false;
        }

        /// <summary>
        /// update user's score
        /// </summary>
        public void UpdateScore()
        {
            foreach (Player p in proxy.GetPlayerList())
            {
                if (p.Name == textBoxName.Text)
                {
                    textBoxRemain.Text = proxy.GetRemain(p).ToString();
                    textBoxCorrect.Text = proxy.GetCredit(p).ToString();
                }
            }
            textBoxWrong.Text = wrong.ToString();
        }

        public void GameFinish(Player p)
        {
            if (p != null)
            {
                MessageBox.Show("The winner is " + p.Name);
            }
            else
                MessageBox.Show("It's a tie!");
            richTextBoxQuestion.Text = "Game Over!";
            buttonA.Text = "";
            buttonB.Text = "";
            buttonC.Text = "";
            buttonD.Text = "";
            buttonLeave.Enabled = false;
            buttonConfirm.Enabled = false;
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            proxy.Leave();
            proxy.Finish();
            
        }



    }
}
