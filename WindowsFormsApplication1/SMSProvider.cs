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
        private void RaisedSMSRecievedEvent(string message)
        {
            SMSRecevied?.Invoke(message);
        }

    }
}
