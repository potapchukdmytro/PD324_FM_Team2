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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddForm = new System.Windows.Forms.Button();
            this.EditForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(559, 5);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(125, 28);
            this.buttonSignUp.TabIndex = 0;
            this.buttonSignUp.Text = "Реєстрація";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(426, 5);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(125, 28);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Увійти";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(675, 345);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ваші доходи";
            // 
            // AddForm
            // 
            this.AddForm.Location = new System.Drawing.Point(11, 385);
            this.AddForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(157, 28);
            this.AddForm.TabIndex = 8;
            this.AddForm.Text = "Додати";
            this.AddForm.UseVisualStyleBackColor = true;
            this.AddForm.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // EditForm
            // 
            this.EditForm.Location = new System.Drawing.Point(261, 385);
            this.EditForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EditForm.Name = "EditForm";
            this.EditForm.Size = new System.Drawing.Size(153, 28);
            this.EditForm.TabIndex = 9;
            this.EditForm.Text = "Змінити";
            this.EditForm.UseVisualStyleBackColor = true;
            this.EditForm.Click += new System.EventHandler(this.EditForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 385);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 422);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EditForm);
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.buttonSignUp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSignUp;
        private Button LoginButton;
        private DataGridView dataGridView1;
        private Label label1;
        private Button AddForm;
        private Button EditForm;
        private Button button3;
    }
}
