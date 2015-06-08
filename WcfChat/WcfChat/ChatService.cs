using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfChat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ChatService : IChatService
    {
        private ChatEngine mainEngine = new ChatEngine();

        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}



        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// 
        public ChatUser ClientConnect(string username)
        {
            return mainEngine.AddNewChatUser(new ChatUser() { UserName = username });
            //throw new NotImplementedException();
        }

        public List<ChatMessage> GetNewMessages(ChatUser user)
        {
            return mainEngine.GetNewMessages(user);
            //throw new NotImplementedException();
        }

        public void SendNewMessage(ChatMessage newMessage)
        {
            mainEngine.AddNewMessage(newMessage);
            //throw new NotImplementedException();
        }

        public List<ChatUser> GetAllUsers()
        {
            return mainEngine.ConnectedUsers;
            //throw new NotImplementedException();
        }

        public void RemoveUser(ChatUser user)
        {
            mainEngine.RemoveUser(user);
            //throw new NotImplementedException();
        }
    }
}
