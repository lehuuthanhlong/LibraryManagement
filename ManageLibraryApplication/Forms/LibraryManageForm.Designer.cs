namespace ManageLibraryApplication.Forms
{
    partial class LibraryManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tab1 = new TabControl();
            tabLibrary = new TabPage();
            lvBooks = new ListView();
            clID = new ColumnHeader();
            clTitle = new ColumnHeader();
            clAuthor = new ColumnHeader();
            clGenre = new ColumnHeader();
            clQuantity = new ColumnHeader();
            clAvailable = new ColumnHeader();
            clPublicDate = new ColumnHeader();
            grBoxLibrary = new GroupBox();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnAddBook = new Button();
            txbPublicDate = new TextBox();
            txbAvailable = new TextBox();
            txbQuantity = new TextBox();
            txbGenre = new TextBox();
            txbAuthor = new TextBox();
            txbTitle = new TextBox();
            txbID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabReader = new TabPage();
            lvReader = new ListView();
            clName = new ColumnHeader();
            clAddress = new ColumnHeader();
            clPhoneNumber = new ColumnHeader();
            clEmailAddress = new ColumnHeader();
            panel1 = new Panel();
            btnDeleteReader = new Button();
            btnUpdateReader = new Button();
            btnAddReader = new Button();
            txbEmail = new TextBox();
            label11 = new Label();
            txbAddress = new TextBox();
            label10 = new Label();
            txbPhoneNumber = new TextBox();
            label9 = new Label();
            txbName = new TextBox();
            label8 = new Label();
            tabBorrowReturn = new TabPage();
            lvBorrowReturn = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel3 = new Panel();
            dtpBorrow = new DateTimePicker();
            cbEmail_BR = new ComboBox();
            cbTitle_BR = new ComboBox();
            cbName_BR = new ComboBox();
            cbID_BR = new ComboBox();
            cbStatus = new ComboBox();
            btnDelete_BR = new Button();
            btnUpdate_BR = new Button();
            btnAdd_BR = new Button();
            label25 = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            label24 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txbEmailAddress_BR = new TextBox();
            txbTitle_BR = new TextBox();
            txbName_BR = new TextBox();
            label18 = new Label();
            txbID_BR = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label13 = new Label();
            label12 = new Label();
            columnHeader7 = new ColumnHeader();
            label26 = new Label();
            dtpReturn = new DateTimePicker();
            tab1.SuspendLayout();
            tabLibrary.SuspendLayout();
            grBoxLibrary.SuspendLayout();
            tabReader.SuspendLayout();
            panel1.SuspendLayout();
            tabBorrowReturn.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tab1
            // 
            tab1.Controls.Add(tabLibrary);
            tab1.Controls.Add(tabReader);
            tab1.Controls.Add(tabBorrowReturn);
            tab1.Dock = DockStyle.Top;
            tab1.Font = new Font("Tahoma", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            tab1.Location = new Point(0, 0);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(1284, 661);
            tab1.TabIndex = 0;
            // 
            // tabLibrary
            // 
            tabLibrary.Controls.Add(lvBooks);
            tabLibrary.Controls.Add(grBoxLibrary);
            tabLibrary.Location = new Point(4, 25);
            tabLibrary.Name = "tabLibrary";
            tabLibrary.Padding = new Padding(3);
            tabLibrary.Size = new Size(1276, 632);
            tabLibrary.TabIndex = 0;
            tabLibrary.Text = "Library";
            tabLibrary.UseVisualStyleBackColor = true;
            // 
            // lvBooks
            // 
            lvBooks.Columns.AddRange(new ColumnHeader[] { clID, clTitle, clAuthor, clGenre, clQuantity, clAvailable, clPublicDate });
            lvBooks.FullRowSelect = true;
            lvBooks.GridLines = true;
            lvBooks.Location = new Point(487, 28);
            lvBooks.Name = "lvBooks";
            lvBooks.Size = new Size(789, 578);
            lvBooks.TabIndex = 1;
            lvBooks.UseCompatibleStateImageBehavior = false;
            lvBooks.View = View.Details;
            lvBooks.SelectedIndexChanged += lvBooks_SelectedIndexChanged;
            // 
            // clID
            // 
            clID.Text = "ID";
            // 
            // clTitle
            // 
            clTitle.Text = "Title";
            clTitle.TextAlign = HorizontalAlignment.Center;
            clTitle.Width = 200;
            // 
            // clAuthor
            // 
            clAuthor.Text = "Author";
            clAuthor.TextAlign = HorizontalAlignment.Center;
            clAuthor.Width = 170;
            // 
            // clGenre
            // 
            clGenre.Text = "Genre";
            clGenre.TextAlign = HorizontalAlignment.Center;
            // 
            // clQuantity
            // 
            clQuantity.Text = "Quantity";
            clQuantity.Width = 70;
            // 
            // clAvailable
            // 
            clAvailable.Text = "Available";
            clAvailable.Width = 75;
            // 
            // clPublicDate
            // 
            clPublicDate.Text = "Public Date";
            clPublicDate.TextAlign = HorizontalAlignment.Center;
            clPublicDate.Width = 150;
            // 
            // grBoxLibrary
            // 
            grBoxLibrary.Controls.Add(btnDeleteBook);
            grBoxLibrary.Controls.Add(btnUpdateBook);
            grBoxLibrary.Controls.Add(btnAddBook);
            grBoxLibrary.Controls.Add(txbPublicDate);
            grBoxLibrary.Controls.Add(txbAvailable);
            grBoxLibrary.Controls.Add(txbQuantity);
            grBoxLibrary.Controls.Add(txbGenre);
            grBoxLibrary.Controls.Add(txbAuthor);
            grBoxLibrary.Controls.Add(txbTitle);
            grBoxLibrary.Controls.Add(txbID);
            grBoxLibrary.Controls.Add(label7);
            grBoxLibrary.Controls.Add(label6);
            grBoxLibrary.Controls.Add(label5);
            grBoxLibrary.Controls.Add(label4);
            grBoxLibrary.Controls.Add(label3);
            grBoxLibrary.Controls.Add(label2);
            grBoxLibrary.Controls.Add(label1);
            grBoxLibrary.Font = new Font("Yu Gothic", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            grBoxLibrary.Location = new Point(3, 17);
            grBoxLibrary.Name = "grBoxLibrary";
            grBoxLibrary.Size = new Size(478, 589);
            grBoxLibrary.TabIndex = 0;
            grBoxLibrary.TabStop = false;
            grBoxLibrary.Text = "Book Management";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteBook.Location = new Point(339, 457);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(83, 25);
            btnDeleteBook.TabIndex = 2;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateBook.Location = new Point(228, 457);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(83, 25);
            btnUpdateBook.TabIndex = 2;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.Location = new Point(119, 457);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(83, 25);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txbPublicDate
            // 
            txbPublicDate.Location = new Point(119, 382);
            txbPublicDate.Name = "txbPublicDate";
            txbPublicDate.Size = new Size(340, 28);
            txbPublicDate.TabIndex = 1;
            // 
            // txbAvailable
            // 
            txbAvailable.Location = new Point(119, 340);
            txbAvailable.Name = "txbAvailable";
            txbAvailable.Size = new Size(340, 28);
            txbAvailable.TabIndex = 1;
            // 
            // txbQuantity
            // 
            txbQuantity.Location = new Point(119, 298);
            txbQuantity.Name = "txbQuantity";
            txbQuantity.Size = new Size(340, 28);
            txbQuantity.TabIndex = 1;
            // 
            // txbGenre
            // 
            txbGenre.Location = new Point(119, 256);
            txbGenre.Name = "txbGenre";
            txbGenre.Size = new Size(340, 28);
            txbGenre.TabIndex = 1;
            // 
            // txbAuthor
            // 
            txbAuthor.Location = new Point(119, 214);
            txbAuthor.Name = "txbAuthor";
            txbAuthor.Size = new Size(340, 28);
            txbAuthor.TabIndex = 1;
            // 
            // txbTitle
            // 
            txbTitle.Location = new Point(119, 172);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(340, 28);
            txbTitle.TabIndex = 1;
            // 
            // txbID
            // 
            txbID.Location = new Point(119, 124);
            txbID.Name = "txbID";
            txbID.Size = new Size(340, 28);
            txbID.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 393);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 0;
            label7.Text = "Public Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 351);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 0;
            label6.Text = "Available";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 309);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 0;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 267);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 0;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 225);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 0;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 183);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 0;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 135);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tabReader
            // 
            tabReader.Controls.Add(lvReader);
            tabReader.Controls.Add(panel1);
            tabReader.Location = new Point(4, 25);
            tabReader.Name = "tabReader";
            tabReader.Padding = new Padding(3);
            tabReader.Size = new Size(1276, 632);
            tabReader.TabIndex = 1;
            tabReader.Text = "Reader";
            tabReader.UseVisualStyleBackColor = true;
            // 
            // lvReader
            // 
            lvReader.BackColor = Color.White;
            lvReader.Columns.AddRange(new ColumnHeader[] { clName, clAddress, clPhoneNumber, clEmailAddress });
            lvReader.FullRowSelect = true;
            lvReader.GridLines = true;
            lvReader.Location = new Point(3, 293);
            lvReader.Name = "lvReader";
            lvReader.Size = new Size(1270, 336);
            lvReader.TabIndex = 1;
            lvReader.UseCompatibleStateImageBehavior = false;
            lvReader.View = View.Details;
            lvReader.SelectedIndexChanged += lvReader_SelectedIndexChanged;
            // 
            // clName
            // 
            clName.Text = "Name";
            clName.Width = 300;
            // 
            // clAddress
            // 
            clAddress.Text = "Address";
            clAddress.TextAlign = HorizontalAlignment.Center;
            clAddress.Width = 350;
            // 
            // clPhoneNumber
            // 
            clPhoneNumber.Text = "Phone Number";
            clPhoneNumber.TextAlign = HorizontalAlignment.Center;
            clPhoneNumber.Width = 280;
            // 
            // clEmailAddress
            // 
            clEmailAddress.Text = "Email Address";
            clEmailAddress.TextAlign = HorizontalAlignment.Center;
            clEmailAddress.Width = 330;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeleteReader);
            panel1.Controls.Add(btnUpdateReader);
            panel1.Controls.Add(btnAddReader);
            panel1.Controls.Add(txbEmail);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txbAddress);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txbPhoneNumber);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 281);
            panel1.TabIndex = 0;
            // 
            // btnDeleteReader
            // 
            btnDeleteReader.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteReader.Location = new Point(664, 204);
            btnDeleteReader.Name = "btnDeleteReader";
            btnDeleteReader.Size = new Size(83, 25);
            btnDeleteReader.TabIndex = 4;
            btnDeleteReader.Text = "Delete";
            btnDeleteReader.UseVisualStyleBackColor = true;
            btnDeleteReader.Click += btnDeleteReader_Click;
            // 
            // btnUpdateReader
            // 
            btnUpdateReader.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateReader.Location = new Point(514, 204);
            btnUpdateReader.Name = "btnUpdateReader";
            btnUpdateReader.Size = new Size(83, 25);
            btnUpdateReader.TabIndex = 5;
            btnUpdateReader.Text = "Update";
            btnUpdateReader.UseVisualStyleBackColor = true;
            btnUpdateReader.Click += btnUpdateReader_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddReader.Location = new Point(358, 204);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(83, 25);
            btnAddReader.TabIndex = 6;
            btnAddReader.Text = "Add";
            btnAddReader.UseVisualStyleBackColor = true;
            btnAddReader.Click += btnAddReader_Click;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(753, 90);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(340, 23);
            txbEmail.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(650, 93);
            label11.Name = "label11";
            label11.Size = new Size(97, 16);
            label11.TabIndex = 2;
            label11.Text = "Email Address";
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(101, 90);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(340, 23);
            txbAddress.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 97);
            label10.Name = "label10";
            label10.Size = new Size(61, 16);
            label10.TabIndex = 2;
            label10.Text = "Address";
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new Point(753, 32);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(340, 23);
            txbPhoneNumber.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(647, 35);
            label9.Name = "label9";
            label9.Size = new Size(100, 16);
            label9.TabIndex = 2;
            label9.Text = "Phone Number";
            // 
            // txbName
            // 
            txbName.Location = new Point(101, 25);
            txbName.Name = "txbName";
            txbName.Size = new Size(340, 23);
            txbName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 28);
            label8.Name = "label8";
            label8.Size = new Size(42, 16);
            label8.TabIndex = 2;
            label8.Text = "Name";
            // 
            // tabBorrowReturn
            // 
            tabBorrowReturn.Controls.Add(lvBorrowReturn);
            tabBorrowReturn.Controls.Add(panel3);
            tabBorrowReturn.Controls.Add(panel2);
            tabBorrowReturn.Location = new Point(4, 25);
            tabBorrowReturn.Name = "tabBorrowReturn";
            tabBorrowReturn.Padding = new Padding(3);
            tabBorrowReturn.Size = new Size(1276, 632);
            tabBorrowReturn.TabIndex = 2;
            tabBorrowReturn.Text = "Borrow/Return";
            tabBorrowReturn.UseVisualStyleBackColor = true;
            // 
            // lvBorrowReturn
            // 
            lvBorrowReturn.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvBorrowReturn.FullRowSelect = true;
            lvBorrowReturn.GridLines = true;
            lvBorrowReturn.Location = new Point(0, 306);
            lvBorrowReturn.Name = "lvBorrowReturn";
            lvBorrowReturn.Size = new Size(1255, 351);
            lvBorrowReturn.TabIndex = 1;
            lvBorrowReturn.UseCompatibleStateImageBehavior = false;
            lvBorrowReturn.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Title";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email Address";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Status";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Borrow Date";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 110;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpReturn);
            panel3.Controls.Add(dtpBorrow);
            panel3.Controls.Add(cbEmail_BR);
            panel3.Controls.Add(cbTitle_BR);
            panel3.Controls.Add(cbName_BR);
            panel3.Controls.Add(cbID_BR);
            panel3.Controls.Add(cbStatus);
            panel3.Controls.Add(btnDelete_BR);
            panel3.Controls.Add(btnUpdate_BR);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(btnAdd_BR);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label23);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1252, 297);
            panel3.TabIndex = 0;
            // 
            // dtpBorrow
            // 
            dtpBorrow.Location = new Point(391, 160);
            dtpBorrow.Name = "dtpBorrow";
            dtpBorrow.Size = new Size(256, 23);
            dtpBorrow.TabIndex = 13;
            // 
            // cbEmail_BR
            // 
            cbEmail_BR.FormattingEnabled = true;
            cbEmail_BR.Location = new Point(725, 116);
            cbEmail_BR.Name = "cbEmail_BR";
            cbEmail_BR.Size = new Size(340, 24);
            cbEmail_BR.TabIndex = 12;
            // 
            // cbTitle_BR
            // 
            cbTitle_BR.FormattingEnabled = true;
            cbTitle_BR.Location = new Point(725, 34);
            cbTitle_BR.Name = "cbTitle_BR";
            cbTitle_BR.Size = new Size(340, 24);
            cbTitle_BR.TabIndex = 12;
            // 
            // cbName_BR
            // 
            cbName_BR.FormattingEnabled = true;
            cbName_BR.Location = new Point(66, 113);
            cbName_BR.Name = "cbName_BR";
            cbName_BR.Size = new Size(340, 24);
            cbName_BR.TabIndex = 12;
            // 
            // cbID_BR
            // 
            cbID_BR.FormattingEnabled = true;
            cbID_BR.Location = new Point(66, 32);
            cbID_BR.Name = "cbID_BR";
            cbID_BR.Size = new Size(340, 24);
            cbID_BR.TabIndex = 12;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Borrowing", "Returned" });
            cbStatus.Location = new Point(75, 162);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(155, 24);
            cbStatus.TabIndex = 11;
            // 
            // btnDelete_BR
            // 
            btnDelete_BR.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete_BR.Location = new Point(712, 237);
            btnDelete_BR.Name = "btnDelete_BR";
            btnDelete_BR.Size = new Size(83, 25);
            btnDelete_BR.TabIndex = 7;
            btnDelete_BR.Text = "Delete";
            btnDelete_BR.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_BR
            // 
            btnUpdate_BR.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate_BR.Location = new Point(562, 237);
            btnUpdate_BR.Name = "btnUpdate_BR";
            btnUpdate_BR.Size = new Size(83, 25);
            btnUpdate_BR.TabIndex = 8;
            btnUpdate_BR.Text = "Update";
            btnUpdate_BR.UseVisualStyleBackColor = true;
            // 
            // btnAdd_BR
            // 
            btnAdd_BR.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd_BR.Location = new Point(406, 237);
            btnAdd_BR.Name = "btnAdd_BR";
            btnAdd_BR.Size = new Size(83, 25);
            btnAdd_BR.TabIndex = 9;
            btnAdd_BR.Text = "Add";
            btnAdd_BR.UseVisualStyleBackColor = true;
            btnAdd_BR.Click += btnAdd_BR_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(296, 165);
            label25.Name = "label25";
            label25.Size = new Size(89, 16);
            label25.TabIndex = 4;
            label25.Text = "Borrow Date";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(622, 119);
            label17.Name = "label17";
            label17.Size = new Size(97, 16);
            label17.TabIndex = 4;
            label17.Text = "Email Address";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(685, 37);
            label19.Name = "label19";
            label19.Size = new Size(34, 16);
            label19.TabIndex = 4;
            label19.Text = "Title";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 80);
            label20.Name = "label20";
            label20.Size = new Size(54, 16);
            label20.TabIndex = 4;
            label20.Text = "Reader";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(19, 165);
            label24.Name = "label24";
            label24.Size = new Size(50, 16);
            label24.TabIndex = 4;
            label24.Text = "Status";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(18, 116);
            label21.Name = "label21";
            label21.Size = new Size(42, 16);
            label21.TabIndex = 4;
            label21.Text = "Name";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 9);
            label22.Name = "label22";
            label22.Size = new Size(38, 16);
            label22.TabIndex = 4;
            label22.Text = "Book";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(39, 36);
            label23.Name = "label23";
            label23.Size = new Size(21, 16);
            label23.TabIndex = 4;
            label23.Text = "ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(txbEmailAddress_BR);
            panel2.Controls.Add(txbTitle_BR);
            panel2.Controls.Add(txbName_BR);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(txbID_BR);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 297);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(712, 206);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 7;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(562, 206);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(406, 206);
            button3.Name = "button3";
            button3.Size = new Size(83, 25);
            button3.TabIndex = 9;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // txbEmailAddress_BR
            // 
            txbEmailAddress_BR.Location = new Point(725, 116);
            txbEmailAddress_BR.Name = "txbEmailAddress_BR";
            txbEmailAddress_BR.Size = new Size(340, 23);
            txbEmailAddress_BR.TabIndex = 5;
            // 
            // txbTitle_BR
            // 
            txbTitle_BR.Location = new Point(725, 33);
            txbTitle_BR.Name = "txbTitle_BR";
            txbTitle_BR.Size = new Size(340, 23);
            txbTitle_BR.TabIndex = 5;
            // 
            // txbName_BR
            // 
            txbName_BR.Location = new Point(66, 116);
            txbName_BR.Name = "txbName_BR";
            txbName_BR.Size = new Size(340, 23);
            txbName_BR.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(622, 119);
            label18.Name = "label18";
            label18.Size = new Size(97, 16);
            label18.TabIndex = 4;
            label18.Text = "Email Address";
            // 
            // txbID_BR
            // 
            txbID_BR.Location = new Point(66, 33);
            txbID_BR.Name = "txbID_BR";
            txbID_BR.Size = new Size(340, 23);
            txbID_BR.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(685, 37);
            label14.Name = "label14";
            label14.Size = new Size(34, 16);
            label14.TabIndex = 4;
            label14.Text = "Title";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 80);
            label15.Name = "label15";
            label15.Size = new Size(54, 16);
            label15.TabIndex = 4;
            label15.Text = "Reader";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 116);
            label16.Name = "label16";
            label16.Size = new Size(42, 16);
            label16.TabIndex = 4;
            label16.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 9);
            label13.Name = "label13";
            label13.Size = new Size(38, 16);
            label13.TabIndex = 4;
            label13.Text = "Book";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 36);
            label12.Name = "label12";
            label12.Size = new Size(21, 16);
            label12.TabIndex = 4;
            label12.Text = "ID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Return Date";
            columnHeader7.Width = 110;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(714, 163);
            label26.Name = "label26";
            label26.Size = new Size(87, 16);
            label26.TabIndex = 4;
            label26.Text = "Return Date";
            // 
            // dtpReturn
            // 
            dtpReturn.Location = new Point(809, 158);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(256, 23);
            dtpReturn.TabIndex = 13;
            // 
            // LibraryManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 659);
            Controls.Add(tab1);
            Name = "LibraryManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibraryManageForm";
            Load += LibraryManageForm_Load;
            tab1.ResumeLayout(false);
            tabLibrary.ResumeLayout(false);
            grBoxLibrary.ResumeLayout(false);
            grBoxLibrary.PerformLayout();
            tabReader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabBorrowReturn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab1;
        private TabPage tabLibrary;
        private TabPage tabReader;
        private TabPage tabBorrowReturn;
        private GroupBox grBoxLibrary;
        private Label label1;
        private TextBox txbPublicDate;
        private Label label7;
        private TextBox txbAvailable;
        private Label label6;
        private TextBox txbQuantity;
        private Label label5;
        private TextBox txbGenre;
        private Label label4;
        private TextBox txbAuthor;
        private Label label3;
        private TextBox txbTitle;
        private Label label2;
        private TextBox txbID;
        private ListView lvBooks;
        private ColumnHeader clID;
        private ColumnHeader clTitle;
        private ColumnHeader clAuthor;
        private ColumnHeader clGenre;
        private ColumnHeader clQuantity;
        private ColumnHeader clAvailable;
        private ColumnHeader clPublicDate;
        private Panel panel1;
        private TextBox txbEmail;
        private Label label11;
        private TextBox txbAddress;
        private Label label10;
        private TextBox txbPhoneNumber;
        private Label label9;
        private TextBox txbName;
        private Label label8;
        private ListView lvReader;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private ColumnHeader clName;
        private ColumnHeader clAddress;
        private ColumnHeader clPhoneNumber;
        private ColumnHeader clEmailAddress;
        private Button btnDeleteReader;
        private Button btnUpdateReader;
        private Button btnAddReader;
        private ListView lvBorrowReturn;
        private Panel panel2;
        private TextBox txbID_BR;
        private Label label13;
        private Label label12;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbEmailAddress_BR;
        private TextBox txbTitle_BR;
        private TextBox txbName_BR;
        private Label label18;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader columnHeader5;
        private Panel panel3;
        private ComboBox cbStatus;
        private Button btnDelete_BR;
        private Button btnUpdate_BR;
        private Button btnAdd_BR;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label24;
        private Label label21;
        private Label label22;
        private Label label23;
        private ComboBox cbTitle_BR;
        private ComboBox cbID_BR;
        private ComboBox cbEmail_BR;
        private ComboBox cbName_BR;
        private ColumnHeader columnHeader6;
        private DateTimePicker dtpBorrow;
        private Label label25;
        private ColumnHeader columnHeader7;
        private DateTimePicker dtpReturn;
        private Label label26;
    }
}