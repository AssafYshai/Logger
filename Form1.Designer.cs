namespace Logger
{
    partial class Form1
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
            this.txtLogMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDB = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbEventLog = new System.Windows.Forms.RadioButton();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtLogFilePath = new System.Windows.Forms.TextBox();
            this.comboEventType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLogMessage
            // 
            this.txtLogMessage.Location = new System.Drawing.Point(230, 37);
            this.txtLogMessage.Name = "txtLogMessage";
            this.txtLogMessage.Size = new System.Drawing.Size(312, 20);
            this.txtLogMessage.TabIndex = 0;
            this.txtLogMessage.Text = "Message To Event Log.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // rbDB
            // 
            this.rbDB.AutoSize = true;
            this.rbDB.Location = new System.Drawing.Point(32, 145);
            this.rbDB.Name = "rbDB";
            this.rbDB.Size = new System.Drawing.Size(71, 17);
            this.rbDB.TabIndex = 2;
            this.rbDB.Text = "Database";
            this.rbDB.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(32, 122);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(59, 17);
            this.rbFile.TabIndex = 3;
            this.rbFile.Text = "File  -->";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // rbEventLog
            // 
            this.rbEventLog.AutoSize = true;
            this.rbEventLog.Checked = true;
            this.rbEventLog.Location = new System.Drawing.Point(32, 99);
            this.rbEventLog.Name = "rbEventLog";
            this.rbEventLog.Size = new System.Drawing.Size(74, 17);
            this.rbEventLog.TabIndex = 4;
            this.rbEventLog.TabStop = true;
            this.rbEventLog.Text = "Event Log";
            this.rbEventLog.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(32, 181);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(471, 113);
            this.txtComments.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(428, 152);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogFilePath
            // 
            this.txtLogFilePath.Location = new System.Drawing.Point(105, 121);
            this.txtLogFilePath.Name = "txtLogFilePath";
            this.txtLogFilePath.Size = new System.Drawing.Size(398, 20);
            this.txtLogFilePath.TabIndex = 7;
            // 
            // comboEventType
            // 
            this.comboEventType.FormattingEnabled = true;
            this.comboEventType.Items.AddRange(new object[] {
            "Error",
            "Information",
            "Warning"});
            this.comboEventType.Location = new System.Drawing.Point(32, 37);
            this.comboEventType.Name = "comboEventType";
            this.comboEventType.Size = new System.Drawing.Size(135, 21);
            this.comboEventType.TabIndex = 8;
            this.comboEventType.Text = "Choose Event Type...";
            this.comboEventType.SelectedIndexChanged += new System.EventHandler(this.comboEventType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 313);
            this.Controls.Add(this.comboEventType);
            this.Controls.Add(this.txtLogFilePath);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.rbEventLog);
            this.Controls.Add(this.rbFile);
            this.Controls.Add(this.rbDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogMessage);
            this.Name = "Form1";
            this.Text = "Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDB;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbEventLog;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtLogFilePath;
        private System.Windows.Forms.ComboBox comboEventType;
    }
}

