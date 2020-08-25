using System;
using System.Windows.Forms;

namespace LabC
{
    public class TextBoxOutput : IOutput
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
