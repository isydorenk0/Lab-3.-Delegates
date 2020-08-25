using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMSProvider    
{
    public class SMSProvider
    {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSRecevied;

        public void RecieveSMS(string format)
        {
            string message = "Message {} received";
            for (int i = 0; i < 10; i++)
            {             
                RaisedSMSRecievedEvent(message);
            }
        }
        private void RaisedSMSRecievedEvent(string message)
        {
            var handler = SMSRecevied;
            if (handler != null)
            {
                handler(message);
            }
        }

    }
}
