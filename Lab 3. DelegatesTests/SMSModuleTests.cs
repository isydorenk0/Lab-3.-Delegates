using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Test
{
    [TestClass()]
    public class SMSModuleEnhancedTests
    {
        [TestMethod()]
        public void FormatterDel_StartWithDateTime()
        {
            string message = "message";
            SMSModuleEnhanced myModule = new SMSModuleEnhanced();
            FormatDelegate FormatterDel = myModule.GetFormatter("Start with DateTime");
            var expresult = DateTime.Now.ToString().Length + 2;

            var txtresult = FormatterDel(message);
            var actresult = txtresult.IndexOf("message");

            Assert.AreEqual(expresult, actresult);
        }

        [TestMethod()]
        public void FormatterDel_ToUpper()
        {
            string message = "message";
            SMSModuleEnhanced myModule = new SMSModuleEnhanced();
            FormatDelegate FormatterDel = myModule.GetFormatter("Upper case");
            var expresult = message.ToUpper() + "\r\n";

            var actresult = FormatterDel(message);

            Assert.AreEqual(expresult, actresult);
        }

        [TestMethod()]
        public void FormatterDel_Default()
        {
            string message = "message";
            SMSModuleEnhanced myModule = new SMSModuleEnhanced();
            FormatDelegate FormatterDel = myModule.GetFormatter("default");
            var expresult = message + "\r\n";

            var actresult = FormatterDel(message);

            Assert.AreEqual(expresult, actresult);
        }
    }
}