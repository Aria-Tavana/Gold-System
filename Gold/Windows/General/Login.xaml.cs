using Gold.Logic;
using System.Windows;
using System.Windows.Input;

namespace Gold.Windows.General
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            //SetupUser();
        }

        private void winLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                LoginUser();
        }

        private void winLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }

        private bool LoginUser()
        {
            if (Authenticator.Instance.CheckUser(txtUsername.Text, txtPassword.Password) == true)
            {
                new User.User_Main().Show();
                Close();
                return true;
            }
            else
                MessageBox.Show("!اطلاعات نامعتبر است", "", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        private void SetupUser()
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
