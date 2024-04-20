namespace Fitnes
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            buttonFirstName = new Button();
            buttonName = new Button();
            buttonPhoneNumber = new Button();
            buttonPatronymic = new Button();
            buttonBirthDate = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(132, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonFirstName
            // 
            buttonFirstName.Location = new Point(25, 32);
            buttonFirstName.Name = "buttonFirstName";
            buttonFirstName.Size = new Size(75, 23);
            buttonFirstName.TabIndex = 3;
            buttonFirstName.Text = "FirstName";
            buttonFirstName.UseVisualStyleBackColor = true;
            // 
            // buttonName
            // 
            buttonName.Location = new Point(25, 71);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(75, 23);
            buttonName.TabIndex = 4;
            buttonName.Text = "Name";
            buttonName.UseVisualStyleBackColor = true;
            // 
            // buttonPhoneNumber
            // 
            buttonPhoneNumber.Location = new Point(25, 148);
            buttonPhoneNumber.Name = "buttonPhoneNumber";
            buttonPhoneNumber.Size = new Size(75, 23);
            buttonPhoneNumber.TabIndex = 6;
            buttonPhoneNumber.Text = "PhoneNumber";
            buttonPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // buttonPatronymic
            // 
            buttonPatronymic.Location = new Point(25, 109);
            buttonPatronymic.Name = "buttonPatronymic";
            buttonPatronymic.Size = new Size(75, 23);
            buttonPatronymic.TabIndex = 5;
            buttonPatronymic.Text = "Patronymic";
            buttonPatronymic.UseVisualStyleBackColor = true;
            // 
            // buttonBirthDate
            // 
            buttonBirthDate.Location = new Point(25, 190);
            buttonBirthDate.Name = "buttonBirthDate";
            buttonBirthDate.Size = new Size(75, 23);
            buttonBirthDate.TabIndex = 8;
            buttonBirthDate.Text = "BirthDate";
            buttonBirthDate.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 286);
            Controls.Add(buttonBirthDate);
            Controls.Add(buttonPhoneNumber);
            Controls.Add(buttonPatronymic);
            Controls.Add(buttonName);
            Controls.Add(buttonFirstName);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button buttonFirstName;
        private Button buttonName;
        private Button buttonPhoneNumber;
        private Button buttonPatronymic;
        private Button buttonBirthDate;
    }
}