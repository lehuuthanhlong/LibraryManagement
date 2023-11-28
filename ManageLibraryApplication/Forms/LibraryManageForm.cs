using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ManageLibraryApplication.Forms
{
    public partial class LibraryManageForm : Form
    {
        public LibraryManageForm()
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            InitializeComponent();
        }
        private List<BookInformation> bookList = new List<BookInformation>();
        private List<ReaderInformation> readerList = new List<ReaderInformation>();
        private List<BorrowReturnInformation> borrowReturnList = new List<BorrowReturnInformation>();

        private void LibraryManageForm_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            DisplayReaders();
        }

        private void DisplayBooks()
        {

            lvBooks.Items.Clear();
            cbID_BR.Items.Clear();
            cbTitle_BR.Items.Clear();

            foreach (BookInformation book in bookList)
            {
                ListViewItem item = new ListViewItem(book.BookID.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.Quantity.ToString());
                item.SubItems.Add(book.AvailableQuantity.ToString());
                item.SubItems.Add(book.PublicationDate.ToString("MM/dd/yyyy"));
                lvBooks.Items.Add(item);

                cbID_BR.Items.Add(book.BookID.ToString());
                cbTitle_BR.Items.Add(book.Title);
            }

        }
        private void DisplayReaders()
        {
            lvReader.Items.Clear();

            foreach (ReaderInformation reader in readerList)
            {
                ListViewItem item = new ListViewItem(reader.ReaderName);
                item.SubItems.Add(reader.PhoneNumber);
                item.SubItems.Add(reader.ReaderAddress);
                item.SubItems.Add(reader.EmailAddress);
                lvReader.Items.Add(item);

                cbName_BR.Items.Add(reader.ReaderName);
                cbEmail_BR.Items.Add(reader.EmailAddress);
            }
        }

        private void DisplayBorrowreturn()
        {
            lvBorrowReturn.Items.Clear();

            foreach (BorrowReturnInformation borrower in borrowReturnList)
            {
                ListViewItem item = new ListViewItem(borrower.BookID);
                item.SubItems.Add(borrower.BookTitle);
                item.SubItems.Add(borrower.BorrowerName);
                item.SubItems.Add(borrower.BorrowerEmail);
                item.SubItems.Add(borrower.Status);
                item.SubItems.Add(borrower.BorrowDate.ToString("MM/dd/yyyy"));
                item.SubItems.Add(borrower.ReturnDate.ToString("MM/dd/yyyy"));

                lvBorrowReturn.Items.Add(item);
            }

        }


        private void lvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBooks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvBooks.SelectedItems[0];
                txbID.Text = selectedItem.SubItems[0].Text;
                txbTitle.Text = selectedItem.SubItems[1].Text;
                txbAuthor.Text = selectedItem.SubItems[2].Text;
                txbGenre.Text = selectedItem.SubItems[3].Text;
                txbQuantity.Text = selectedItem.SubItems[4].Text;
                txbAvailable.Text = selectedItem.SubItems[5].Text;
                txbPublicDate.Text = selectedItem.SubItems[6].Text;
            }
        }//Hàm hiển thị thông tin lên textbox 

        private void lvReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvReader.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvReader.SelectedItems[0];
                txbName.Text = selectedItem.SubItems[0].Text;
                txbPhoneNumber.Text = selectedItem.SubItems[1].Text;
                txbAddress.Text = selectedItem.SubItems[2].Text;
                txbEmail.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void lvBorrowReturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBorrowReturn.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvBorrowReturn.SelectedItems[0];
                cbID_BR.Text = selectedItem.SubItems[0].Text;
                cbTitle_BR.Text = selectedItem.SubItems[1].Text;
                cbName_BR.Text = selectedItem.SubItems[2].Text;
                cbEmail_BR.Text = selectedItem.SubItems[3].Text;
                cbStatus.Text = selectedItem.SubItems[4].Text;
                dtpBorrow.Value = DateTime.Parse(selectedItem.SubItems[5].Text);
                dtpReturn.Value = DateTime.Parse(selectedItem.SubItems[6].Text);
            }
        }




        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (lvReader.SelectedItems.Count > 0)
                {
                    lvReader.Items.Remove(lvReader.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("No item is selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ClearReaderInputFields();

        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txbName.Text) || string.IsNullOrEmpty(txbPhoneNumber.Text) || string.IsNullOrEmpty(txbAddress.Text) || string.IsNullOrEmpty(txbEmail.Text))
            {
                MessageBox.Show("Please enter valid information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DialogResult result = MessageBox.Show("Do you want to update this reader?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (lvReader.SelectedItems.Count > 0)
                {
                    lvReader.SelectedItems[0].SubItems[0].Text = txbName.Text;
                    lvReader.SelectedItems[0].SubItems[1].Text = txbPhoneNumber.Text;
                    lvReader.SelectedItems[0].SubItems[2].Text = txbAddress.Text;
                    lvReader.SelectedItems[0].SubItems[3].Text = txbEmail.Text;
                }
                else
                {
                    MessageBox.Show("No item is selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ClearReaderInputFields();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text) || string.IsNullOrEmpty(txbPhoneNumber.Text) ||
                string.IsNullOrEmpty(txbAddress.Text) || string.IsNullOrEmpty(txbEmail.Text))
            {
                MessageBox.Show("Please enter valid information for Name, Phone Number, Address, and Email.");
                return;
            }

            ReaderInformation newReader = new ReaderInformation(

                txbName.Text,
                txbAddress.Text,
                txbPhoneNumber.Text,
                txbEmail.Text
            );

            readerList.Add(newReader);
            DisplayReaders();
            ClearReaderInputFields();
        }//Add reader 



        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID.Text) || string.IsNullOrEmpty(txbTitle.Text) || string.IsNullOrEmpty(txbAuthor.Text))
            {
                MessageBox.Show("Please enter valid information for Book ID, Title, and Author.");
                return;
            }
            if (!int.TryParse(txbQuantity.Text, out int quantity) || !int.TryParse(txbAvailable.Text, out int availableQuantity))
            {
                MessageBox.Show("Please enter valid integer values for Quantity and Available Quantity.");
                return;
            }
            if (!DateTime.TryParse(txbPublicDate.Text, out DateTime publicationDate))
            {
                MessageBox.Show("Please enter a valid date for Publication Date.");
                return;
            }

            BookInformation newBook = new BookInformation(
                int.Parse(txbID.Text),
                txbTitle.Text,
                txbAuthor.Text,
                txbGenre.Text,
                quantity,
                availableQuantity,
                publicationDate
            );
            bookList.Add(newBook);
            DisplayBooks();
            ClearBookInputFields();
        }//Add new book


        private void ClearBookInputFields()
        {
            txbID.Clear();
            txbTitle.Clear();
            txbAuthor.Clear();
            txbGenre.Clear();
            txbQuantity.Clear();
            txbAvailable.Clear();
            txbPublicDate.Clear();
        }//Hàm xóa text của text box (sách)


        private void ClearReaderInputFields()//Hàm xóa text của text box (độc giả)
        {
            txbName.Clear();
            txbPhoneNumber.Clear();
            txbAddress.Clear();
            txbEmail.Clear();
        }


        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (lvBooks.SelectedItems.Count > 0)
                {
                    lvBooks.Items.Remove(lvBooks.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("No item is selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ClearBookInputFields();
        }//Delete book In4



        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID.Text) || string.IsNullOrEmpty(txbTitle.Text) || string.IsNullOrEmpty(txbAuthor.Text))
            {
                MessageBox.Show("Please enter valid information.");
                return;
            }
            if (!int.TryParse(txbQuantity.Text, out int quantity) || !int.TryParse(txbAvailable.Text, out int availableQuantity))
            {
                MessageBox.Show("Please enter valid integer values for Quantity and Available Quantity.");
                return;
            }
            if (!DateTime.TryParse(txbPublicDate.Text, out DateTime publicationDate))
            {
                MessageBox.Show("Please enter a valid date for Publication Date.");
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete this item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (lvBooks.SelectedItems.Count > 0)
                {
                    lvBooks.SelectedItems[0].SubItems[0].Text = txbID.Text;
                    lvBooks.SelectedItems[0].SubItems[1].Text = txbTitle.Text;
                    lvBooks.SelectedItems[0].SubItems[2].Text = txbAuthor.Text;
                    lvBooks.SelectedItems[0].SubItems[3].Text = txbGenre.Text;
                    lvBooks.SelectedItems[0].SubItems[4].Text = txbQuantity.Text;
                    lvBooks.SelectedItems[0].SubItems[5].Text = txbAvailable.Text;
                    lvBooks.SelectedItems[0].SubItems[6].Text = txbPublicDate.Text;
                }
                else
                {
                    MessageBox.Show("No item is selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ClearBookInputFields();
        }//Update book in4


        private void ClearBorrowReturnInputFields()
        {
            cbID_BR.SelectedIndex = -1;
            cbTitle_BR.SelectedIndex = -1;
            cbName_BR.SelectedIndex = -1;
            cbEmail_BR.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            dtpBorrow.Value = DateTime.Now;
            dtpReturn.Value = DateTime.Now;
        }

       
        private void btnAdd_BR_Click(object sender, EventArgs e)
        {
            if (cbID_BR.SelectedItem != null &&
        cbTitle_BR.SelectedItem != null &&
        cbName_BR.SelectedItem != null &&
        cbEmail_BR.SelectedItem != null &&
        cbStatus.SelectedItem != null &&
        !string.IsNullOrWhiteSpace(cbID_BR.Text) &&
        !string.IsNullOrWhiteSpace(cbTitle_BR.Text) &&
        !string.IsNullOrWhiteSpace(cbName_BR.Text) &&
        !string.IsNullOrWhiteSpace(cbEmail_BR.Text) &&
        !string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                BorrowReturnInformation newBorrowReturn = new BorrowReturnInformation(
                    cbID_BR.Text,
                    cbTitle_BR.Text,
                    cbName_BR.Text,
                    cbEmail_BR.Text,
                    cbStatus.Text,
                    dtpBorrow.Value,
                    dtpReturn.Value
                );

                borrowReturnList.Add(newBorrowReturn);


                MessageBox.Show("Borrow/Return information added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select values for all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DisplayBorrowreturn();
            ClearBorrowReturnInputFields();

        }


        private void btnUpdate_BR_Click(object sender, EventArgs e)
        {
            if (lvBorrowReturn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedIndex = lvBorrowReturn.SelectedIndices[0];

            if (cbID_BR.SelectedItem == null ||
                cbTitle_BR.SelectedItem == null ||
                cbName_BR.SelectedItem == null ||
                cbEmail_BR.SelectedItem == null ||
                cbStatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(cbID_BR.Text) ||
                string.IsNullOrWhiteSpace(cbTitle_BR.Text) ||
                string.IsNullOrWhiteSpace(cbName_BR.Text) ||
                string.IsNullOrWhiteSpace(cbEmail_BR.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("Please select values for all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            borrowReturnList[selectedIndex].BookID = cbID_BR.Text;
            borrowReturnList[selectedIndex].BookTitle = cbTitle_BR.Text;
            borrowReturnList[selectedIndex].BorrowerName = cbName_BR.Text;
            borrowReturnList[selectedIndex].BorrowerEmail = cbEmail_BR.Text;
            borrowReturnList[selectedIndex].Status = cbStatus.Text;
            borrowReturnList[selectedIndex].BorrowDate = dtpBorrow.Value;
            borrowReturnList[selectedIndex].ReturnDate = dtpReturn.Value;
            DisplayBorrowreturn();
            ClearBorrowReturnInputFields();
        }





        private void btnDelete_BR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (lvBorrowReturn.SelectedItems.Count > 0)
                {
                    lvBorrowReturn.Items.Remove(lvBorrowReturn.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("No item is selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ClearBorrowReturnInputFields();
            DisplayBorrowreturn();
        }


    }
}
