using BussinessObject.Models;
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
using System.Xml.Linq;

namespace PRN221_Project_SE1749
{
    /// <summary>
    /// Interaction logic for FeedBackManager.xaml
    /// </summary>
    public partial class FeedBackManager : Window
    {
        private IFeedBackRespository feedBackRespository;
        private IAccountRespository accountRespository;
        private IBooksRespository booksRespository;

        public FeedBackManager()
        {
            InitializeComponent();
            feedBackRespository = new FeedBackRepository();
            accountRespository = new AccountRespository();
            booksRespository = new BooksRespository();
            LoadReplyStatus();
            LoadFeedBack();
        }
        public void LoadReplyStatus()
        {
            try
            {
                List<string> replyStatus = new List<string>()
                {
                    "Replied",
                    "UnReplied"
                };

                cbReplyStatus.ItemsSource = replyStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadFeedBack ", ex.Message);
            }
        }
        public void LoadFeedBack()
        {
            try
            {
                var feedBack = feedBackRespository.GetAllFeedBack();
                lvFeedbackList.ItemsSource = feedBack;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadFeedBack ", ex.Message);
            }
        }
        public void LoadFeedBack2(string status)
        {
            try
            {
                var feedBack = feedBackRespository.GetFeedBackByReplySatus(status);
                lvFeedbackList.ItemsSource = feedBack;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadFeedBack ", ex.Message);
            }
        }
        private void SearchFeedback_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string searchText = txtSearchFeedback.Text.Trim().ToLower();
                var feedBack = feedBackRespository.GetFeedBackBySearch(searchText);
                lvFeedbackList.ItemsSource = feedBack;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SearchFeedback_Click ", ex.Message);
            }
        }

        private void SendReply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Response response = new Response
                {
                    UserId = accountRespository.GetUserIdByUsername(txtUserName.Text),
                    Detail = txtReplyContent.Text,
                    ResponseTime = DateTime.Now,
                    ReportId = int.Parse(txtId.Text)

                };
                feedBackRespository.AddResponseFeedBack(response);
                feedBackRespository.UpdateReplyStatus(int.Parse(txtId.Text));
                ClearValue();
                lvFeedbackList.Items.Refresh();
                MessageBox.Show("Send FeedBack Successes.", "Successes", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("SendReply_Click", ex.Message);
            }
        }
        private void lvFeedbackList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvFeedbackList.SelectedItem is Report selectedFeedBack)
            {
                txtId.Text = selectedFeedBack.ReportId.ToString();
                txtBookName.Text = selectedFeedBack.Book.Title;
                txtUserName.Text = selectedFeedBack.User.UserName;
                txtFeedbackContent.Text = selectedFeedBack.ProblemNavigation.ReportType1;
                txtChapter.Text = selectedFeedBack.Chapter;
            }
        }
        private void BooksManagerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookManager bookManager = new BookManager();
            bookManager.ShowDialog();
        }

        private void ResponseFeedBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ResponseFeedBack responseFeedBack = new ResponseFeedBack();
            responseFeedBack.ShowDialog();
        }

        private void ManageAccountsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog();
        }

        private void cbReplyStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cbReplyStatus.SelectedValue is string selectedStatus)
            {
                LoadFeedBack2(selectedStatus);
            }

        }
        private void ClearValue()
        {
            txtUserName.Text = string.Empty;
            txtFeedbackContent.Text = string.Empty;
            txtChapter.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtFeedbackContent.Text= string.Empty;
            txtReplyContent.Text= string.Empty;
        }
    }
}
