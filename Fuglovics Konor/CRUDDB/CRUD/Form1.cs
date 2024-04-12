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
        string database = "oscar";
            
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
            string SQL = "SELECT film.ev, film.cim FROM film WHERE nyert ORDER BY ev;";
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
            string updateTable = "update test_table set name='Gyula' where id = 1";
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
            string delete = "Delete from test_table where id = 3";
            MySqlCommand cmd = new MySqlCommand(delete, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT nyert, ev, cim FROM film WHERE nyert = '1' ORDER BY ev ASC";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT ev FROM film GROUP BY ev HAVING COUNT(id)>=10";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT ev, cim FROM film where bemutato BETWEEN '1939-01-01' AND '1945-01-01'";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, COUNT(film.id) AS db FROM film, kapcsolat, keszito WHERE film.id=kapcsolat.filmid AND kapcsolat.keszitoid=keszito.id AND keszito.producer GROUP BY keszito.nev HAVING COUNT(film.id)>1; ";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN(SELECT kapcsolat.filmid FROM kapcsolat, keszito WHERE keszito.id= kapcsolat.keszitoid AND nev = 'Clint Eastwood') AND nev<>'Clint Eastwood'; ";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN(SELECT kapcsolat.filmid FROM kapcsolat, keszito WHERE keszito.id= kapcsolat.keszitoid AND nev = 'Clint Eastwood') AND nev<>'Clint Eastwood'; ";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void SQL7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid +
";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT keszito.nev FROM keszito WHERE keszito.id NOT IN (SELECT kapcsolat.keszitoid FROM kapcsolat, film WHERE kapcsolat.filmid=film.id AND film.bemutato IS NOT NULL) AND keszito.producer;";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
