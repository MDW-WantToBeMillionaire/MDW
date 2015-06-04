using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Millionaire;

namespace GameContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] 

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CGameplay : IGameplay
    {
        public List<Question> qList;
        public List<Question> aqList;
        public List<Player> pList;
        

        static Action myEvent = delegate { };

        public CGameplay()
        {
            qList = new List<Question>();
            FileHelper questionHelper = new FileHelper("../../../data/questions.txt");
            qList = questionHelper.QuestionLoadFromFile();
            pList = new List<Player>();
            aqList = new List<Question>();
        }

        public List<Question> GetQuestionList()
        {
            return qList;
        }

        public List<Player> GetPlayerList()
        {
            return pList;
        }

        public void AnswerQuestion(int qid)
        {
            /*foreach (Question q in qList)
            {
                if (q.QuestionID == qid)
                {
                    Question aq = new Question(q.QuestionID, q.Details, q.Answer);
                    //aq.GameplayCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
                    myEvent();
                    aqList.Add(aq);
                }
            }*/
            myEvent();
        }

        public void Finish(int id)
        {
            foreach (Question qq in aqList)
            {
                if (qq.QuestionID == id)
                {
                    //qq.GameplayCallback.ShowNextQuestion();

                }
            }
        }

        public bool CheckAnswer(Question q, string a)
        {
            //myEvent();
            if (a == q.Answer)
            {
                /*foreach (Question qq in aqList)
                {
                    if (qq.QuestionID == q.QuestionID)
                    {
                        myEvent(qq);
                    }
                }*/
                
                return true;
            }
            else return false;
        }

        public void CorrectAnswer(string name)
        {
            foreach (Player p in pList)
            { 
                if (p.Name == name)
                {
                    p.Credit += 1;
                    //Console.WriteLine(p.Name + p.Credit);
                    //p.GameplayCallback.ShowNextQuestion();
                }
                
            }
            //p.Credit += 1;
        }

        public void CreateAPlayer(int id, string name)
        {
            Player player = new Player(id, name, 0);
            //player.GameplayCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
            pList.Add(player);
        }

        public int GetCredit(Player p)
        {
            return p.Credit;
        }

        public void SubscribeEvent()
        {
            IGameplayCallback clientCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
            myEvent += clientCallback.ShowNextQuestion;
            //myEvent += OperationContext.Current.GetCallbackChannel<IGameplayCallback>().ShowNextQuestion;
        }

        public void UnsubscribeEvent()
        {
            myEvent -= OperationContext.Current.GetCallbackChannel<IGameplayCallback>().ShowNextQuestion;
        }


        public void AddInfo(int id, string name, string password)
        {
            MySqlConnection connection;
            String playerInfo = "server=athena01.fhict.local;Database=dbi270179;Uid=dbi270179;Pwd=WG7gpbOAEn;";
            connection = new MySqlConnection(playerInfo);
            try
            {
                connection.Open();
                String sql = "INSERT INTO Players(player_id,player_name,password) values("+ id + ",'" + name + "'" + ",'" + password + "'" + ")";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public bool LoginCheck(int id,string pwd)
        {
            Player p;
            MySqlConnection connection;
            String playerInfo = "server=athena01.fhict.local;Database=dbi270179;Uid=dbi270179;Pwd=WG7gpbOAEn;";
            connection = new MySqlConnection(playerInfo);
            try
            {
                connection.Open();
                String sql = "SELECT * FROM Players WHERE player_id = @id and password = @pwd";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@id",id);
                command.Parameters.Add("@pwd",pwd);
                SqlDataReader reader=command.ExecuteReader();
                while(reader.Read())
                {
                    
                }
                connection.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
         

        }



        
    }
}
