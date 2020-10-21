using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SMSStorage
    {
        public delegate void MessageHandler();
        public event MessageHandler MessageAdded;
        public event MessageHandler MessageRemoved;

        private static List<Message> vStorage = new List<Message>();
        public SMSStorage()
        {
            Storage = new List<Message>();
        }

        public List<Message> Storage
        {
            get { return vStorage; }
            set { vStorage = value; }
        }

        public void AddMessages(List<Message> messages)
        {
            foreach (var message in messages)
            {
                Storage.Add(message);
                MessageAdded?.Invoke();
            }
        }
        public void RemoveMessages(List<Message> messages)
        {
            foreach (var message in messages)
            {
                Storage.Remove(message);
                MessageRemoved?.Invoke();
            }
        }
    }
}
