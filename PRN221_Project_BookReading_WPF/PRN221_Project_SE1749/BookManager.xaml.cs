using BussinessObject;
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
using static System.Net.Mime.MediaTypeNames;

namespace PRN221_Project_SE1749
{
    /// <summary>
    /// Interaction logic for BookManager.xaml
    /// </summary>
    public partial class BookManager : Window
    {
        private IBooksRespository booksRespository;

        public BookManager()
        {
            InitializeComponent();
            booksRespository = new BooksRespository();
            LoadApprove();
            //LoadStatus();
        }
        private void LoadApprove()
        {
            try
            {
                List<string> approve = new List<string>{
                    "Approved",
                    "Pending ",
                    "Rejected"
                };
                cbApprove.ItemsSource = approve;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadApprove ", ex.Message);
            }
        }

        public void LoadBooks()
        {
            try
            {
                var book = booksRespository.GetAllBook();
                BooksDataGrid.ItemsSource = book;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadBooks ", ex.Message);
            }
        }
        public void LoadBooks2(string approveStatus)
        {
            try
            {
                var book = booksRespository.GetBookByApproveSatus(approveStatus);
                BooksDataGrid.ItemsSource = book;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadBooks ", ex.Message);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBooks();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(searchText))
                {
                    var books = booksRespository.GetBooksBySearch(searchText);
                    BooksDataGrid.ItemsSource = books;
                }
                else
                {
                    MessageBox.Show("None Books.", "Note", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error SearchButton: {ex.Message}");
            }
        }
        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            var addBookWindow = new AddUpdateBook();
            if (addBookWindow.ShowDialog() == true)
            {
                LoadBooks();
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (BooksDataGrid.SelectedItem is Book selectedBook)
            {
                var updateBookWindow = new AddUpdateBook(selectedBook);
                if (updateBookWindow.ShowDialog() == true)
                {
                    LoadBooks();
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to update.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BooksDataGrid.SelectedItem is Book selectedBook)
                {
                    if (selectedBook.Approve == "Rejected")
                    {
                        MessageBox.Show("Book has Reject", "Note", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        LoadBooks();

                    }
                    else
                    {
                        selectedBook.Approve = "Rejected";
                        booksRespository.UpdateBook(selectedBook);
                        MessageBox.Show("Books Reject successfully.", "Note", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        LoadBooks();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account to Reject.", "Note", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RejectButton_Click ", ex.Message);

            }
        }
        private void ApprovedButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BooksDataGrid.SelectedItem is Book selectedBook)
                {
                    if (selectedBook.Approve == "Approved")
                    {
                        MessageBox.Show("Book has Approved", "Note", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        LoadBooks();

                    }
                    else
                    {
                        selectedBook.Approve = "Approved";
                        booksRespository.UpdateBook(selectedBook);
                        MessageBox.Show("Book Approved successfully.", "Note", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        LoadBooks();
                    }

                }
                else
                {
                    MessageBox.Show("Please select an account to Approved.", "Note", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ApprovedButton_Click ", ex.Message);

            }
        }

        private void ManageAccountsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog();
        }
        private void LoadBooksButton_Click(object sender, RoutedEventArgs e)
        {
            LoadBooks();
        }

        private void SendFeedBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FeedBackManager feedBackManager = new FeedBackManager();
            feedBackManager.ShowDialog();
        }

        private void cbApprove_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbApprove.SelectedValue is string selectedStatus)
            {
                LoadBooks2(selectedStatus);
            }
        }
    }
}
