using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class SMSModuleEnhanced : Form
    {
        const string defNum = "Phone number";
        const string defForm = "Select formatting";
        const string defMsg = "Message";
        public int skip = 0;
        public FormatDelegate FormatterDel;
        public SMSStorage SMSStorage = new SMSStorage();

        public SMSModuleEnhanced()
        {
            InitializeComponent();
            selectFormatting.SelectedIndex = 0;
            InitListView.InitColumns(showMessages);
        }

        private void SMSTimer_Tick(object sender, EventArgs e)
        {
            if (msgNumber.Value != 0)
            {
                var take = Convert.ToInt32(msgNumber.Value);                
                var messages = ReadSMS(take, skip);
                if (messages.Count != 0)
                {
                    skip += take;
                    SetDropDowns(messages);
                    SMSStorage.AddMessages(messages);
                    ShowMessages(messages);
                }
            }
        }
        public FormatDelegate GetFormatter(string selectedFormat)
        {
            switch (selectedFormat)
            {
                case "Start with DateTime":
                    FormatterDel = SMSFormat.FormatTimeStarts;
                    break;
                case "End with DateTime":
                    FormatterDel = SMSFormat.FormatTimeEnds;
                    break;
                case "Upper case":
                    FormatterDel = SMSFormat.FormatUpperCase;
                    break;
                case "Lower case":
                    FormatterDel = SMSFormat.FormatLowerCase;
                    break;
                case "Custom":
                    FormatterDel = SMSFormat.FormatCustom;
                    break;
                default:
                    FormatterDel = SMSFormat.FormatDefault;
                    break;
            }
            return FormatterDel;
        }
        public void OnSMSRecieved(ListViewItem messageItem)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSProvider.SMSRecievedDelegate(OnSMSRecieved), messageItem);
            }
            showMessages.Items.Add(messageItem);
        }
        public List<Message> ReadSMS(int count, int skip)
        {
            return ProcessFile.ProcessMessages("Messages.csv", count, skip);
        }
        public void ShowMessages(List<Message> messages)
        {
            var selectedNumber = selectNumber?.SelectedItem?.ToString();
            var minDate = fromDate.Value;
            var maxDate = toDate.Value;
            var filterMsg = filterMessage?.Text?.ToString();
            var filterLgc = filterLogic?.Text?.ToString();
            FiltersFlds filterFlds = new FiltersFlds(selectedNumber, minDate, maxDate, filterMsg, filterLgc);
            Filters filter = new Filters();
            var query = filter.GetFilter(filterFlds, messages);

            var selectedFormat = selectFormatting.SelectedItem.ToString();
            FormatterDel = GetFormatter(selectedFormat);
            foreach (var message in query)
            {
                var messageItem = new ListViewItem(new[] { message.User, message.Number, FormatterDel(message.Text), message.ReceivingTime.ToString() });
                OnSMSRecieved(messageItem);
            }
        }

        #region ButtonsActions
        private void apply_Click(object sender, EventArgs e)
        {
            showMessages.Items.Clear();
            var messages = SMSStorage.Storage;
            ShowMessages(messages);
        }
        private void reset_Click(object sender, EventArgs e)
        {
            showMessages.Items.Clear();
            setDefaultField(selectNumber, defNum);
            filterMessage.Text = defMsg;
            filterMessage.ForeColor = Color.Silver;
            selectFormatting.SelectedItem = "None";
            var messages = SMSStorage.Storage;            
            ShowMessages(messages);
        }
        #endregion

        #region FieldsActions
        public void SetDropDowns(List<Message> messages)
        {
            var numbers = messages.Select(nmbrs => nmbrs.Number)
                                .Distinct();
            foreach (var number in numbers)
            {
                if (!selectNumber.Items.Contains(number))
                {
                    selectNumber.Items.Add(number);
                }
            }

            var minDate = messages.Select(mindate => mindate.ReceivingTime)
                .Min();
            if (fromDate.MinDate > minDate)
            {
                fromDate.MinDate = minDate;
                fromDate.Value = minDate;
            }
            var maxDate = messages.Select(mindate => mindate.ReceivingTime)
                            .Max();
            if (toDate.MaxDate < maxDate)
            {
                toDate.MaxDate = maxDate;
                toDate.Value = maxDate;
            }
        }
        private void filterMessage_Enter(object sender, EventArgs e)
        {
            if (filterMessage.Text == defMsg && filterMessage.ForeColor == Color.Silver)
            {
                filterMessage.Text = "";
                filterMessage.ForeColor = Color.Black;
            }
        }

        private void filterMessage_Leave(object sender, EventArgs e)
        {
            if (filterMessage.Text.Length == 0)
            {
                filterMessage.Text = defMsg;
                filterMessage.ForeColor = Color.Silver;
            }
        }

        private void selectNumber_Enter(object sender, EventArgs e)
        {
            EnterField(selectNumber, defNum);
        }
        private void selectNumber_Leave(object sender, EventArgs e)
        {
            LeaveField(selectNumber, defNum);
        }
        private void EnterField(ComboBox combobox, string text)
        {
            if (combobox.Text == text)
            {
                combobox.Text = "";
                combobox.ForeColor = Color.Black;
            }
        }
        private void LeaveField(ComboBox combobox, string text)
        {
            if (combobox.Text.Length == 0)
            {
                combobox.Text = text;
                combobox.ForeColor = Color.Silver;
            }
        }
        private void setDefaultField(ComboBox combobox, string deftxt)
        {
            combobox.Text = "";
            combobox.SelectedItem = null;
            LeaveField(combobox, deftxt);
        }
        #endregion
    }
}
