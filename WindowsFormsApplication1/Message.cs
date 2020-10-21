using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Message
    {
        public Message(string user, string number, string text, DateTime received)
        {
            User = user;
            Number = number;
            Text = text;
            ReceivingTime = received;
        }

        private string vUser;
        public string User
        {
            get { return vUser; }
            set { vUser = value; }
        }
        private string vNumber;

        public string Number
        {
            get { return vNumber; }
            set { vNumber = value; }
        }

        private string vText;
        public string Text
        {
            get { return vText; }
            set { vText = value; }
        }

        private DateTime vReceivingTime;
        public DateTime ReceivingTime
        {
            get { return vReceivingTime; }
            set { vReceivingTime = value; }
        }
    }
}
