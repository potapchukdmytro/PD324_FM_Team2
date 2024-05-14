using FInancingManager.Services;
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
    public partial class LoginForm : Form
    {
        private readonly UserService userService;
        public LoginForm(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            var user = userService.GetByLogin(login);

            if (user != null && user.Password == password)
            {
                //перехід на головну сторінку
            }
            else
            {
                ErrorLable.Text = "Невірний логін або пароль";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
