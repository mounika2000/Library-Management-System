using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Transactions_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database4.mdf\";Integrated Security=True");
        public String Book1, Book2, Borrower;
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static Transactions_UserControl _instance;
        public static Transactions_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactions_UserControl();
                }
                return _instance;
            }
        }
        public Transactions_UserControl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT borrower FROM Books where accNo='" + AccNoTextField.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                Borrowedby_label.Text = Borrower = dr[0].ToString();
            }
            else
            {
                Borrowedby_label.Text = Borrower = "";

            }

            con.Close();

        }

        private void Borrowedby_label_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchbook_button.PerformClick();
            if (Borrower != "")
            {
                MessageBox.Show("Book is already borrowed by some other Borrower with Borrower ID: \n" + Borrower);
                return;
            }
            SearchB_Button.PerformClick();
            if((Book1 !="") && (Book2 != ""))
            {
                MessageBox.Show("Borrower has already borrowed maximum number of books");
                return;
            }
            cmd = new SqlCommand("Transaction_Update_Books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", AccNoTextField.Text);
            cmd.Parameters.AddWithValue("@borrower", borrower_id.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>" + ex);

            }
            con.Close();


            try
            {
                if (Book1 == "")
                {
                    cmd = new SqlCommand("Transaction_Update_Book1_SP", con);
                    Book1_label.Text = AccNoTextField.Text;
                }
                else
                {
                    cmd = new SqlCommand("Transaction_Update_Book2_SP", con);
                    Book2_label.Text = AccNoTextField.Text;

                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", AccNoTextField.Text);
                cmd.Parameters.AddWithValue("@brId", borrower_id.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>"+ex );
                }
                con.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>" +ex);


            }
            con.Close();
            
            MessageBox.Show("Successfully Issued");
            Borrowedby_label.Text = borrower_id.Text;

        }

        

        private void Transactions_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Book1_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Book2_label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrower_id.Text = "";
            AccNoTextField.Text = "";
            Book1_label.Text = "Acc No.";
            Book2_label.Text = "Acc No.";
            Borrowedby_label.Text = "Borrowed By";
            
        }

        private void SearchB_Button_Click(object sender, EventArgs e)
        {
            //togetbook
            con.Open();
            String syntax="SELECT Book1 FROM Borrowers where brId='"+borrower_id.Text+"'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book1_label.Text = Book1 = dr[0].ToString();
            con.Close();
            //book 2
            con.Open();
            syntax = "SELECT Book2 FROM Borrowers where brId='" + borrower_id.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book2_label.Text = Book2 = dr[0].ToString();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchbook_button.PerformClick();
            SearchB_Button.PerformClick();
            if ((AccNoTextField.Text != Book1) && (AccNoTextField.Text != Book2))
            {
                MessageBox.Show("THE INPUTED BOOK HAS NOT BORROWED THE BOOK \n" );
                return;
            }
                    
            
            try
            {
                if (Book1 == AccNoTextField.Text)
                {
                    cmd = new SqlCommand("Transaction_Update_Book1_SP", con);
                    Book1_label.Text = "";
                }
                else
                {
                    cmd = new SqlCommand("Transaction_Update_Book2_SP", con);
                    Book2_label.Text = "";

                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brId", borrower_id.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>" + ex);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>" + ex);


            }

            con.Close();
            cmd = new SqlCommand("Transaction_Update_Books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", AccNoTextField.Text);
            cmd.Parameters.AddWithValue("@borrower", (object)DBNull.Value);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>" + ex);

            }
            con.Close();

            MessageBox.Show("Successfully Returned");
            Borrowedby_label.Text = "";
        }
    }
}
