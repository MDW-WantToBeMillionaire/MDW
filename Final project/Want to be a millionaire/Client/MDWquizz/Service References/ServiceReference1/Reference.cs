﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDWquizz.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/GameContract")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MDWquizz.ServiceReference1.Answer[] OptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuestionIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MDWquizz.ServiceReference1.Answer[] Options {
            get {
                return this.OptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.OptionsField, value) != true)) {
                    this.OptionsField = value;
                    this.RaisePropertyChanged("Options");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuestionID {
            get {
                return this.QuestionIDField;
            }
            set {
                if ((this.QuestionIDField.Equals(value) != true)) {
                    this.QuestionIDField = value;
                    this.RaisePropertyChanged("QuestionID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Answer", Namespace="http://schemas.datacontract.org/2004/07/GameContract")]
    [System.SerializableAttribute()]
    public partial class Answer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnswerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AnswerID {
            get {
                return this.AnswerIDField;
            }
            set {
                if ((this.AnswerIDField.Equals(value) != true)) {
                    this.AnswerIDField = value;
                    this.RaisePropertyChanged("AnswerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/GameContract")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CounterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CreditField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PlayerIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Counter {
            get {
                return this.CounterField;
            }
            set {
                if ((this.CounterField.Equals(value) != true)) {
                    this.CounterField = value;
                    this.RaisePropertyChanged("Counter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Credit {
            get {
                return this.CreditField;
            }
            set {
                if ((this.CreditField.Equals(value) != true)) {
                    this.CreditField = value;
                    this.RaisePropertyChanged("Credit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PlayerID {
            get {
                return this.PlayerIDField;
            }
            set {
                if ((this.PlayerIDField.Equals(value) != true)) {
                    this.PlayerIDField = value;
                    this.RaisePropertyChanged("PlayerID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGameplay", CallbackContract=typeof(MDWquizz.ServiceReference1.IGameplayCallback))]
    public interface IGameplay {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/AnswerQuestion")]
        void AnswerQuestion(int qid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/AnswerQuestion")]
        System.Threading.Tasks.Task AnswerQuestionAsync(int qid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CorrectAnswer", ReplyAction="http://tempuri.org/IGameplay/CorrectAnswerResponse")]
        void CorrectAnswer(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CorrectAnswer", ReplyAction="http://tempuri.org/IGameplay/CorrectAnswerResponse")]
        System.Threading.Tasks.Task CorrectAnswerAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CheckAnswer", ReplyAction="http://tempuri.org/IGameplay/CheckAnswerResponse")]
        bool CheckAnswer(MDWquizz.ServiceReference1.Question q, string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CheckAnswer", ReplyAction="http://tempuri.org/IGameplay/CheckAnswerResponse")]
        System.Threading.Tasks.Task<bool> CheckAnswerAsync(MDWquizz.ServiceReference1.Question q, string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetQuestionList", ReplyAction="http://tempuri.org/IGameplay/GetQuestionListResponse")]
        MDWquizz.ServiceReference1.Question[] GetQuestionList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetQuestionList", ReplyAction="http://tempuri.org/IGameplay/GetQuestionListResponse")]
        System.Threading.Tasks.Task<MDWquizz.ServiceReference1.Question[]> GetQuestionListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetPlayerList", ReplyAction="http://tempuri.org/IGameplay/GetPlayerListResponse")]
        MDWquizz.ServiceReference1.Player[] GetPlayerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetPlayerList", ReplyAction="http://tempuri.org/IGameplay/GetPlayerListResponse")]
        System.Threading.Tasks.Task<MDWquizz.ServiceReference1.Player[]> GetPlayerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CreateAPlayer", ReplyAction="http://tempuri.org/IGameplay/CreateAPlayerResponse")]
        void CreateAPlayer(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CreateAPlayer", ReplyAction="http://tempuri.org/IGameplay/CreateAPlayerResponse")]
        System.Threading.Tasks.Task CreateAPlayerAsync(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetCredit", ReplyAction="http://tempuri.org/IGameplay/GetCreditResponse")]
        int GetCredit(MDWquizz.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetCredit", ReplyAction="http://tempuri.org/IGameplay/GetCreditResponse")]
        System.Threading.Tasks.Task<int> GetCreditAsync(MDWquizz.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/Finish")]
        void Finish();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/Finish")]
        System.Threading.Tasks.Task FinishAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/SubscribeEvent", ReplyAction="http://tempuri.org/IGameplay/SubscribeEventResponse")]
        void SubscribeEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/SubscribeEvent", ReplyAction="http://tempuri.org/IGameplay/SubscribeEventResponse")]
        System.Threading.Tasks.Task SubscribeEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/WinnerEvent", ReplyAction="http://tempuri.org/IGameplay/WinnerEventResponse")]
        void WinnerEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/WinnerEvent", ReplyAction="http://tempuri.org/IGameplay/WinnerEventResponse")]
        System.Threading.Tasks.Task WinnerEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/ShowFirstQuestion", ReplyAction="http://tempuri.org/IGameplay/ShowFirstQuestionResponse")]
        void ShowFirstQuestion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/ShowFirstQuestion", ReplyAction="http://tempuri.org/IGameplay/ShowFirstQuestionResponse")]
        System.Threading.Tasks.Task ShowFirstQuestionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/Winner", ReplyAction="http://tempuri.org/IGameplay/WinnerResponse")]
        MDWquizz.ServiceReference1.Player Winner();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/Winner", ReplyAction="http://tempuri.org/IGameplay/WinnerResponse")]
        System.Threading.Tasks.Task<MDWquizz.ServiceReference1.Player> WinnerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetRemain", ReplyAction="http://tempuri.org/IGameplay/GetRemainResponse")]
        int GetRemain(MDWquizz.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetRemain", ReplyAction="http://tempuri.org/IGameplay/GetRemainResponse")]
        System.Threading.Tasks.Task<int> GetRemainAsync(MDWquizz.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/AddPlayer", ReplyAction="http://tempuri.org/IGameplay/AddPlayerResponse")]
        int AddPlayer(int id, string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/AddPlayer", ReplyAction="http://tempuri.org/IGameplay/AddPlayerResponse")]
        System.Threading.Tasks.Task<int> AddPlayerAsync(int id, string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CheckPlayer", ReplyAction="http://tempuri.org/IGameplay/CheckPlayerResponse")]
        bool CheckPlayer(int id, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/CheckPlayer", ReplyAction="http://tempuri.org/IGameplay/CheckPlayerResponse")]
        System.Threading.Tasks.Task<bool> CheckPlayerAsync(int id, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetName", ReplyAction="http://tempuri.org/IGameplay/GetNameResponse")]
        string GetName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/GetName", ReplyAction="http://tempuri.org/IGameplay/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/FinishQuesion")]
        void FinishQuesion();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/FinishQuesion")]
        System.Threading.Tasks.Task FinishQuesionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/Leave", ReplyAction="http://tempuri.org/IGameplay/LeaveResponse")]
        void Leave();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameplay/Leave", ReplyAction="http://tempuri.org/IGameplay/LeaveResponse")]
        System.Threading.Tasks.Task LeaveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameplayCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/ShowNextQuestion")]
        void ShowNextQuestion();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/GameStart")]
        void GameStart();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameplay/GameFinish")]
        void GameFinish(MDWquizz.ServiceReference1.Player p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameplayChannel : MDWquizz.ServiceReference1.IGameplay, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameplayClient : System.ServiceModel.DuplexClientBase<MDWquizz.ServiceReference1.IGameplay>, MDWquizz.ServiceReference1.IGameplay {
        
        public GameplayClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GameplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GameplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameplayClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void AnswerQuestion(int qid) {
            base.Channel.AnswerQuestion(qid);
        }
        
        public System.Threading.Tasks.Task AnswerQuestionAsync(int qid) {
            return base.Channel.AnswerQuestionAsync(qid);
        }
        
        public void CorrectAnswer(string name) {
            base.Channel.CorrectAnswer(name);
        }
        
        public System.Threading.Tasks.Task CorrectAnswerAsync(string name) {
            return base.Channel.CorrectAnswerAsync(name);
        }
        
        public bool CheckAnswer(MDWquizz.ServiceReference1.Question q, string a) {
            return base.Channel.CheckAnswer(q, a);
        }
        
        public System.Threading.Tasks.Task<bool> CheckAnswerAsync(MDWquizz.ServiceReference1.Question q, string a) {
            return base.Channel.CheckAnswerAsync(q, a);
        }
        
        public MDWquizz.ServiceReference1.Question[] GetQuestionList() {
            return base.Channel.GetQuestionList();
        }
        
        public System.Threading.Tasks.Task<MDWquizz.ServiceReference1.Question[]> GetQuestionListAsync() {
            return base.Channel.GetQuestionListAsync();
        }
        
        public MDWquizz.ServiceReference1.Player[] GetPlayerList() {
            return base.Channel.GetPlayerList();
        }
        
        public System.Threading.Tasks.Task<MDWquizz.ServiceReference1.Player[]> GetPlayerListAsync() {
            return base.Channel.GetPlayerListAsync();
        }
        
        public void CreateAPlayer(int id, string name) {
            base.Channel.CreateAPlayer(id, name);
        }
        
        public System.Threading.Tasks.Task CreateAPlayerAsync(int id, string name) {
            return base.Channel.CreateAPlayerAsync(id, name);
        }
        
        public int GetCredit(MDWquizz.ServiceReference1.Player p) {
            return base.Channel.GetCredit(p);
        }
        
        public System.Threading.Tasks.Task<int> GetCreditAsync(MDWquizz.ServiceReference1.Player p) {
            return base.Channel.GetCreditAsync(p);
        }
        
        public void Finish() {
            base.Channel.Finish();
        }
        
        public System.Threading.Tasks.Task FinishAsync() {
            return base.Channel.FinishAsync();
        }
        
        public void SubscribeEvent() {
            base.Channel.SubscribeEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeEventAsync() {
            return base.Channel.SubscribeEventAsync();
        }
        
        public void WinnerEvent() {
            base.Channel.WinnerEvent();
        }
        
        public System.Threading.Tasks.Task WinnerEventAsync() {
            return base.Channel.WinnerEventAsync();
        }
        
        public void ShowFirstQuestion() {
            base.Channel.ShowFirstQuestion();
        }
        
        public System.Threading.Tasks.Task ShowFirstQuestionAsync() {
            return base.Channel.ShowFirstQuestionAsync();
        }
        
        public MDWquizz.ServiceReference1.Player Winner() {
            return base.Channel.Winner();
        }
        
        public System.Threading.Tasks.Task<MDWquizz.ServiceReference1.Player> WinnerAsync() {
            return base.Channel.WinnerAsync();
        }
        
        public int GetRemain(MDWquizz.ServiceReference1.Player p) {
            return base.Channel.GetRemain(p);
        }
        
        public System.Threading.Tasks.Task<int> GetRemainAsync(MDWquizz.ServiceReference1.Player p) {
            return base.Channel.GetRemainAsync(p);
        }
        
        public int AddPlayer(int id, string name, string password) {
            return base.Channel.AddPlayer(id, name, password);
        }
        
        public System.Threading.Tasks.Task<int> AddPlayerAsync(int id, string name, string password) {
            return base.Channel.AddPlayerAsync(id, name, password);
        }
        
        public bool CheckPlayer(int id, string pwd) {
            return base.Channel.CheckPlayer(id, pwd);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPlayerAsync(int id, string pwd) {
            return base.Channel.CheckPlayerAsync(id, pwd);
        }
        
        public string GetName() {
            return base.Channel.GetName();
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync() {
            return base.Channel.GetNameAsync();
        }
        
        public void FinishQuesion() {
            base.Channel.FinishQuesion();
        }
        
        public System.Threading.Tasks.Task FinishQuesionAsync() {
            return base.Channel.FinishQuesionAsync();
        }
        
        public void Leave() {
            base.Channel.Leave();
        }
        
        public System.Threading.Tasks.Task LeaveAsync() {
            return base.Channel.LeaveAsync();
        }
    }
}