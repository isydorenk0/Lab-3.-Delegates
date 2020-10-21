using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class SMSStorageTests
    {
        [TestMethod()]
        public void AddMessageTest()
        {
            bool eventWasRaised = false;
            SMSStorage smsStorage = new SMSStorage();           
            Message message = new Message("User", "0001", "Text", Convert.ToDateTime("02-10-2020"));            
            List<Message> messages = new List<Message>();
            messages.Add(message);
            
            smsStorage.MessageAdded  += () => { eventWasRaised = true; };        
            smsStorage.AddMessages(messages);

            Assert.IsTrue(eventWasRaised);
            Assert.AreEqual(1, smsStorage.Storage.Count());
        }

        [TestMethod()]
        public void RemoveMessageTest()
        {
            bool eventWasRaised = false;
            SMSStorage smsStorage = new SMSStorage();
            Message message = new Message("User", "0001", "Text", Convert.ToDateTime("02-10-2020"));
            List<Message> messages = new List<Message>();
            messages.Add(message);
            smsStorage.AddMessages(messages);

            smsStorage.MessageRemoved += () => { eventWasRaised = true; };
            smsStorage.RemoveMessages(messages);
            
            Assert.IsTrue(eventWasRaised);
            Assert.AreEqual(0, smsStorage.Storage.Count());
        }
    }
}