using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibraryApplication
{
    internal class BorrowReturnInformation
    {
        public string BookID { get; set; }
        public string BookTitle { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowerEmail { get; set; }
        public string Status { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public BorrowReturnInformation(string bookID, string bookTitle, string borrowerName, string borrowerEmail,string status, DateTime borrowDate, DateTime returnDate)
        {
            BookID = bookID;
            BookTitle = bookTitle;
            BorrowerName = borrowerName;
            BorrowerEmail = borrowerEmail;
            Status = status;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
        }
        private List<BorrowReturnInformation> borrowReturnList = new List<BorrowReturnInformation>();

    }
}
