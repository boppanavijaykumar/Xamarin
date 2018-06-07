using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookMyBook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var books = GetMockBooks();
            BookList.ItemsSource = books;

        }
        List<BookModel> GetMockBooks()
        {
            var books = new List<BookModel>();
            books.Add(new BookModel()
            {
                BookName = "Book Name : Adventures of TinTin The Lost Treasure",
                BookAuthor = "Author : Paul Shipton",
                BookPrice = "Price : Rs.1200",
                Commentsonbook= "Comments : Good",
                BookImage = "image_1.jpg",
                BookDescription = "Description : Extensive reading is essential for improving fluency and there is a real need in the ELT classroom for contemporary, low-level reading material for younger learners. This reader is based on the 2011 movie The Adventures of Tintin about Tintin and Snowy and their search for the hidden treasure. The Lost Treasure is one of three readers based on the film."
            });

            books.Add(new BookModel()
            {
                BookName = "Book Name : Batman the Killing Joke",
                BookAuthor = "Author : Warner Bros",
                BookPrice = "Price : Rs.899",
                Commentsonbook= "Comments : Can be better",
                BookImage = "image_3.jpg",
                BookDescription = "Description : When the Joker escapes prison, Batman sets out to find him. Meanwhile, he kidnaps Commissioner Gordon, after paralysing his daughter, in a bid to drive him insane."
            });
            books.Add(new BookModel()
            {
                BookName = "Book Name : Scooby-Doo Team-Up",
                BookAuthor = "Author : Sholly Fish",
                BookPrice = "Price : Rs.1999",
                Commentsonbook = "Comments : very Good",
                BookImage = "image_2.jpg",
                BookDescription = "Description : Holy overactive imagination! When Scarecrow attacks using his fear gas, only humans are affected, leaving Batman, Robin and the Mystery Inc. gang trapped facing Monsters from their own imaginations. Now, it's up to canine crusaders Scooby-Doo and Ace the Bat-Hound to save the day!"
            });
            return books;
        }
        private void BookList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as BookModel;
            Navigation.PushAsync(new Bookmybook(selectedBook));
        }
    }
}

