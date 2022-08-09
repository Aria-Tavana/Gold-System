using System.Windows;
using System.Windows.Input;
using Gold.Logic;
using MaterialDesignThemes.Wpf;

namespace Gold.Windows.General
{
    public partial class Login : Window
    {
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new();
        public Login()
        {
            InitializeComponent();
            //SetupUser();
        }

        private void tbtnTheme_Click(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key == Key.Enter)
                LoginUser();
        }

        private void LoginUser()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                if (Authenticator.Instance.CheckUser(username, password))
                {
                    new User.User_Main().Show();
                    Close();
                }
                else
                    MessageBox.Show("!اطلاعات نامعتبر است", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected void SetupUser()
        {
            Common.Models.User newUser = new()
            {
                Username = "User",
                Password = DataHelper.Instance.HashText("Gold-System@User"),
                UserInfo = new()
                {
                    PhoneNumber = "09120000123",
                    FirstName = "FirstName",
                    LastName = "LastName"
                }
            };
            GetCommand.Instance.AddUser(newUser);
        }
    }
}
