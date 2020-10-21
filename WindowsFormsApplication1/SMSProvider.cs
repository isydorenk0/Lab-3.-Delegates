using System.Windows.Forms;

namespace SMSProvider
{
    public class SMSProvider
    {
        public delegate void SMSRecievedDelegate(ListViewItem message);
        public event SMSRecievedDelegate SMSRecieved;
        private void RaisedSMSRecievedEvent(ListViewItem messageItem)
        {
            SMSRecieved?.Invoke(messageItem);
        }        
    }
}

