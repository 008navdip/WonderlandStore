using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonderlandStore
{
   public class WonderlandDatabaseOperations
    {
        // Creating Connection
        SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-L437ARAR;Initial Catalog=Wonderland;Integrated Security=True");
        // reader object
        SqlDataReader Reader;
        // command object
        SqlCommand Command = new SqlCommand();
        string SQLQuery = ""; // for query strings


            // Who is Best Customer in wonderland
        public void WhoIsBestCustomerInWonderland()
        {
            int Top = 0, maximum = 0, Total = 0;
            string q = "";
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                string Val = "Select IDENT_CURRENT('Customer')";

                Command.CommandText = Val;
                Connection.Open();
                Total = Convert.ToInt32(Command.ExecuteScalar());

                for (int i = 1; i <= Total; i++)
                {

                    q = "select Count(*) from RentedMovies where CustIDFK= '" + i + "'";


                    Command.CommandText = q;
                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    if (count > maximum)
                    {
                        maximum = count;
                        Top = i;
                    }
                }
                this.SQLQuery = "Select FirstName from Customer where CustID ='" + Top + "'";
                this.Command.CommandText = this.SQLQuery;
                String FirstName = Convert.ToString(Command.ExecuteScalar());
                MessageBox.Show("Wonderland's Best Customer: " + FirstName + "\nHis movies: " + maximum, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception " + exception.Message);
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

        }


            // Which movie is best in wonderland 
        public void FindBestMovieInWonderland()
        {
            int Top = 0, Max = 0, Total = 0;
            string q = "";
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                string Val = "Select IDENT_CURRENT('Movies')";

                Command.CommandText = Val;
                Connection.Open();
                Total = Convert.ToInt32(Command.ExecuteScalar());

                for (int i = 1; i <= Total; i++)
                {

                    q = "select Count(*) from RentedMovies where MovieIDFK= '" + i + "'";


                    Command.CommandText = q;
                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    if (count > Max)
                    {
                        Max = count;
                        Top = i;
                    }
                }


                this.SQLQuery = "Select Title from Movies where MovieID ='" + Top + "'";
                this.Command.CommandText = this.SQLQuery;
                String Title = Convert.ToString(Command.ExecuteScalar());
                MessageBox.Show("Wonderland's Best movie  " + Title + "\nGone on Rent: " + Max + " times", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception " + exception.Message);
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

        }

        // Retrive All Rented Records
        public DataTable RetrieveRentals()
        {
            DataTable tmp = new DataTable();
            try
            {
                Command.Connection = Connection;
                SQLQuery = "SELECT * FROM RentedMovies Order by RMID DESC";
                Command.CommandText = SQLQuery;
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    tmp.Load(Reader);
                }
                return tmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
                if (Reader != null)
                {
                    Reader.Close();
                }
            }
        }
        // Method to Add Rentals
        public void AddNewRental(int MovieIDFK, int CustIDFK, DateTime dateRented, int copies, int rented)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                SQLQuery = "INSERT INTO RentedMovies(MovieIDFK, CustIDFK, DateRented,Rented) VALUES (@MovieIDFK,@CustIDFK,@DateRented,@Rented)";
                Command.Parameters.AddWithValue("@MovieIDFK", MovieIDFK);
                Command.Parameters.AddWithValue("@CustIDFK", CustIDFK);
                Command.Parameters.AddWithValue("@DateRented", dateRented);
                Command.Parameters.AddWithValue("@Rented", rented);
                Command.CommandText = SQLQuery;
                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

        }
        // method to change rental record
        public void ChangeRentals(int RMID, int MovieID, DateTime dateRented, DateTime dateReturned)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                int TotalRent = 0, cost = 0;
                // no of days movie was on rent
                double daysOut = (dateReturned - dateRented).TotalDays;
                SQLQuery = "SELECT Rental_Cost FROM Movies WHERE MovieID = @MovieIDFK";
                Command.Parameters.AddWithValue("@MovieIDFK", MovieID);
                Command.CommandText = SQLQuery;
                Connection.Open();
                cost = Convert.ToInt32(Command.ExecuteScalar());
               
                 
                
                if (Convert.ToInt32(daysOut) == 0)
                {
                       TotalRent = cost; // total rent for 1 day
                }
                else
                // total rent for daysOut > 1
                {
                    TotalRent = Convert.ToInt32(daysOut) * cost;
                }
                // make sure date returned = current date
                SQLQuery = "UPDATE RentedMovies SET DateReturned = @DateReturned WHERE RMID = @RMID";
                Command.Parameters.AddWithValue("@DateReturned", dateReturned);
                Command.Parameters.AddWithValue("@RMID", RMID);
                Command.CommandText = SQLQuery;
                Command.ExecuteNonQuery();

                // subtract from copies
                SQLQuery = "UPDATE Movies SET copies = copies+1 WHERE MovieID = @MovieIDFK";
                Command.CommandText = SQLQuery;
                Command.ExecuteNonQuery();
                // Change Rented Status
                SQLQuery = "UPDATE RentedMovies SET Rented = 0 WHERE RMID = @RMID";
                Command.CommandText = SQLQuery;
                Command.ExecuteNonQuery();
                // Display total Rent
                MessageBox.Show("TOTAL RENT:  " + TotalRent,"Total",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Exception: " + ex.Message);
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }
    // below method retrive all movies
        public DataTable RetrieveAllMovies()
        { 
            DataTable temp = new DataTable();
            try
            {
                Command.Connection = Connection;
                SQLQuery = "Select * from Movies";

                Command.CommandText = SQLQuery;
                //open connection
                Connection.Open();

                // reader execute from command
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    temp.Load(Reader);
                }
                return temp;
            }
            catch (Exception ex)
            {
                // display message
                MessageBox.Show("Database Exception" + ex.Message);
                return null;
            }
            finally
            {
                // close reader object
                if (Reader != null)
                {
                    Reader.Close();
                }

                // connection close finally
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

        }



            // below function adds new movie to Movies Table in DB
        public void AddNewMovie(string Rating, string Title, string Year, string Rental_Cost, string Plot, string Genre, int copies)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                SQLQuery = "Insert into Movies(Rating, Title, Year, Rental_Cost, Plot, Genre, copies) Values( @Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre, @copies)";
                Command.Parameters.AddWithValue("@Rating", Rating);
                Command.Parameters.AddWithValue("@Title", Title);
                Command.Parameters.AddWithValue("@Year", Year);
                Command.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Command.Parameters.AddWithValue("@Plot", Plot);
                Command.Parameters.AddWithValue("@Genre", Genre);
                Command.Parameters.AddWithValue("@copies", copies);

                Command.CommandText = SQLQuery;

                // open connection
                Connection.Open();

                // query execute
                Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // display error
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // close connection
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }

        // below method deletes a movie from Movies Table
        public void RemoveMovie(int MovieID)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;


                //blow code is to check if the Movie is rented
                String check = "";
                check = "select Count(*) from RentedMovies where MovieIDFK = @MovieID and Rented ='1' ";
                SqlParameter[] parameterArray = new SqlParameter[] { new SqlParameter("@MovieID", MovieID) };
                Command.Parameters.Add(parameterArray[0]);

                Command.CommandText = check;
                Connection.Open();
                //this code will delete the movie if its not rented otherwise the else statement would work
                int count = Convert.ToInt32(Command.ExecuteScalar());
                if (count == 0)
                {
                    String k = "Delete from Movies where MovieID like @MovieID";
                    Command.CommandText = k;
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "total rent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //display the message if he has a movie on rent 
                    MessageBox.Show("Movie is rented by this customer", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception" + exception.Message);
            }
            finally
            {
                if (this.Connection != null)
                {
                    this.Connection.Close();
                }

            }
        }

         // below method changes movie record in Movies Table
        public void ChangeMovieRecordByID(int MovieID, string Rating, string Title, int Year, string Plot, string Genre, int copies)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                // query
                SQLQuery = "Update Movies Set Rating = @Rating, Title = @Title, Year = @Year,  Plot = @Plot, Genre = @Genre, copies = @copies where MovieID like @MovieID";
               // set parameters
                Command.Parameters.AddWithValue("@MovieID", MovieID);
                Command.Parameters.AddWithValue("@Rating", Rating);
                Command.Parameters.AddWithValue("@Title", Title);
                Command.Parameters.AddWithValue("@Year", Year);
                Command.Parameters.AddWithValue("@Plot", Plot);
                Command.Parameters.AddWithValue("@Genre", Genre);
                Command.Parameters.AddWithValue("@copies", copies);

                Command.CommandText = SQLQuery;

                //open db connection
                Connection.Open();

                // Execute non query
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // display error msg
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // close connection finally
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }
        // below function can be used to login into the system
        public bool isAuthorized(string username, string password)
        {
            try
            {
                Command.Connection = Connection;
                SQLQuery = "SELECT user_name, password FROM users WHERE user_name = @user AND password = @pass;";
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@user", username);
                Command.Parameters.AddWithValue("@pass", password);
                Command.CommandText = SQLQuery;
                Connection.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    // if user is found in the database
                    return true;
                }
                else
                {
                    // else
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (Reader != null)
                {
                    Reader.Close();
                }
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }
        // if user registration is required below method can be used
        public bool RegNewUser(string username, string password)
        {
            try
            {
                if (isAuthorized(username, password))
                {
                    return false;
                }
                else
                {
                    Command.Parameters.Clear();
                    Command.Connection = Connection;
                    Command.CommandText = "INSERT into users(user_name,password) VALUES(@username,@password)";
                    Command.Parameters.AddWithValue("@username", username);
                    Command.Parameters.AddWithValue("@password", password);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }

       // Retrive Customer Data
        public DataTable RetrieveCustomerRecords()
        {
            DataTable dtCustRecords = new DataTable();
            try
            {
                Command.Connection = Connection;
                SQLQuery = "SELECT * from Customer";
                Command.CommandText = SQLQuery;
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dtCustRecords.Load(Reader);
                }
                return dtCustRecords;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (Reader != null)
                {
                    Reader.Close();
                }
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }
        // Insert new customer in Customers Table
        public void InsertNewCustomer(string firstname, string lastname, string address, string phone)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                SQLQuery = "INSERT INTO Customer(FirstName,LastName,Address,Phone) VALUES (@fname,@lname,@addr,@phone)";
                Command.Parameters.AddWithValue("@fname", firstname);
                Command.Parameters.AddWithValue("@lname", lastname);
                Command.Parameters.AddWithValue("@addr", address);
                Command.Parameters.AddWithValue("@phone", phone);

                Command.CommandText = SQLQuery;

                Connection.Open();
                Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                // closing objects
                if (Connection != null)
                {
                    Connection.Close();
                }
                if (Reader != null)
                {
                    Reader.Close();
                }
            }
        }
        // delete a customer from Customer table by usng id
        public void DeleteCustomerById(int id)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                SQLQuery = "SELECT Count(*) FROM RentedMovies WHERE CustIDFK=@custid";
                Command.Parameters.AddWithValue("@custid", id);
                Command.CommandText = SQLQuery;
                Connection.Open();
                int count = Convert.ToInt32(Command.ExecuteScalar());
                if (count == 0)
                {
                    SQLQuery = "DELETE FROM Customer WHERE CustID = @custid";
                    Command.CommandText = SQLQuery;
                    Command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("A movie is linked to this customer", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }

            }
        }
            // below function can be used to update customer record in customers table
        public void updateCustomerRecord(int CustID, string FirstName, string LastName, string Address, string Phone)
        {
            try
            {
                Command.Parameters.Clear();
                Command.Connection = Connection;
                SQLQuery = "Update Customer Set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone where CustID = @CustID";
                Command.Parameters.AddWithValue("@CustID", CustID);
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@LastName", LastName);
                Command.Parameters.AddWithValue("@Address", Address);
                Command.Parameters.AddWithValue("@Phone", Phone);
                Command.CommandText = SQLQuery;
                //connection opened
                Connection.Open();

                // Executed query
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // show error Message
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // close connection
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }
       // below method is used in UnitTesting the DB Connection
        public bool TestWonderlandDatabaseConnection()
        {
            if(Connection.State!=ConnectionState.Open)
            {
                Connection.Open();
            }
            return true;
        }
       
    }
}
