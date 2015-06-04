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
        //private int currentQuestion;
        private int id;
        private int counter;
        int wrong = 0;

        public Game()
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            proxy = new ServiceReference1.GameplayClient(instanceContext);
            counter = 10;
            qList = new List<Question>();
            foreach (Question q in proxy.GetQuestionList())
            {
                qList.Add(q);
                //listBox1.Items.Add(q.Answer);
            }
            ShowOptions();
            //currentQuestion = 0;
            id = proxy.GetPlayerList().Length + 1;
            foreach (Question q in qList)
            {
                listBox1.Items.Add(q.Details);
            }
            proxy.SubscribeEvent();
            textBoxQuestion.Text = qList[0].Details;
            
        }

        public void ShowOptions()
        {
            buttonA.Text = qList[10 - counter].Options[0].Details;
            buttonB.Text = qList[10 - counter].Options[1].Details;
            buttonC.Text = qList[10 - counter].Options[2].Details;
            buttonD.Text = qList[10 - counter].Options[3].Details;
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
            MessageBox.Show("I am here");
            if (proxy.CheckAnswer(qList[10 - counter], choice))
            {
                foreach (Player p in proxy.GetPlayerList())
                {
                    //if (p.Name == textBoxName.Text)
                    proxy.CorrectAnswer(p.Name);
                    //p.Credit = 5;
                    //textBoxCorrect.Text = proxy.GetCredit(p).ToString();
                }
                listBox1.Items.Add("true");
            }
            else { wrong += 1; }
            //proxy.AnswerQuestion(qList[10 - counter].QuestionID);   
            counter -= 1;
            UpdateScore();
            proxy.AnswerQuestion(id);
            //proxy.Finish(qList[9 - counter].QuestionID);
            //ShowOptions();
        }

        public void ShowNextQuestion()
        {
            textBoxQuestion.Text = qList[1].Details;
            ShowOptions();
            //MessageBox.Show("");
        }

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
            string name = textBoxName.Text;
            proxy.CreateAPlayer(id, name);
            foreach (Player p in proxy.GetPlayerList())
            {
                listBox1.Items.Add(p.Name);
                listBox1.Items.Add(p.Credit);
            }
            UpdateScore();
            textBoxWrong.Text = wrong.ToString();
        }

        public void UpdateScore()
        {
            textBoxRemain.Text = counter.ToString();
            foreach (Player p in proxy.GetPlayerList())
            {
                //Debug.WriteLine("p name {0} , p credit is : {1}",p.Name,p.Credit);
                if (p.Name == textBoxName.Text)
                {
                    //p.Name = "BlaBla";

                    textBoxCorrect.Text = proxy.GetCredit(p).ToString();
                    //Debug.WriteLine("Value of Credit is : {0}",p.Credit);
                    //textBoxCorrect.Text = proxy.GetPlayerList()[0].Name;
                }
            }
            textBoxWrong.Text = wrong.ToString();
        }







    }
}
