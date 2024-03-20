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
        string DataBse = "oscar";

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

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "select film.ev, film.cim from film where nyert order by ev";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT film.ev\r\nFROM film\r\nGROUP BY film.ev\r\nHAVING COUNT(id)>=10;";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT film.cim\r\nFROM film\r\nWHERE film.ev BETWEEN 1939 AND 1945\r\n\tAND film.bemutato BETWEEN \"1939-1-1\" AND \"1945-12-31\";";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT film.cim\r\nFROM film\r\nWHERE YEAR(film.bemutato)-film.ev>=10\r\n\tAND film.nyert;\r\n";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, COUNT(film.id) AS db\r\nFROM film, keszito, kapcsolat\r\nWHERE film.id=kapcsolat.filmid AND keszito.id=kapcsolat.keszitoid\r\n\tAND keszito.producer\r\nGROUP BY keszito.nev\r\nHAVING COUNT(film.id)>1;";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT DISTINCT keszito.nev\r\nFROM keszito, kapcsolat\r\nWHERE keszito.id=kapcsolat.keszitoid\r\n\tAND kapcsolat.filmid IN\r\n    (SELECT kapcsolat.filmid\r\n      FROM kapcsolat, keszito\r\n      WHERE kapcsolat.keszitoid=keszito.id\r\n      \tAND keszito.nev=\"Clint Eastwood\")\r\n\tAND nev<>\"Clint Eastwood\";";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + Server + ";uid=" + uid + ";pwd=" + Password + ";database=" + DataBse;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string SQL = "SELECT keszito.nev\r\nFROM keszito\r\nWHERE keszito.id NOT IN\r\n\t(SELECT kapcsolat.keszitoid\r\n\tFROM kapcsolat, film\r\n\tWHERE kapcsolat.filmid=film.id\r\n\tAND film.bemutato IS NOT NULL)\r\n    AND keszito.producer;";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGV.DataSource = dt;
        }

    }
}
