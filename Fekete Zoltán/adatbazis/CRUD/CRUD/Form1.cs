using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "crud_muveletek";
            
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + 
                ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "create table test_table(Id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
                ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertTable = "insert into test_table(id, name, fname) values(" + TB1.Text + ", '" + TB2.Text + "', '" + TB3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void BTNRead_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
                ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "select * from test_table";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable(); 
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
               ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "Update test_table set name='Gyula' where id = 1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
              ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string deleteTable = "Delete from test_table where id = 3";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
    }
}
