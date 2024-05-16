namespace FInancingManager.Auth
{
    partial class SignUp
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            buttonSignUp = new Button();
            buttonCancel = new Button();
            labelError = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 189);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "User name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 133);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 77);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 4;
            label5.Text = "Last name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 245);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 301);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 6;
            label2.Text = "Repeat password";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(41, 47);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(236, 27);
            textBoxName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(41, 103);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(236, 27);
            textBoxLastName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(41, 159);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(236, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(41, 215);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(236, 27);
            textBoxLogin.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(41, 271);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(236, 27);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(41, 327);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(236, 27);
            textBoxConfirmPassword.TabIndex = 12;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(41, 402);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(102, 36);
            buttonSignUp.TabIndex = 13;
            buttonSignUp.Text = "Ок";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(175, 402);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(102, 36);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(41, 368);
            labelError.Name = "labelError";
            labelError.Size = new Size(141, 20);
            labelError.TabIndex = 15;
            labelError.Text = "Виводить помилки";
            labelError.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(77, 453);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 16;
            label7.Text = "Уже є акаунт";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(194, 453);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 17;
            label8.Text = "увійдіть";
            label8.Click += label8_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 504);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(labelError);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private Button buttonSignUp;
        private Button buttonCancel;
        private Label labelError;
        private Label label7;
        private Label label8;
    }
}