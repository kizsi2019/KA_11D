using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            //MI A FASZT KELL ÍRNI!?!?!?!
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string conString = "server" + ??? +";uid" + ??? +";pwd" + ??? +";database" + ???;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string InsertTable = "Insert into test_table(id, name, fname) values(" +???.text+ ",'" +???.text+ "','" ???.text+"')";
            MySqlCommand cmd = new MySqlCommand(InsertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString);
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            //FUCK THIS SHIT I GIVE UP!!
        }

        private void Read_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            
        }
    }
}
