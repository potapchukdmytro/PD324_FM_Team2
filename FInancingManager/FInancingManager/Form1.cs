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
        private readonly CostRepository costRepository;

        public Form1()
        {
            context = new AppDbContext();
            costRepository = new CostRepository(context); 

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
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                LoadCosts(); 
            }
        }


        private void AddForm_Click(object sender, EventArgs e)
        {
            AddForm AddForm= new AddForm();
            AddForm.ShowDialog();
        }

        private void EditForm_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm();
            EditForm.ShowDialog();
        }

        private void LoadCosts()
        {
            var costs = costRepository.GetAllCosts();
            dataGridView.DataSource = costs.ToList();
        }

    }
}
