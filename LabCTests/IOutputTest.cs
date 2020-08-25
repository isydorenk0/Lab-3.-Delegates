using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using LabCTests;

namespace LabC.Tests
{
    [TestClass()]
    public class IOuputTest
    {
        [TestMethod()]
        public void OutputDisplay_iPhone()
        {
            TestConsoleOutput output = new TestConsoleOutput();
            TextBox textBox = new TextBox();
            string expectedOutput = "iPhone";

            output.DisplayLine(textBox, expectedOutput);

            Assert.AreEqual(expectedOutput, textBox.Text);
        }
        [TestMethod()]
        public void OutputDisplay_Null()
        {
            TestConsoleOutput output = new TestConsoleOutput();
            TextBox textBox = new TextBox();
            string expectedOutput = "";

            output.DisplayLine(textBox, null);

            Assert.AreEqual(expectedOutput, textBox.Text);
        }
    }
}