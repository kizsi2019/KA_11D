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
        string database = "crud_muveletek2";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string InsertTable = "insert into test_table(id, name, fname) values("+textBox1.Text+ ",'"+textBox2.text+,"', '"+textBox3.Text!"')";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
    }
}
