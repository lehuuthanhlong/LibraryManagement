using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibraryApplication
{
    internal class BookInformation
    {
        // Properties
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime PublicationDate { get; set; }

        // List để lưu trữ danh sách sách
        private List<BookInformation> bookList = new List<BookInformation>();

        // Constructor
        public BookInformation(int bookID, string title, string author, string genre, int quantity, int availableQuantity, DateTime publicationDate)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Genre = genre;
            Quantity = quantity;
            AvailableQuantity = availableQuantity;
            PublicationDate = publicationDate;
        }
    }
}
