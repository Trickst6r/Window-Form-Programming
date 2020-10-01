namespace Lab3
{
    partial class CustomerForm
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
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.rdBottom = new System.Windows.Forms.RadioButton();
            this.rdTop = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtBirth);
            this.groupBox1.Controls.Add(this.rdBottom);
            this.groupBox1.Controls.Add(this.rdTop);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Infomation";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(198, 123);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(334, 22);
            this.dtBirth.TabIndex = 11;
            // 
            // rdBottom
            // 
            this.rdBottom.AutoSize = true;
            this.rdBottom.Location = new System.Drawing.Point(346, 78);
            this.rdBottom.Name = "rdBottom";
            this.rdBottom.Size = new System.Drawing.Size(103, 21);
            this.rdBottom.TabIndex = 10;
            this.rdBottom.TabStop = true;
            this.rdBottom.Text = "Gay Bottom";
            this.rdBottom.UseVisualStyleBackColor = true;
            // 
            // rdTop
            // 
            this.rdTop.AutoSize = true;
            this.rdTop.Location = new System.Drawing.Point(198, 78);
            this.rdTop.Name = "rdTop";
            this.rdTop.Size = new System.Drawing.Size(84, 21);
            this.rdTop.TabIndex = 9;
            this.rdTop.TabStop = true;
            this.rdTop.Text = "Gay Top";
            this.rdTop.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(290, 224);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 34);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(198, 170);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(334, 22);
            this.tbAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "BirthDay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(198, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(334, 22);
            this.tbName.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 295);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(647, 139);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 461);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.RadioButton rdBottom;
        private System.Windows.Forms.RadioButton rdTop;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        //private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
    }
}