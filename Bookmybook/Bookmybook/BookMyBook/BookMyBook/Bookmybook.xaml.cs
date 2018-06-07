using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookMyBook
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bookmybook : ContentPage
	{
		public Bookmybook ()
		{
			InitializeComponent ();
		}
        private BookModel SelectedBook { get; set; }
        public Bookmybook(BookModel selectedBookModel)
        {
            InitializeComponent();
            SelectedBook = selectedBookModel;
            BookImage.Source = SelectedBook.BookImage;
            BookName.Text = SelectedBook.BookName;
            BookAuthor.Text = SelectedBook.BookAuthor;
            BookPrice.Text = SelectedBook.BookPrice;
            Commentsonbook.Text = SelectedBook.Commentsonbook;
            BookDescription.Text = SelectedBook.BookDescription;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "There are no books available Right Now...!!!","OK");
        }
    }
}