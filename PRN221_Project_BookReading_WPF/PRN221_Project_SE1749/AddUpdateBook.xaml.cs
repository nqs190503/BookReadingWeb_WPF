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

namespace PRN221_Project_SE1749
{
    /// <summary>
    /// Interaction logic for AddUpdateBook.xaml
    /// </summary>
    public partial class AddUpdateBook : Window
    {
        private readonly IBooksRespository booksRepository;

        public Book Book { get; private set; }
        public bool IsEditMode { get; private set; }
        public AddUpdateBook(Book book = null)
        {
            InitializeComponent();
            booksRepository = new BooksRespository();  

            LoadStatus();
            //LoadApprove();
            if (book != null)
            {
                Book = book;
                IsEditMode = true;
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.AuthorName;
                txtDetail.Text = book.Detail;
                txtImage.Text = book.Img;
                cbStatus.SelectedValue = book.Status;
                //cbApprove.SelectedValue = book.Approve;

            }
            else
            {
                Book = new Book();
                IsEditMode = false;
            }
        }
        private void LoadStatus()
        {
            List<string> status = new List<string> { "Updating", "Full" , "Delete" };
            cbStatus.ItemsSource = status;
           
        }

        //private void LoadApprove()
        //{
        //    List<string> actives = new List<string> { "Approved ", "Pending ", "Rejected " };
        //    cbApprove.ItemsSource = actives;
        //}
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate Detail field - max 2000 words
                //var detailText = txtDetail.Text;
                //var wordCount = detailText.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                //if (wordCount > 2000)
                //{
                //    MessageBox.Show("Detail field cannot exceed 2000 words.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return;
                //}

                // Validate Image field - must be a valid URL and point to an image
                var imageUrl = txtImage.Text;
                if (!Uri.TryCreate(imageUrl, UriKind.Absolute, out Uri uriResult) ||
                    !(imageUrl.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                      imageUrl.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                      imageUrl.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                      imageUrl.EndsWith(".gif", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Image field must be a valid URL pointing to an image (jpg, jpeg, png, gif).", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                // Gán giá trị từ giao diện vào Book object
                Book.Title = txtTitle.Text;
                Book.AuthorName = txtAuthor.Text;
                Book.Detail = txtDetail.Text;
                Book.Img = txtImage.Text;
                Book.Status = cbStatus.SelectedValue?.ToString();

                if (IsEditMode)
                {
                    booksRepository.UpdateBook(Book);
                }
                else
                {
                    Book.Approve = "Pending";
                    Book.UserId = CurrentUserSession.UserId; 
                    Book.PublishDate = DateTime.Now;          
                    booksRepository.AddBook(Book);
                }

                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
