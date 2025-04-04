using BussinessObject.Models;
using Respository;
using Microsoft.Win32;
using Respository;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Security.Cryptography;
using BussinessObject;

namespace PRN221_Project_SE1749
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IAccountRespository accountRespository;
        
        public MainWindow()
        {
            InitializeComponent();
            accountRespository = new AccountRespository();
            // Đọc thông tin từ Registry nếu tồn tại
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\YourAppName");
            if (key != null)
            {
                txtUsername.Text = key.GetValue("Username")?.ToString() ?? string.Empty;
                txtPassword.Password = key.GetValue("Password")?.ToString() ?? string.Empty;
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            User account = accountRespository.GetAccount(txtUsername.Text, HashPassword(txtPassword.Password));
            if (account != null && account.RoleId == 0 && account.Active==true)
            {
                txtErrorMessage.Visibility = Visibility.Collapsed;

                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\YourAppName");
                key.SetValue("Username", txtUsername.Text);
                key.SetValue("Password", (txtPassword.Password));
                key.Close();

                // Lưu userId vào CurrentUserSession
                CurrentUserSession.UserId = account.UserId;
                CurrentUserSession.UserName = account.UserName;

                this.Hide();
                AccountManager accountManager = new AccountManager();
                accountManager.ShowDialog();
            }
            else
            {
                txtErrorMessage.Text = "Incorrect username or password.";
                txtErrorMessage.Visibility = Visibility.Visible;
            }
            
        }
    }
}