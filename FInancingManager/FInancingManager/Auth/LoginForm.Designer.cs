namespace FInancingManager.Auth
{
    partial class LoginForm
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
            ErrorLable = new Label();
            LoginButton = new Button();
            label2 = new Label();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            CloseButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ErrorLable
            // 
            ErrorLable.AutoSize = true;
            ErrorLable.BackColor = SystemColors.Control;
            ErrorLable.ForeColor = Color.Red;
            ErrorLable.Location = new Point(48, 236);
            ErrorLable.Name = "ErrorLable";
            ErrorLable.Size = new Size(73, 20);
            ErrorLable.TabIndex = 12;
            ErrorLable.Text = "Помилки";
            ErrorLable.Visible = false;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(48, 275);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(97, 31);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "Увійти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 156);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 77);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(48, 187);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(250, 27);
            PasswordTextBox.TabIndex = 8;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(48, 108);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(250, 27);
            LoginTextBox.TabIndex = 7;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(201, 275);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(97, 31);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "скасувати";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 332);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 15;
            label4.Text = "Немає акаунту";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(201, 332);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 16;
            label5.Text = "створіть";
            label5.Click += label5_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 380);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CloseButton);
            Controls.Add(ErrorLable);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorLable;
        private Button LoginButton;
        private Label label2;
        private Label label1;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Button CloseButton;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}