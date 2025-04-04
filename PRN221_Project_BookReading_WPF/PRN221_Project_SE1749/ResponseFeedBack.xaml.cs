using Respository;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for ResponseFeedBack.xaml
    /// </summary>
    public partial class ResponseFeedBack : Window
    {
        private IFeedBackRespository feedBackRespository;

        public ResponseFeedBack()
        {
            InitializeComponent();
            feedBackRespository = new FeedBackRepository();

            LoadResponFeedBack();
        }
        public void LoadResponFeedBack()
        {
            try
            {
                var feedBack = feedBackRespository.GetAllResponseFeedBack();
                dgResponseList.ItemsSource = feedBack;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadFeedBack ", ex.Message);
            }
        }
        private void SearchResponse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchText = txtSearchResponse.Text.Trim().ToLower();

                var feedBack = feedBackRespository.GetResponseFeedBackBySearch(searchText);
                dgResponseList.ItemsSource = feedBack;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SearchResponse_Click ", ex.Message);
            }
        }

        private void ManageAccountsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog();
        }

        private void SendFeedBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FeedBackManager feedBackManager = new FeedBackManager();
            feedBackManager.ShowDialog();
        }

        private void ManageBooksButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookManager bookManager = new BookManager();
            bookManager.ShowDialog();
        }
    }
}
