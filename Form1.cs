using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database4.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private string getUserName()
        {
            //fetch data from database
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
             return temp;
            


        }
        private string getPassword()
        {
            //fetch data from database
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String uname= getUserName(), upass =getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if(uname.Equals(name) && pass.Equals(upass))
            {
                //login
                label5.Hide();
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

            }
            else
            {
                //don't login
                label5.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
