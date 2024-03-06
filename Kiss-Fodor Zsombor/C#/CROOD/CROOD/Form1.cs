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

namespace CROOD
{
    public partial class Form1 : Form
    {
        string Server = "localhost";
        string uid = "root";
        string Password = "";
        string DataBse = "crud_muveletek";

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server +  ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "drop table if exists create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertTable = "insert into test_table(id, name, fname) values (" + TB1.Text + ",'" + TB2.Text + "', '" + TB3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void BTNRead_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "select * from test_table";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "update test_table set name='Gyula' where id = 1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string delete = "delete from test_table where id = 1";
            MySqlCommand cmd = new MySqlCommand(delete, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
