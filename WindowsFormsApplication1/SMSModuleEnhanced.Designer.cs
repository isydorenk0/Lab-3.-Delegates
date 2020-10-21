namespace WindowsFormsApplication1
{
    partial class SMSModuleEnhanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.selectNumber = new System.Windows.Forms.ComboBox();
            this.filterMessage = new System.Windows.Forms.TextBox();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.selectFormatting = new System.Windows.Forms.ComboBox();
            this.showMessages = new System.Windows.Forms.ListView();
            this.apply = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.filterLogic = new System.Windows.Forms.ComboBox();
            this.SMSTimer = new System.Windows.Forms.Timer(this.components);
            this.msgNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.msgNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // selectNumber
            // 
            this.selectNumber.ForeColor = System.Drawing.Color.Silver;
            this.selectNumber.FormattingEnabled = true;
            this.selectNumber.Location = new System.Drawing.Point(12, 39);
            this.selectNumber.Name = "selectNumber";
            this.selectNumber.Size = new System.Drawing.Size(288, 21);
            this.selectNumber.TabIndex = 1;
            this.selectNumber.Text = "Phone number";
            this.selectNumber.Enter += new System.EventHandler(this.selectNumber_Enter);
            this.selectNumber.Leave += new System.EventHandler(this.selectNumber_Leave);
            // 
            // filterMessage
            // 
            this.filterMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterMessage.ForeColor = System.Drawing.Color.Silver;
            this.filterMessage.Location = new System.Drawing.Point(318, 12);
            this.filterMessage.Name = "filterMessage";
            this.filterMessage.Size = new System.Drawing.Size(288, 20);
            this.filterMessage.TabIndex = 2;
            this.filterMessage.Tag = "";
            this.filterMessage.Text = "Message";
            this.filterMessage.Enter += new System.EventHandler(this.filterMessage_Enter);
            this.filterMessage.Leave += new System.EventHandler(this.filterMessage_Leave);
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(318, 39);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(139, 20);
            this.fromDate.TabIndex = 3;
            this.fromDate.Value = new System.DateTime(2010, 1, 1, 15, 27, 0, 0);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(467, 40);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(139, 20);
            this.toDate.TabIndex = 4;
            this.toDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // selectFormatting
            // 
            this.selectFormatting.ForeColor = System.Drawing.Color.Black;
            this.selectFormatting.FormattingEnabled = true;
            this.selectFormatting.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Custom",
            "Lower case",
            "Upper case"});
            this.selectFormatting.Location = new System.Drawing.Point(12, 12);
            this.selectFormatting.Name = "selectFormatting";
            this.selectFormatting.Size = new System.Drawing.Size(288, 21);
            this.selectFormatting.TabIndex = 0;
            // 
            // showMessages
            // 
            this.showMessages.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.showMessages.GridLines = true;
            this.showMessages.Location = new System.Drawing.Point(12, 93);
            this.showMessages.Name = "showMessages";
            this.showMessages.Size = new System.Drawing.Size(594, 401);
            this.showMessages.TabIndex = 5;
            this.showMessages.UseCompatibleStateImageBehavior = false;
            this.showMessages.View = System.Windows.Forms.View.Details;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(531, 66);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 6;
            this.apply.Text = "Apply to all";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(450, 66);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // filterLogic
            // 
            this.filterLogic.FormattingEnabled = true;
            this.filterLogic.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.filterLogic.Location = new System.Drawing.Point(245, 65);
            this.filterLogic.Name = "filterLogic";
            this.filterLogic.Size = new System.Drawing.Size(55, 21);
            this.filterLogic.TabIndex = 8;
            this.filterLogic.Text = "AND";
            // 
            // SMSTimer
            // 
            this.SMSTimer.Enabled = true;
            this.SMSTimer.Interval = 2000;
            this.SMSTimer.Tick += new System.EventHandler(this.SMSTimer_Tick);
            // 
            // msgNumber
            // 
            this.msgNumber.Location = new System.Drawing.Point(101, 66);
            this.msgNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.msgNumber.Name = "msgNumber";
            this.msgNumber.Size = new System.Drawing.Size(32, 20);
            this.msgNumber.TabIndex = 9;
            this.msgNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "No of messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter\'s logic ";
            // 
            // SMSModuleEnhanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msgNumber);
            this.Controls.Add(this.filterLogic);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.showMessages);
            this.Controls.Add(this.selectFormatting);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.filterMessage);
            this.Controls.Add(this.selectNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SMSModuleEnhanced";
            this.Text = "Message Filtering";
            ((System.ComponentModel.ISupportInitialize)(this.msgNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox selectNumber;
        public System.Windows.Forms.TextBox filterMessage;
        public System.Windows.Forms.DateTimePicker fromDate;
        public System.Windows.Forms.DateTimePicker toDate;
        public System.Windows.Forms.ComboBox selectFormatting;
        public System.Windows.Forms.ComboBox filterLogic;
        private System.Windows.Forms.ListView showMessages;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button reset;        
        private System.Windows.Forms.Timer SMSTimer;
        private System.Windows.Forms.NumericUpDown msgNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}