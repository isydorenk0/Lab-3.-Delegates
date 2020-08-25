using LabC;
using System.Windows.Forms;

namespace LabCTests
{
    class TestConsoleOutput : IOutput
    {    
        public void DisplayLine(TextBox textbox, string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                textbox.AppendText(text);
            }            
        }
    }
}
