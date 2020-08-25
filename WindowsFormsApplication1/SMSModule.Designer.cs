namespace WindowsFormsApplication1
{
    partial class SMSModule
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
            this.SMSFormat = new System.Windows.Forms.ComboBox();
            this.SMSShow = new System.Windows.Forms.RichTextBox();
            this.SMSTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SMSFormat
            // 
            this.SMSFormat.FormattingEnabled = true;
            this.SMSFormat.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Custom",
            "Lower case",
            "Upper case"});
            this.SMSFormat.Location = new System.Drawing.Point(13, 13);
            this.SMSFormat.Name = "SMSFormat";
            this.SMSFormat.Size = new System.Drawing.Size(274, 21);
            this.SMSFormat.TabIndex = 0;
            this.SMSFormat.SelectedIndexChanged += new System.EventHandler(this.SMSFormat_SelectedIndexChanged);
            // 
            // SMSShow
            // 
            this.SMSShow.Location = new System.Drawing.Point(13, 40);
            this.SMSShow.Name = "SMSShow";
            this.SMSShow.Size = new System.Drawing.Size(516, 397);
            this.SMSShow.TabIndex = 1;
            this.SMSShow.Text = "";
            // 
            // SMSTimer
            // 
            this.SMSTimer.Enabled = true;
            this.SMSTimer.Interval = 1000;
            this.SMSTimer.Tick += new System.EventHandler(this.SMSTimer_Tick);
            // 
            // SMSModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 449);
            this.Controls.Add(this.SMSShow);
            this.Controls.Add(this.SMSFormat);
            this.MaximizeBox = false;
            this.Name = "SMSModule";
            this.Text = "SMSModule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SMSFormat;
        private System.Windows.Forms.RichTextBox SMSShow;
        private System.Windows.Forms.Timer SMSTimer;
    }
}

