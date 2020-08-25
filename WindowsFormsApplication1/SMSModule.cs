using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SMSModule : Form
    {
        private int timerTicks;
        public FormatDelegate FormatterDel;
        public SMSModule()
        {
            InitializeComponent();
            SMSFormat.SelectedIndex = 0;
        }

        public void SMSFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SMSShow.Clear();
            timerTicks = 0;
        }

        private void SMSTimer_Tick(object sender, EventArgs e)
        {
            var selectedFormat = SMSFormat.SelectedItem.ToString();
            FormatterDel = GetFormatter(selectedFormat);
            timerTicks++;
            var message = "Message #" + timerTicks.ToString() + " received!";
            OnSMSRecieved(message);
        }

        public void OnSMSRecieved(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSProvider.SMSRecievedDelegate(OnSMSRecieved), message);                
            }            
            SMSShow.AppendText(FormatterDel(message));
        }

        public FormatDelegate GetFormatter(string selectedFormat)
        {            
            switch (selectedFormat)
            {
                case "Start with DateTime":
                    FormatterDel = FormatMessage.FormatTimeStarts;
                    break;
                case "End with DateTime":
                    FormatterDel = FormatMessage.FormatTimeEnds;
                    break;
                case "Upper case":
                    FormatterDel = FormatMessage.FormatUpperCase; 
                    break;
                case "Lower case":
                    FormatterDel = FormatMessage.FormatLowerCase;
                    break;
                case "Custom":
                    FormatterDel = FormatMessage.FormatCustom;
                    break;
                default:
                    FormatterDel = FormatMessage.FormatDefault;
                    break;
            }
            return FormatterDel;
        }
    }
}

