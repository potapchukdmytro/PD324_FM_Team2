namespace FInancingManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSignUp = new Button();
            LoginButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(662, 60);
            buttonSignUp.Margin = new Padding(4, 3, 4, 3);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(121, 37);
            buttonSignUp.TabIndex = 0;
            buttonSignUp.Text = "Реєстрація";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(662, 14);
            LoginButton.Margin = new Padding(4, 5, 4, 5);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(121, 38);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Увійти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(619, 490);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 7;
            label1.Text = "Ваші доходи";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(796, 562);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(LoginButton);
            Controls.Add(buttonSignUp);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignUp;
        private Button LoginButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
