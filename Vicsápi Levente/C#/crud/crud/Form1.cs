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

namespace crud
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertTable = "insert into test_table(id, name, fname) values ("+tb1.Text+ ", '"+tb2.Text+ "', '"+tb3.Text+"' )";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select * from test_table";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "update test_table set name ='Gyula' where id = 1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string deleteTable = "delete from test_table where id = 2";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev\r\n    FROM keszito\r\n    WHERE keszito.id NOT IN\r\n      (\r\n      SELECT kapcsolat.keszitoid\r\n      FROM kapcsolat, film\r\n      WHERE kapcsolat.filmid=film.id\r\n      AND film.bemutato IS NOT NULL\r\n      )\r\n      AND keszito.producer;";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select film.ev, film.cim from film where nyert order by ev;";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select film.ev from film group by ev having count(id) >= 10;";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim\r\n    FROM film\r\n    WHERE ev BETWEEN 1939 And 1945\r\n      AND bemutato BETWEEN \"1939-1-1\" AND \"1945-12-31\";;";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim\r\n    FROM film\r\n    WHERE Year(bemutato)-ev>=10\r\n      AND nyert;";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, COUNT(film.id) AS db\r\n    FROM film, kapcsolat, keszito\r\n    WHERE film.id=kapcsolat.filmid AND kapcsolat.keszitoid=keszito.id\r\n      AND keszito.producer\r\n    GROUP BY keszito.nev\r\n    HAVING COUNT(film.id)>1;";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT DISTINCT keszito.nev\r\n    FROM keszito, kapcsolat\r\n    WHERE keszito.id=kapcsolat.keszitoid\r\n      AND kapcsolat.filmid IN\r\n        (\r\n        SELECT kapcsolat.filmid\r\n        FROM kapcsolat, keszito\r\n        WHERE keszito.id=kapcsolat.keszitoid\r\n          AND nev=\"Clint Eastwood\"\r\n        )\r\n      AND nev<>\"Clint Eastwood\";";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
