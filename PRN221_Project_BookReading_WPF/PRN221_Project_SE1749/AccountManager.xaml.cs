using BussinessObject.Models;
using Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRN221_Project_SE1749
{
    /// <summary>
    /// Interaction logic for AccountManager.xaml
    /// </summary>
    public partial class AccountManager : Window
    {
        private IAccountRespository accountRespository;

        public AccountManager()
        {
            InitializeComponent();
            accountRespository = new AccountRespository();
            LoadRoleName();
            LoadActive();
            LoadAccounts();

        }
        private void LoadRoleName()
        {
            try
            {
                var roleName = accountRespository.GetAllRoleName();
                cbxRoleName.ItemsSource = roleName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadActive()
        {
            try
            {
                List<string> actives= new List<string>{
                    "True",
                    "False"
                };
                cbxActive.ItemsSource = actives;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void LoadAccounts()
        {
            try
            {
                var users = accountRespository.GetAllAccounts();
                lvDisplay.ItemsSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lvDisplay.SelectedItem is User selectedAccount)
                {
                    int roleName = selectedAccount.RoleId ;
                    string active = cbxActive.SelectedValue.ToString();
                    if (roleName ==0)
                    {
                        MessageBox.Show("Cannot update Admin accounts.", "Note", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    selectedAccount.RoleId = accountRespository.GetRoleIdByRoleName(cbxRoleName.SelectedValue.ToString());
                    selectedAccount.Active = cbxActive.SelectedValue.ToString() == "True"?true:false;
                    accountRespository.updateAccount(selectedAccount);
                    MessageBox.Show("Account updated successfully.", "Note", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadAccounts();
                }
                else
                {
                    MessageBox.Show("Please select an account to update.", "Note", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(searchText))
                {
                   var users= accountRespository.GetUserBySearch(searchText);
                   lvDisplay.ItemsSource = users;
                }
                else
                {
                    MessageBox.Show("None Users.", "Note", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void LoadAccountButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAccounts();
        }
        private void BookManagerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookManager bookManager = new BookManager();
            bookManager.ShowDialog();
        }

        private void lv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvDisplay.SelectedItem is User selectedAccount)
            {
                txtUsername.Text = selectedAccount.UserName; 
                txtEmail.Text = selectedAccount.Email; 
                cbxRoleName.SelectedValue = selectedAccount.Role.RoleName.ToString(); 
                cbxActive.SelectedValue = selectedAccount.Active==true?"True":"False"; 
            }
        }

        private void SendFeedBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FeedBackManager feedBackManager = new FeedBackManager();
            feedBackManager.ShowDialog();
        }
    }
}
