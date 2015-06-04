using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace GameContract
{
// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Millionaire.ContractType".
    [DataContract]
    public class Player
    {
        [DataMember]
        public int PlayerID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Credit { get; set; }

        //public IGameplayCallback GameplayCallback { get; set; }

        public Player(int id, string name, int credit)
        {
            this.PlayerID = id;
            this.Name = name;
            this.Credit = credit;
        }
        

    }

    [DataContract]
    public class Question
    {
        [DataMember]
        public int QuestionID { get;set;}
        [DataMember]
        public string Details { get; set; }
        [DataMember]
        public List<Answer> Options;
        [DataMember]
        public string Answer { get; set; }

        //public IGameplayCallback GameplayCallback { get; set; }

        public Question(int id, string details, string answer)
        {
            this.QuestionID = id;
            this.Details = details;
            this.Answer = answer;
            Options = new List<Answer>();
        }
    }


    [DataContract]
    public class Answer
    {
        [DataMember]
        public int AnswerID { get; set; }
        [DataMember]
        public string Details { get; set; }

        public Answer(int id, string details)
        {
            this.AnswerID = id;
            this.Details = details;
        }
    }

    [ServiceContract(Namespace = "GameContract", CallbackContract = typeof(IGameplayCallback))]
    public interface IGameplay
    {
        [OperationContract(IsOneWay=true)]
        void AnswerQuestion(int qid);
        [OperationContract]
        void CorrectAnswer(string name);
        [OperationContract]
        bool CheckAnswer(Question q, string a);
        [OperationContract]
        List<Question> GetQuestionList();
        [OperationContract]
        List<Player> GetPlayerList();
        [OperationContract]
        void CreateAPlayer(int id, string name);
        [OperationContract]
        int GetCredit(Player p);
        [OperationContract]
        void Finish(int id);
        [OperationContract]
        void SubscribeEvent();
        [OperationContract]
        void UnsubscribeEvent();
        [OperationContract]
        void AddInfo(int id, string name, string password);
  
        
    }

    public interface IGameplayCallback
    {

        [OperationContract(IsOneWay=true)]
        void ShowNextQuestion();

    }


    /*public interface IGameplayCallback
    {
        [OperationContract]
        void PlayerReady(int nr);
        [OperationContract]
        void ShowNextQuestion(int id);
        [OperationContract]
        void ShowResult();
    }*/
}
