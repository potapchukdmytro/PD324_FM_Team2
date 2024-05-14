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
            SuspendLayout();
            // 
            // ErrorLable
            // 
            ErrorLable.AutoSize = true;
            ErrorLable.BackColor = SystemColors.Control;
            ErrorLable.ForeColor = Color.Red;
            ErrorLable.Location = new Point(42, 177);
            ErrorLable.Name = "ErrorLable";
            ErrorLable.Size = new Size(59, 15);
            ErrorLable.TabIndex = 12;
            ErrorLable.Text = "Помилки";
            ErrorLable.Visible = false;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(42, 206);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(85, 23);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "Увійти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 117);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 10;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 58);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 9;
            label1.Text = "Логін";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(42, 140);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(219, 23);
            PasswordTextBox.TabIndex = 8;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(42, 81);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(219, 23);
            LoginTextBox.TabIndex = 7;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(176, 206);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(85, 23);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "скасувати";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 330);
            Controls.Add(CloseButton);
            Controls.Add(ErrorLable);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
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
    }
}