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
            SuspendLayout();
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(366, 191);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(94, 29);
            buttonSignUp.TabIndex = 0;
            buttonSignUp.Text = "Реєстрація";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 470);
            Controls.Add(buttonSignUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSignUp;
    }
}
