namespace Wonder
{
    partial class MainForm
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
            this.tbCustomerFName = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbCustomerLName = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerAddr = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMovieCopies = new System.Windows.Forms.TextBox();
            this.tbMovieGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMovieID = new System.Windows.Forms.TextBox();
            this.tbMovieRating = new System.Windows.Forms.TextBox();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMovieYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMoviePlot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRentedMovieID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDateRented = new System.Windows.Forms.TextBox();
            this.lvRentedMovies = new System.Windows.Forms.ListView();
            this.RMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewMovies = new System.Windows.Forms.ListView();
            this.MovieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Copies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewCustomers = new System.Windows.Forms.ListView();
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddCust = new VideoRentalStore.RoundButton();
            this.btnUpdateCust = new VideoRentalStore.RoundButton();
            this.btnDeleteCust = new VideoRentalStore.RoundButton();
            this.tabMoviesAndCustomers = new System.Windows.Forms.TabControl();
            this.tabStoreMovies = new System.Windows.Forms.TabPage();
            this.TabCustomers = new System.Windows.Forms.TabPage();
            this.btnAddMovie = new VideoRentalStore.RoundButton();
            this.btnUpdateMovie = new VideoRentalStore.RoundButton();
            this.btnDeleteMovie = new VideoRentalStore.RoundButton();
            this.btnReturnMovie = new VideoRentalStore.RoundButton();
            this.roundButton2 = new VideoRentalStore.RoundButton();
            this.btnBestCust = new VideoRentalStore.RoundButton();
            this.btnBestMovie = new VideoRentalStore.RoundButton();
            this.tabMoviesAndCustomers.SuspendLayout();
            this.tabStoreMovies.SuspendLayout();
            this.TabCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCustomerFName
            // 
            this.tbCustomerFName.BackColor = System.Drawing.Color.MintCream;
            this.tbCustomerFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerFName.Location = new System.Drawing.Point(81, 324);
            this.tbCustomerFName.Name = "tbCustomerFName";
            this.tbCustomerFName.Size = new System.Drawing.Size(139, 20);
            this.tbCustomerFName.TabIndex = 4;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.BackColor = System.Drawing.Color.MintCream;
            this.tbCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerID.Location = new System.Drawing.Point(31, 19);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.ReadOnly = true;
            this.tbCustomerID.Size = new System.Drawing.Size(63, 20);
            this.tbCustomerID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.Control;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(8, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(11, 327);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.SystemColors.Control;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(13, 353);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // tbCustomerLName
            // 
            this.tbCustomerLName.BackColor = System.Drawing.Color.MintCream;
            this.tbCustomerLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerLName.Location = new System.Drawing.Point(81, 350);
            this.tbCustomerLName.Name = "tbCustomerLName";
            this.tbCustomerLName.Size = new System.Drawing.Size(140, 20);
            this.tbCustomerLName.TabIndex = 6;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.BackColor = System.Drawing.Color.MintCream;
            this.tbCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerPhone.Location = new System.Drawing.Point(81, 376);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(124, 20);
            this.tbCustomerPhone.TabIndex = 7;
            // 
            // tbCustomerAddr
            // 
            this.tbCustomerAddr.BackColor = System.Drawing.Color.MintCream;
            this.tbCustomerAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerAddr.Location = new System.Drawing.Point(80, 402);
            this.tbCustomerAddr.Name = "tbCustomerAddr";
            this.tbCustomerAddr.Size = new System.Drawing.Size(140, 20);
            this.tbCustomerAddr.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(32, 380);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(22, 404);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(100, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Copies";
            // 
            // tbMovieCopies
            // 
            this.tbMovieCopies.BackColor = System.Drawing.Color.MintCream;
            this.tbMovieCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieCopies.Location = new System.Drawing.Point(148, 425);
            this.tbMovieCopies.Name = "tbMovieCopies";
            this.tbMovieCopies.Size = new System.Drawing.Size(33, 20);
            this.tbMovieCopies.TabIndex = 31;
            // 
            // tbMovieGenre
            // 
            this.tbMovieGenre.BackColor = System.Drawing.Color.MintCream;
            this.tbMovieGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieGenre.Location = new System.Drawing.Point(65, 399);
            this.tbMovieGenre.Name = "tbMovieGenre";
            this.tbMovieGenre.Size = new System.Drawing.Size(116, 20);
            this.tbMovieGenre.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Rating";
            // 
            // tbMovieID
            // 
            this.tbMovieID.BackColor = System.Drawing.Color.MintCream;
            this.tbMovieID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieID.Location = new System.Drawing.Point(40, 17);
            this.tbMovieID.Name = "tbMovieID";
            this.tbMovieID.ReadOnly = true;
            this.tbMovieID.Size = new System.Drawing.Size(47, 20);
            this.tbMovieID.TabIndex = 14;
            // 
            // tbMovieRating
            // 
            this.tbMovieRating.BackColor = System.Drawing.Color.MintCream;
            this.tbMovieRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieRating.Location = new System.Drawing.Point(65, 425);
            this.tbMovieRating.Name = "tbMovieRating";
            this.tbMovieRating.Size = new System.Drawing.Size(25, 20);
            this.tbMovieRating.TabIndex = 29;
            // 
            // tbMovieName
            // 
            this.tbMovieName.BackColor = System.Drawing.Color.MintCream;
            this.tbMovieName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieName.Location = new System.Drawing.Point(65, 321);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(168, 20);
            this.tbMovieName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Plot";
            // 
            // tbMovieYear
            // 
            this.tbMovieYear.BackColor = System.Drawing.Color.MintCream;
            this.tbMovieYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieYear.Location = new System.Drawing.Point(65, 347);
            this.tbMovieYear.Name = "tbMovieYear";
            this.tbMovieYear.Size = new System.Drawing.Size(89, 20);
            this.tbMovieYear.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Year";
            // 
            // tbMoviePlot
            // 
            this.tbMoviePlot.BackColor = System.Drawing.Color.MintCream;
            this.tbMoviePlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMoviePlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoviePlot.Location = new System.Drawing.Point(65, 373);
            this.tbMoviePlot.Name = "tbMoviePlot";
            this.tbMoviePlot.Size = new System.Drawing.Size(116, 20);
            this.tbMoviePlot.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(732, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rented Movie ID";
            // 
            // tbRentedMovieID
            // 
            this.tbRentedMovieID.BackColor = System.Drawing.Color.MintCream;
            this.tbRentedMovieID.Location = new System.Drawing.Point(841, 274);
            this.tbRentedMovieID.Name = "tbRentedMovieID";
            this.tbRentedMovieID.Size = new System.Drawing.Size(83, 20);
            this.tbRentedMovieID.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(729, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Date Rented";
            // 
            // tbDateRented
            // 
            this.tbDateRented.BackColor = System.Drawing.Color.MintCream;
            this.tbDateRented.Location = new System.Drawing.Point(821, 300);
            this.tbDateRented.Name = "tbDateRented";
            this.tbDateRented.Size = new System.Drawing.Size(116, 20);
            this.tbDateRented.TabIndex = 35;
            // 
            // lvRentedMovies
            // 
            this.lvRentedMovies.BackColor = System.Drawing.Color.MintCream;
            this.lvRentedMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RMID,
            this.MovieIDFK,
            this.CustIDFK,
            this.DateRented,
            this.DateReturned,
            this.Rented});
            this.lvRentedMovies.ForeColor = System.Drawing.Color.Navy;
            this.lvRentedMovies.FullRowSelect = true;
            this.lvRentedMovies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRentedMovies.HideSelection = false;
            this.lvRentedMovies.Location = new System.Drawing.Point(669, 76);
            this.lvRentedMovies.Name = "lvRentedMovies";
            this.lvRentedMovies.Size = new System.Drawing.Size(583, 162);
            this.lvRentedMovies.TabIndex = 1;
            this.lvRentedMovies.UseCompatibleStateImageBehavior = false;
            this.lvRentedMovies.View = System.Windows.Forms.View.Details;
            this.lvRentedMovies.ItemActivate += new System.EventHandler(this.LvRentedMovies_ItemActivate);
            // 
            // RMID
            // 
            this.RMID.Text = "RMID";
            // 
            // MovieIDFK
            // 
            this.MovieIDFK.Text = "MovieIDFK";
            this.MovieIDFK.Width = 75;
            // 
            // CustIDFK
            // 
            this.CustIDFK.Text = "CustIDFK";
            this.CustIDFK.Width = 79;
            // 
            // DateRented
            // 
            this.DateRented.Text = "DateRented";
            this.DateRented.Width = 131;
            // 
            // DateReturned
            // 
            this.DateReturned.Text = "DateReturned";
            this.DateReturned.Width = 147;
            // 
            // Rented
            // 
            this.Rented.Text = "Rented";
            // 
            // listviewMovies
            // 
            this.listviewMovies.BackColor = System.Drawing.Color.MintCream;
            this.listviewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieID,
            this.Rating,
            this.Title,
            this.Year,
            this.Rental_Cost,
            this.Copies,
            this.Plot,
            this.Genre});
            this.listviewMovies.ForeColor = System.Drawing.Color.Navy;
            this.listviewMovies.FullRowSelect = true;
            this.listviewMovies.HideSelection = false;
            this.listviewMovies.Location = new System.Drawing.Point(6, 42);
            this.listviewMovies.Name = "listviewMovies";
            this.listviewMovies.Size = new System.Drawing.Size(621, 273);
            this.listviewMovies.TabIndex = 0;
            this.listviewMovies.UseCompatibleStateImageBehavior = false;
            this.listviewMovies.View = System.Windows.Forms.View.Details;
            this.listviewMovies.ItemActivate += new System.EventHandler(this.LvMovies_ItemActivate);
            // 
            // MovieID
            // 
            this.MovieID.Text = "MovieID";
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 98;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.Text = "Cost";
            // 
            // Copies
            // 
            this.Copies.Text = "Copies";
            // 
            // Plot
            // 
            this.Plot.Text = "Plot";
            this.Plot.Width = 146;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            // 
            // listviewCustomers
            // 
            this.listviewCustomers.BackColor = System.Drawing.Color.MintCream;
            this.listviewCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone});
            this.listviewCustomers.ForeColor = System.Drawing.Color.Navy;
            this.listviewCustomers.FullRowSelect = true;
            this.listviewCustomers.HideSelection = false;
            this.listviewCustomers.Location = new System.Drawing.Point(6, 45);
            this.listviewCustomers.Name = "listviewCustomers";
            this.listviewCustomers.Size = new System.Drawing.Size(590, 268);
            this.listviewCustomers.TabIndex = 1;
            this.listviewCustomers.UseCompatibleStateImageBehavior = false;
            this.listviewCustomers.View = System.Windows.Forms.View.Details;
            this.listviewCustomers.ItemActivate += new System.EventHandler(this.LvCustomers_ItemActivate);
            // 
            // CustID
            // 
            this.CustID.Text = "CustID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 71;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 146;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(811, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 33);
            this.label11.TabIndex = 44;
            this.label11.Text = "Store Rental Record";
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddCust.Location = new System.Drawing.Point(348, 14);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(75, 23);
            this.btnAddCust.TabIndex = 45;
            this.btnAddCust.Text = "ADD";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.BtnAddCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateCust.Location = new System.Drawing.Point(429, 14);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCust.TabIndex = 46;
            this.btnUpdateCust.Text = "UPDATE";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.BtnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteCust.Location = new System.Drawing.Point(510, 14);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCust.TabIndex = 47;
            this.btnDeleteCust.Text = "DELETE";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.BtnDeleteCust_Click);
            // 
            // tabMoviesAndCustomers
            // 
            this.tabMoviesAndCustomers.Controls.Add(this.tabStoreMovies);
            this.tabMoviesAndCustomers.Controls.Add(this.TabCustomers);
            this.tabMoviesAndCustomers.Location = new System.Drawing.Point(12, 12);
            this.tabMoviesAndCustomers.Name = "tabMoviesAndCustomers";
            this.tabMoviesAndCustomers.SelectedIndex = 0;
            this.tabMoviesAndCustomers.Size = new System.Drawing.Size(638, 482);
            this.tabMoviesAndCustomers.TabIndex = 48;
            // 
            // tabStoreMovies
            // 
            this.tabStoreMovies.Controls.Add(this.btnDeleteMovie);
            this.tabStoreMovies.Controls.Add(this.btnUpdateMovie);
            this.tabStoreMovies.Controls.Add(this.btnAddMovie);
            this.tabStoreMovies.Controls.Add(this.listviewMovies);
            this.tabStoreMovies.Controls.Add(this.tbMovieName);
            this.tabStoreMovies.Controls.Add(this.tbMovieID);
            this.tabStoreMovies.Controls.Add(this.tbMoviePlot);
            this.tabStoreMovies.Controls.Add(this.label1);
            this.tabStoreMovies.Controls.Add(this.label5);
            this.tabStoreMovies.Controls.Add(this.tbMovieCopies);
            this.tabStoreMovies.Controls.Add(this.label2);
            this.tabStoreMovies.Controls.Add(this.tbMovieGenre);
            this.tabStoreMovies.Controls.Add(this.tbMovieYear);
            this.tabStoreMovies.Controls.Add(this.label7);
            this.tabStoreMovies.Controls.Add(this.label4);
            this.tabStoreMovies.Controls.Add(this.tbMovieRating);
            this.tabStoreMovies.Controls.Add(this.label3);
            this.tabStoreMovies.Controls.Add(this.label6);
            this.tabStoreMovies.Location = new System.Drawing.Point(4, 22);
            this.tabStoreMovies.Name = "tabStoreMovies";
            this.tabStoreMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabStoreMovies.Size = new System.Drawing.Size(630, 456);
            this.tabStoreMovies.TabIndex = 0;
            this.tabStoreMovies.Text = "StoreMovies";
            this.tabStoreMovies.UseVisualStyleBackColor = true;
            // 
            // TabCustomers
            // 
            this.TabCustomers.Controls.Add(this.listviewCustomers);
            this.TabCustomers.Controls.Add(this.btnDeleteCust);
            this.TabCustomers.Controls.Add(this.btnAddCust);
            this.TabCustomers.Controls.Add(this.btnUpdateCust);
            this.TabCustomers.Controls.Add(this.tbCustomerAddr);
            this.TabCustomers.Controls.Add(this.tbCustomerFName);
            this.TabCustomers.Controls.Add(this.tbCustomerID);
            this.TabCustomers.Controls.Add(this.lblID);
            this.TabCustomers.Controls.Add(this.lblAddress);
            this.TabCustomers.Controls.Add(this.lblFirstName);
            this.TabCustomers.Controls.Add(this.lblLastName);
            this.TabCustomers.Controls.Add(this.lblPhone);
            this.TabCustomers.Controls.Add(this.tbCustomerLName);
            this.TabCustomers.Controls.Add(this.tbCustomerPhone);
            this.TabCustomers.Location = new System.Drawing.Point(4, 22);
            this.TabCustomers.Name = "TabCustomers";
            this.TabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.TabCustomers.Size = new System.Drawing.Size(630, 456);
            this.TabCustomers.TabIndex = 1;
            this.TabCustomers.Text = "Store Customers";
            this.TabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddMovie.Location = new System.Drawing.Point(397, 12);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 25;
            this.btnAddMovie.Text = "ADD";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateMovie.Location = new System.Drawing.Point(478, 12);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMovie.TabIndex = 26;
            this.btnUpdateMovie.Text = "UPDATE";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteMovie.Location = new System.Drawing.Point(559, 13);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMovie.TabIndex = 27;
            this.btnDeleteMovie.Text = "DELETE";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.BtnDeleteMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReturnMovie.Location = new System.Drawing.Point(943, 262);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(111, 41);
            this.btnReturnMovie.TabIndex = 33;
            this.btnReturnMovie.Text = "RETURN MOVIE";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.BtnReturnMovie_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundButton2.Location = new System.Drawing.Point(1060, 262);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(122, 39);
            this.roundButton2.TabIndex = 49;
            this.roundButton2.Text = "ISSUE MOVIE";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.BtnIssueMovie_Click);
            // 
            // btnBestCust
            // 
            this.btnBestCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBestCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCust.Location = new System.Drawing.Point(776, 353);
            this.btnBestCust.Name = "btnBestCust";
            this.btnBestCust.Size = new System.Drawing.Size(222, 122);
            this.btnBestCust.TabIndex = 50;
            this.btnBestCust.Text = "Wonderland\'s Best Customer";
            this.btnBestCust.UseVisualStyleBackColor = false;
            this.btnBestCust.Click += new System.EventHandler(this.BtnBestCustomer_Click);
            // 
            // btnBestMovie
            // 
            this.btnBestMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBestMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestMovie.Location = new System.Drawing.Point(999, 357);
            this.btnBestMovie.Name = "btnBestMovie";
            this.btnBestMovie.Size = new System.Drawing.Size(208, 114);
            this.btnBestMovie.TabIndex = 51;
            this.btnBestMovie.Text = "Wonderland\'s Best Movie";
            this.btnBestMovie.UseVisualStyleBackColor = false;
            this.btnBestMovie.Click += new System.EventHandler(this.BtnBestMoie_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1286, 509);
            this.Controls.Add(this.btnBestMovie);
            this.Controls.Add(this.btnBestCust);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.tabMoviesAndCustomers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDateRented);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvRentedMovies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRentedMovieID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wonderland Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMoviesAndCustomers.ResumeLayout(false);
            this.tabStoreMovies.ResumeLayout(false);
            this.tabStoreMovies.PerformLayout();
            this.TabCustomers.ResumeLayout(false);
            this.TabCustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbCustomerFName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbCustomerLName;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.TextBox tbCustomerAddr;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbMovieID;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.TextBox tbMovieGenre;
        private System.Windows.Forms.TextBox tbMovieYear;
        private System.Windows.Forms.TextBox tbMoviePlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMovieRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMovieCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRentedMovieID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDateRented;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvRentedMovies;
        private System.Windows.Forms.ColumnHeader RMID;
        private System.Windows.Forms.ColumnHeader MovieIDFK;
        private System.Windows.Forms.ColumnHeader CustIDFK;
        private System.Windows.Forms.ColumnHeader DateRented;
        private System.Windows.Forms.ColumnHeader DateReturned;
        private System.Windows.Forms.ColumnHeader Rented;
        private System.Windows.Forms.ListView listviewMovies;
        private System.Windows.Forms.ColumnHeader MovieID;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Rental_Cost;
        private System.Windows.Forms.ColumnHeader Copies;
        private System.Windows.Forms.ColumnHeader Plot;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ListView listviewCustomers;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Label label11;
        private VideoRentalStore.RoundButton btnAddCust;
        private VideoRentalStore.RoundButton btnUpdateCust;
        private VideoRentalStore.RoundButton btnDeleteCust;
        private System.Windows.Forms.TabControl tabMoviesAndCustomers;
        private System.Windows.Forms.TabPage tabStoreMovies;
        private System.Windows.Forms.TabPage TabCustomers;
        private VideoRentalStore.RoundButton btnDeleteMovie;
        private VideoRentalStore.RoundButton btnUpdateMovie;
        private VideoRentalStore.RoundButton btnAddMovie;
        private VideoRentalStore.RoundButton btnReturnMovie;
        private VideoRentalStore.RoundButton roundButton2;
        private VideoRentalStore.RoundButton btnBestCust;
        private VideoRentalStore.RoundButton btnBestMovie;
    }
}

