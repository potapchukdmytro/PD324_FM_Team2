using AutoMapper;
using FInancingManager.Auth;
using FInancingManager.AutoMapper;
using FInancingManager.Services;

namespace FInancingManager
{
    public partial class Form1 : Form
    {
        private readonly UserService userService;
        private readonly Mapper mapper;
        public readonly AppDbContext context;
        public Form1()
        {
            context = new AppDbContext();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserAutomapperProfile>();
            });

            mapper = new Mapper(config);
            userService = new UserService(context, mapper);
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp(userService);
            signUpForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(userService);
            loginForm.ShowDialog();
        }

    }
}
