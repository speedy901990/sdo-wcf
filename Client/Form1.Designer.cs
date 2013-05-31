namespace Client
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.getByIDButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.studentCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getByEmailButton = new System.Windows.Forms.Button();
            this.getBySurnameButton = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(213, 17);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(85, 20);
            this.tbID.TabIndex = 0;
            // 
            // getByIDButton
            // 
            this.getByIDButton.Location = new System.Drawing.Point(304, 15);
            this.getByIDButton.Name = "getByIDButton";
            this.getByIDButton.Size = new System.Drawing.Size(133, 23);
            this.getByIDButton.TabIndex = 1;
            this.getByIDButton.Text = "Get Person By ID";
            this.getByIDButton.UseVisualStyleBackColor = true;
            this.getByIDButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Database Entries Barfout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(90, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(90, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(90, 38);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(90, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(90, 90);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentCheckBox.Size = new System.Drawing.Size(15, 14);
            this.studentCheckBox.TabIndex = 7;
            this.studentCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.studentCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student";
            // 
            // getByEmailButton
            // 
            this.getByEmailButton.Location = new System.Drawing.Point(304, 45);
            this.getByEmailButton.Name = "getByEmailButton";
            this.getByEmailButton.Size = new System.Drawing.Size(133, 23);
            this.getByEmailButton.TabIndex = 12;
            this.getByEmailButton.Text = "Get Person By Email";
            this.getByEmailButton.UseVisualStyleBackColor = true;
            this.getByEmailButton.Click += new System.EventHandler(this.getByEmailButton_Click);
            // 
            // getBySurnameButton
            // 
            this.getBySurnameButton.Location = new System.Drawing.Point(304, 75);
            this.getBySurnameButton.Name = "getBySurnameButton";
            this.getBySurnameButton.Size = new System.Drawing.Size(133, 23);
            this.getBySurnameButton.TabIndex = 13;
            this.getBySurnameButton.Text = "Get Person By Surname";
            this.getBySurnameButton.UseVisualStyleBackColor = true;
            this.getBySurnameButton.Click += new System.EventHandler(this.getBySurnameButton_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(213, 47);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(85, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(213, 77);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(85, 20);
            this.tbSurname.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 301);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.getBySurnameButton);
            this.Controls.Add(this.getByEmailButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getByIDButton);
            this.Controls.Add(this.tbID);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button getByIDButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox studentCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getByEmailButton;
        private System.Windows.Forms.Button getBySurnameButton;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSurname;
    }
}

