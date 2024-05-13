using FInancingManager.Entities;
using FInancingManager.Models;
using FInancingManager.Services;
using FInancingManager.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInancingManager.Auth
{
    public partial class SignUp : Form
    {
        private readonly UserService userService;
        public SignUp(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUpModel user = new SignUpModel
            {
                Email = textBoxEmail.Text,
                FirstName = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Password = textBoxPassword.Text,
                ConfirmPassword = textBoxConfirmPassword.Text,
                Username = textBoxLogin.Text
            };

            var response = userService.SignUp(user);

            if (response.IsSuccess)
            {
                Close();
            }
            else
            {
                labelError.Text = response.Message;
                labelError.Visible = true;
            }
        }
    }
}
