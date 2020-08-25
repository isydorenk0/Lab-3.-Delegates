namespace LabC
{
    partial class ShowPlaybackForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Apply = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.headSetTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Playback = new System.Windows.Forms.ListBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headSetTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(227, 130);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(309, 130);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // headSetTypesBindingSource
            // 
            this.headSetTypesBindingSource.DataSource = typeof(Common.GetPlayableType.HeadSetTypes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select playback component";
            // 
            // Playback
            // 
            this.Playback.FormattingEnabled = true;
            this.Playback.Location = new System.Drawing.Point(12, 29);
            this.Playback.Name = "Playback";
            this.Playback.Size = new System.Drawing.Size(371, 95);
            this.Playback.TabIndex = 5;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(12, 172);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(371, 80);
            this.textOutput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // ShowPlaybackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.Playback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Apply);
            this.MaximizeBox = false;
            this.Name = "ShowPlaybackForm";
            this.Text = "Playback";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headSetTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.BindingSource headSetTypesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Playback;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Label label2;
    }
}

