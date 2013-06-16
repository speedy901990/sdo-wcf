namespace SubClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbPeselSet = new System.Windows.Forms.TextBox();
            this.tbEmailSet = new System.Windows.Forms.TextBox();
            this.tbSurnameSet = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.PeselButton = new System.Windows.Forms.Button();
            this.tbSurnameGet = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.getBySurnameButton = new System.Windows.Forms.Button();
            this.getByEmailButton = new System.Windows.Forms.Button();
            this.getByIDButton = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentCheckBox = new System.Windows.Forms.CheckBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Local Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPeselSet
            // 
            this.tbPeselSet.Location = new System.Drawing.Point(78, 93);
            this.tbPeselSet.Name = "tbPeselSet";
            this.tbPeselSet.Size = new System.Drawing.Size(100, 20);
            this.tbPeselSet.TabIndex = 1;
            this.tbPeselSet.Text = "PESEL";
            // 
            // tbEmailSet
            // 
            this.tbEmailSet.Location = new System.Drawing.Point(78, 67);
            this.tbEmailSet.Name = "tbEmailSet";
            this.tbEmailSet.Size = new System.Drawing.Size(100, 20);
            this.tbEmailSet.TabIndex = 2;
            // 
            // tbSurnameSet
            // 
            this.tbSurnameSet.Location = new System.Drawing.Point(78, 41);
            this.tbSurnameSet.Name = "tbSurnameSet";
            this.tbSurnameSet.Size = new System.Drawing.Size(100, 20);
            this.tbSurnameSet.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(78, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // PeselButton
            // 
            this.PeselButton.Location = new System.Drawing.Point(535, 12);
            this.PeselButton.Name = "PeselButton";
            this.PeselButton.Size = new System.Drawing.Size(133, 26);
            this.PeselButton.TabIndex = 27;
            this.PeselButton.Text = "Get By PESEL";
            this.PeselButton.UseVisualStyleBackColor = true;
            this.PeselButton.Click += new System.EventHandler(this.PeselButton_Click);
            // 
            // tbSurnameGet
            // 
            this.tbSurnameGet.Location = new System.Drawing.Point(312, 77);
            this.tbSurnameGet.Name = "tbSurnameGet";
            this.tbSurnameGet.Size = new System.Drawing.Size(85, 20);
            this.tbSurnameGet.TabIndex = 25;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(312, 47);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(85, 20);
            this.tbEmail.TabIndex = 24;
            // 
            // getBySurnameButton
            // 
            this.getBySurnameButton.Location = new System.Drawing.Point(403, 76);
            this.getBySurnameButton.Name = "getBySurnameButton";
            this.getBySurnameButton.Size = new System.Drawing.Size(133, 26);
            this.getBySurnameButton.TabIndex = 23;
            this.getBySurnameButton.Text = "Get Person By Surname";
            this.getBySurnameButton.UseVisualStyleBackColor = true;
            this.getBySurnameButton.Click += new System.EventHandler(this.getBySurnameButton_Click);
            // 
            // getByEmailButton
            // 
            this.getByEmailButton.Location = new System.Drawing.Point(403, 44);
            this.getByEmailButton.Name = "getByEmailButton";
            this.getByEmailButton.Size = new System.Drawing.Size(133, 26);
            this.getByEmailButton.TabIndex = 22;
            this.getByEmailButton.Text = "Get Person By Email";
            this.getByEmailButton.UseVisualStyleBackColor = true;
            this.getByEmailButton.Click += new System.EventHandler(this.getByEmailButton_Click);
            // 
            // getByIDButton
            // 
            this.getByIDButton.Location = new System.Drawing.Point(403, 12);
            this.getByIDButton.Name = "getByIDButton";
            this.getByIDButton.Size = new System.Drawing.Size(133, 26);
            this.getByIDButton.TabIndex = 21;
            this.getByIDButton.Text = "Get Person By ID";
            this.getByIDButton.UseVisualStyleBackColor = true;
            this.getByIDButton.Click += new System.EventHandler(this.getByIDButton_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(312, 15);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(85, 20);
            this.tbID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(78, 116);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentCheckBox.Size = new System.Drawing.Size(15, 14);
            this.studentCheckBox.TabIndex = 32;
            this.studentCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.studentCheckBox.UseVisualStyleBackColor = true;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(78, 138);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 33;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(78, 165);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Weight";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 566);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.studentCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeselButton);
            this.Controls.Add(this.tbSurnameGet);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.getBySurnameButton);
            this.Controls.Add(this.getByEmailButton);
            this.Controls.Add(this.getByIDButton);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurnameSet);
            this.Controls.Add(this.tbEmailSet);
            this.Controls.Add(this.tbPeselSet);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Using sdo-wcf2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPeselSet;
        private System.Windows.Forms.TextBox tbEmailSet;
        private System.Windows.Forms.TextBox tbSurnameSet;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button PeselButton;
        private System.Windows.Forms.TextBox tbSurnameGet;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button getBySurnameButton;
        private System.Windows.Forms.Button getByEmailButton;
        private System.Windows.Forms.Button getByIDButton;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox studentCheckBox;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

