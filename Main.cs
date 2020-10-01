using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using WonderlandStore;

namespace Wonder
{
    public partial class MainForm : Form
    {
        // WonderlandDatabaseOperations object created to access its functions here in main 

        WonderlandDatabaseOperations wonderlandVideoStore = new WonderlandDatabaseOperations();
  
        public MainForm()
        {
            InitializeComponent();
  
        }
        
        private void BtnUpdateCust_Click(object sender, EventArgs e)
        {   // do not accept empty fields
            if (tbCustomerFName.Text != "" && tbCustomerLName.Text != "" && tbCustomerAddr.Text != "" && tbCustomerPhone.Text != "")
            {
                // get input in a variable
                string firstname = tbCustomerFName.Text;
                string lastname = tbCustomerLName.Text;
                string address = tbCustomerAddr.Text;
                string phone = tbCustomerPhone.Text;
                int custId = Convert.ToInt32(tbCustomerID.Text);
                wonderlandVideoStore.updateCustomerRecord(custId, firstname, lastname, address, phone);
                LoadRecordCustomerView(wonderlandVideoStore.RetrieveCustomerRecords());
                ResetTextBoxes();    
            } else
            {
                MessageBox.Show("do not left any customer field blank","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        // Reset Text
        private void ResetTextBoxes()
        {
            tbCustomerID.Text = "";
            tbCustomerFName.Text = "";
            tbCustomerAddr.Text = "";
            tbCustomerLName.Text = "";
            tbCustomerPhone.Text = "";
            tbMovieID.Text = ""; tbMovieName.Text = ""; tbMovieGenre.Text = "";
            tbMovieRating.Text = "";
            tbMovieYear.Text = ""; tbMovieCopies.Text = ""; tbMoviePlot.Text = "";
        }
        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            if (tbCustomerFName.Text != "" && tbCustomerLName.Text != "" && tbCustomerAddr.Text != "" && tbCustomerPhone.Text != "")
            {
        
                wonderlandVideoStore.InsertNewCustomer(tbCustomerFName.Text, tbCustomerLName.Text, tbCustomerAddr.Text, tbCustomerPhone.Text);
                LoadRecordCustomerView(wonderlandVideoStore.RetrieveCustomerRecords()); 
                ResetTextBoxes();
            }
            else
            {
                MessageBox.Show("do not leave customer text boxes blank", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            if(tbCustomerID.Text!="")
            {
                // are u sure to delete
                int custId = Convert.ToInt32(tbCustomerID.Text);
                DialogResult mbresult = MessageBox.Show("Are you sure?", "customer", MessageBoxButtons.YesNo);
                if(mbresult.ToString()=="Yes")
                {
                    wonderlandVideoStore.DeleteCustomerById(custId);
                    MessageBox.Show("Customer Removed!","Ok",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadRecordCustomerView(wonderlandVideoStore.RetrieveCustomerRecords());
                    ResetTextBoxes();
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
    // refresh all list view on form load     
            LoadRecordCustomerView(wonderlandVideoStore.RetrieveCustomerRecords());
            LoadRecordMoviesView(wonderlandVideoStore.RetrieveAllMovies());
            LoadRentedMoviesView(wonderlandVideoStore.RetrieveRentals()); // update list view


        }

    
        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            // do not accept empty fields
            if(tbMovieName.Text!="" && tbMovieGenre.Text!="" && tbMovieRating.Text!="" && tbMovieYear.Text!="" && tbMovieCopies.Text!="" && tbMoviePlot.Text!="")
            {
                int MovieYear = Convert.ToInt32(tbMovieYear.Text);
                int NoOfCopies = Convert.ToInt32(tbMovieCopies.Text);
                string rent;

               
                if(DateTime.Now.Date.Year-MovieYear > 5) 
                {
                    rent = "2"; // rent is 2 if movie is older than 5 years
                }else
                {
                    rent = "5"; // rent is 5 if not
                }
                wonderlandVideoStore.AddNewMovie(tbMovieRating.Text, tbMovieName.Text, tbMovieYear.Text, rent, tbMoviePlot.Text, tbMovieGenre.Text, NoOfCopies);
                LoadRecordMoviesView(wonderlandVideoStore.RetrieveAllMovies());
                ResetTextBoxes();
            }else
            {
                MessageBox.Show("do not leave movies text boxes blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            // Do not accept empty fields
            if (tbMovieID.Text != "" && tbMovieName.Text != "" && tbMovieGenre.Text != "" && tbMovieRating.Text != "" && tbMovieYear.Text != "" && tbMovieCopies.Text != "" && tbMoviePlot.Text != "")
            {
                // get input from boxes
                int movieId = Convert.ToInt32(tbMovieID.Text);
                int copies = Convert.ToInt32(tbMovieCopies.Text);
                int year = Convert.ToInt32(tbMovieYear.Text);

                string title = tbMovieName.Text;
                string rating = tbMovieRating.Text;
                string genre = tbMovieGenre.Text;
                string plot = tbMoviePlot.Text;
                //updates movie record
                wonderlandVideoStore.ChangeMovieRecordByID(movieId, rating, title, year, plot, genre, copies);
                MessageBox.Show("Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordMoviesView(wonderlandVideoStore.RetrieveAllMovies());
                ResetTextBoxes();
            }else
            {
                MessageBox.Show("do not leave movies boxes blank", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            if(tbMovieID.Text!="")
            {
                // make sure
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if(result.ToString()=="Yes")
                {
                    int movieId = Convert.ToInt32(tbMovieID.Text);
                    // delete a movie by its id
                    wonderlandVideoStore.RemoveMovie(movieId); 
                    LoadRecordMoviesView(wonderlandVideoStore.RetrieveAllMovies());
                    ResetTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("No movie selected","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private void BtnIssueMovie_Click(object sender, EventArgs e)
        {
            // check empty movie id and custid
            if(tbMovieID.Text !="" && tbCustomerID.Text!="")
            {
                if(tbMovieCopies.Text!="0")
                {
                    int movieId = Convert.ToInt32(tbMovieID.Text);
                    int custId = Convert.ToInt32(tbCustomerID.Text);
                    int copies = Convert.ToInt32(tbMovieCopies.Text);
                    //set  Dateof issue = current date and ented value to 1
                    wonderlandVideoStore.AddNewRental(movieId, custId, DateTime.Now, copies, 1); // adds rented movie
                    LoadRentedMoviesView(wonderlandVideoStore.RetrieveRentals()); // update list view
                    // reset all textboxes
                    ResetTextBoxes();
                    

                }
                else
                {
                    MessageBox.Show("No more copies left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Please select customer and movie from list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void BtnReturnMovie_Click(object sender, EventArgs e)
        {
            // do not accept empty fields
            if(tbMovieID.Text!="" && tbDateRented.Text!="" && tbRentedMovieID.Text!="")
            {
                int rmid = Convert.ToInt32(tbRentedMovieID.Text);
                int movieId = Convert.ToInt32(tbMovieID.Text);
                String date = tbDateRented.Text;
                // change rented status to 1 in database table
                wonderlandVideoStore.ChangeRentals(rmid, movieId, Convert.ToDateTime(date), DateTime.Now);
                LoadRecordCustomerView(wonderlandVideoStore.RetrieveCustomerRecords());
                LoadRecordMoviesView(wonderlandVideoStore.RetrieveAllMovies());
                LoadRentedMoviesView(wonderlandVideoStore.RetrieveRentals());
                // clears all inputs
                ResetTextBoxes(); 
                ResetTextBoxes(); 
                tbRentedMovieID.Text = ""; 
                tbDateRented.Text = "";
            }else
            {
                MessageBox.Show("Please Select a Movie to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // closes the main application on form closing
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
       WonderlandDatabaseOperations wlDBops = new WonderlandDatabaseOperations();

        private void BtnBestCustomer_Click(object sender, EventArgs e)
        {
            wlDBops.WhoIsBestCustomerInWonderland();
        }

        private void BtnBestMoie_Click(object sender, EventArgs e)
        {
            wlDBops.FindBestMovieInWonderland();
        }

        private void LvRentedMovies_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem rentedItem= lvRentedMovies.SelectedItems[0];
            tbRentedMovieID.Text = rentedItem.SubItems[0].Text;
            tbDateRented.Text = rentedItem.SubItems[3].Text;
            tbMovieID.Text = rentedItem.SubItems[1].Text;
        }

        private void LvMovies_ItemActivate(object sender, EventArgs e)
        {
     

            ListViewItem item = listviewMovies.SelectedItems[0];
            tbMovieID.Text = item.SubItems[0].Text;
            tbMovieRating.Text = item.SubItems[1].Text;
            tbMovieName.Text = item.SubItems[2].Text;
            tbMovieYear.Text = item.SubItems[3].Text;
            tbMovieCopies.Text = item.SubItems[5].Text;
            tbMoviePlot.Text =  item.SubItems[6].Text;
            tbMovieGenre.Text = item.SubItems[7].Text;

        }

        private void LvCustomers_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = listviewCustomers.SelectedItems[0];
            tbCustomerID.Text = item.SubItems[0].Text;
            tbCustomerFName.Text = item.SubItems[1].Text;
            tbCustomerLName.Text = item.SubItems[2].Text;
            tbCustomerAddr.Text = item.SubItems[3].Text;
            tbCustomerPhone.Text = item.SubItems[4].Text;
        }

        #region functions to update views
        private void LoadRecordCustomerView(DataTable d)
        {
            listviewCustomers.Items.Clear();

            for (int i = 0; i < d.Rows.Count; i++)
            {

                listviewCustomers.Items.Add(d.Rows[i].ItemArray[0].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[1].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[2].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[3].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[4].ToString());
            }


        }
        private void LoadRecordMoviesView(DataTable d)
        {
            listviewMovies.Items.Clear();

            foreach (DataRow row in d.Rows)
            {
                string[] items = { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                listviewMovies.Items.Add(new ListViewItem(items));
            }

        }
        private void LoadRentedMoviesView(DataTable d)
        {
            lvRentedMovies.Items.Clear();
            foreach (DataRow row in d.Rows)
            {
                string[] items = { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() };
                lvRentedMovies.Items.Add(new ListViewItem(items));
            }

        }
        #endregion
    }
}
