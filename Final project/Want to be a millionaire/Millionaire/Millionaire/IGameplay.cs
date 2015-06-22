﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
        [DataMember]
        public int Counter { get; set; }

        //public IGameplayCallback GameplayCallback { get; set; }

        public Player(int id, string name, int credit)
        {
            this.PlayerID = id;
            this.Name = name;
            this.Credit = credit;
            this.Counter = 10;
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

    [ServiceContract(CallbackContract = typeof(IGameplayCallback))]
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
        [OperationContract(IsOneWay = true)]
        void Finish();
        [OperationContract]
        void SubscribeEvent();
        [OperationContract]
        void WinnerEvent();
        [OperationContract]
        void ShowFirstQuestion();
        [OperationContract]
        Player Winner();
        [OperationContract]
        int GetRemain(Player p);
        [OperationContract]
        int AddPlayer(int id, string name, string password);
        [OperationContract]
        bool CheckPlayer(int id, string pwd);
        [OperationContract]
        string GetName();
        [OperationContract(IsOneWay = true)]
        void FinishQuesion();
        [OperationContract]
        void Leave();
    }

    public interface IGameplayCallback
    {
        [OperationContract(IsOneWay=true)]
        void ShowNextQuestion();
        [OperationContract(IsOneWay = true)]
        void GameStart();
        [OperationContract(IsOneWay = true)]
        void GameFinish(Player p);
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
