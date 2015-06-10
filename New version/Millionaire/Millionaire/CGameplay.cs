using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace GameContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    //[CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CGameplay : IGameplay
    {
        public List<Question> qList;
        public List<Question> aqList;
        public List<Player> pList;

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

        public void AnswerQuestion(int qid)
        {
            foreach (Player p in pList)
            {
                if (p.PlayerID == qid) p.Counter -= 1;
            }
            myEvent();
        }

        public void Finish()
        {
            //Player winner = Winner();
            //myEvent2(winner);
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
            myEvent2 += clientCallback.GameFinish;
            //myEvent += OperationContext.Current.GetCallbackChannel<IGameplayCallback>().ShowNextQuestion;
        }

        public void ShowFirstQuestion()
        {
            IGameplayCallback clientCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
            myEvent += clientCallback.GameStart;
        }

        public void UnsubscribeEvent()
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
    }
}
