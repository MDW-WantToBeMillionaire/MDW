using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace GameContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CGameplay : IGameplay
    {
        public List<Question> qList;
        public List<Question> aqList;
        public List<Player> pList;
        string Name = "Haha";

        static Action myEvent = delegate { };
        static Action<Player> myEvent2 = delegate { };

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

        public int GetRemain(Player p)
        {
            return p.Counter;
        }

        public void AnswerQuestion(int qid)
        {
            foreach (Player p in pList)
            {
                if (p.PlayerID == qid) p.Counter -= 1;
            }

        }

        public void FinishQuesion()
        {
            myEvent();
        }

        public void Finish()
        {
            List<Player> temp = GetPlayerList();
            Player player1 = temp[0];
            Player player2 = temp[1];
            if (player1.Counter == 0 && player2.Counter == 0)
            {
                Player winner = Winner();
                myEvent2(winner);
            }
        }

        public bool CheckAnswer(Question q, string a)
        {
            if (a == q.Answer)
            {

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
                }

            }
        }

        public void CreateAPlayer(int id, string name)
        {
            Player player = new Player(id, name, 0);
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
        }

        public void ShowFirstQuestion()
        {
            IGameplayCallback clientCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
            myEvent += clientCallback.GameStart;
        }

        public void WinnerEvent()
        {
            IGameplayCallback clientCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
            myEvent2 += clientCallback.GameFinish;
        }

        public Player Winner()
        {
            List<Player> temp = GetPlayerList();
            Player player1 = temp[0];
            Player player2 = temp[1];
            if (player1.Credit > player2.Credit)
            {
                return player1;
            }
            else if (player1.Credit < player2.Credit)
            {
                return player2;
            }
            else return null;
        }

        public int AddPlayer(int id, string name, string password)
        {
            MySqlConnection connection;
            String playerInfo = "server=athena01.fhict.local;Database=dbi270179;Uid=dbi270179;Pwd=WG7gpbOAEn;";
            connection = new MySqlConnection(playerInfo);
            String sql = "INSERT INTO Players(player_id,player_name,password) values(" + id + ",'" + name + "'" + ",'" + password + "'" + ")";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                connection.Close();
                return nrOfRecordsChanged;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckPlayer(int id, string pwd)
        {
            bool rowExist;
            MySqlConnection connection;
            String playerInfo = "server=athena01.fhict.local;Database=dbi270179;Uid=dbi270179;Pwd=WG7gpbOAEn;";
            connection = new MySqlConnection(playerInfo);
            try
            {
                connection.Open();
                String sql = "SELECT player_name FROM Players WHERE player_id = @id and password = @pwd";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add(new MySqlParameter("@id", id));
                command.Parameters.Add(new MySqlParameter("@pwd", pwd));
                MySqlDataReader dr = command.ExecuteReader();
                rowExist = dr.HasRows;
                while (dr.Read())
                {
                    Name = dr[0].ToString();
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return rowExist;
        }

        public string GetName()
        {
            return Name;
        }

        public void Leave()
        {
            foreach (Player p in pList)
            {
                p.Counter = 0;
            }
        }


    }
}

