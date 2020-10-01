namespace Lab5
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbOpenaccount = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.AccountName);
            this.groupBox1.Controls.Add(this.llbOpenaccount);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbPin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(137, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // llbOpenaccount
            // 
            this.llbOpenaccount.AutoSize = true;
            this.llbOpenaccount.Location = new System.Drawing.Point(378, 255);
            this.llbOpenaccount.Name = "llbOpenaccount";
            this.llbOpenaccount.Size = new System.Drawing.Size(126, 17);
            this.llbOpenaccount.TabIndex = 5;
            this.llbOpenaccount.TabStop = true;
            this.llbOpenaccount.Text = "Open new account";
            this.llbOpenaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpenaccount_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(229, 131);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(230, 22);
            this.tbPin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pin Code";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(229, 76);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(230, 22);
            this.tbNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account No";
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Location = new System.Drawing.Point(412, 203);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(0, 17);
            this.AccountName.TabIndex = 6;
            this.AccountName.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbOpenaccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccountName;
    }
}

